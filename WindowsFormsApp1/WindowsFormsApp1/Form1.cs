using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string Dev;
        public int strSize;
        public List<string> langList = new List<string>();
        public int listIndex = 0;
        public string result;
        public int indexMatch;
        public List<string> leftList = new List<string>();
        public List<string> rightList = new List<string>();
        public int flag = 0;
        public int flag2 = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void sigmaBtn_Click(object sender, EventArgs e)
        {
            leftTxtBox.Text = "Σ";
            rightTxtBox.Focus();
        }

        private void lambdaBtn_Click(object sender, EventArgs e)
        {
            rightTxtBox.Text = "λ";
            addBtn.Focus();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.leftTxtBox.Text != "" && this.rightTxtBox.Text != "")
            {
                string lowerFlag = leftTxtBox.Text;
                bool isLowerFlag = Regex.IsMatch(lowerFlag, "^[a-z0-9]+$");
                if (isLowerFlag == false)
                {
                    int match = -1;
                    for (int i = 0; i < rulesListBox.Items.Count; i++)
                    {
                        if (rulesListBox.Items[i].ToString() == leftTxtBox.Text + "->" + rightTxtBox.Text)
                        {
                            match = i;
                        }
                    }
                    int match2 = rulesListBox.FindString("Σ");
                    if (match2 == -1)
                    {
                        if (this.leftTxtBox.Text == "Σ")
                        {

                            if (match == -1)
                            {
                                rulesListBox.Items.Add(leftTxtBox.Text + "->" + rightTxtBox.Text);
                                this.leftTxtBox.Clear();
                                this.rightTxtBox.Clear();
                                this.leftTxtBox.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Esa regla ya se encuentra en tu lista, agrega otra diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tu primer regla debe contener Σ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        if (match == -1)
                        {
                            rulesListBox.Items.Add(leftTxtBox.Text + "->" + rightTxtBox.Text);
                            this.leftTxtBox.Clear();
                            this.rightTxtBox.Clear();
                            this.leftTxtBox.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Esa regla ya se encuentra en tu lista, agrega otra diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            rulesListBox.SetSelected(match, true);
                        }
                    }
                }
                else
                    MessageBox.Show("El lado izquierdo de la sentencia no puede contener puros signos Terminales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Debe rellenar ambos lados de la sentencia para formar una regla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            if (rulesListBox.SelectedIndex >= 0 && rulesListBox.SelectedIndex < rulesListBox.Items.Count)
            {
                int index = rulesListBox.SelectedIndex;
                rulesListBox.Items.RemoveAt(index);
                rulesListBox.Items.Insert(index, leftTxtBox.Text + "->" + rightTxtBox.Text);
                leftTxtBox.Clear();
                rightTxtBox.Clear();
            }
            else
            {
                MessageBox.Show("Para modificar una regla, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (this.rulesListBox.SelectedIndex >= 0)
            {
                this.rulesListBox.Items.RemoveAt(this.rulesListBox.SelectedIndex);
                leftTxtBox.Clear();
                rightTxtBox.Clear();
            }
        }

        private void rulesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string indexString = rulesListBox.Text;
            if (rulesListBox.SelectedIndex >= 0)
            {
                leftTxtBox.Text = indexString.Substring(0, indexString.IndexOf("-"));
                rightTxtBox.Text = indexString.Substring(indexString.IndexOf(">") + 1);
            }
        }

       
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rulesListBox.Items.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();

                save.FileName = ".txt";

                save.Filter = "Text File | *.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    for (int i = 0; i < rulesListBox.Items.Count; i++)
                    {
                        writer.WriteLine(rulesListBox.Items[i].ToString());
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
            else
                MessageBox.Show("Minimo debe haber 1 regla gramatical para guardar su gramatica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leftTxtBox.Clear();
            rightTxtBox.Clear();
            rulesListBox.Items.Clear();
            chainTxtBox.Clear();
            langTxtBox.Text = "{}";
            langList.Clear();
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                rulesListBox.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        rulesListBox.Items.Add(line);

                    }
                }
            }
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            leftTxtBox.Clear();
            rightTxtBox.Clear();
            rulesListBox.Items.Clear();
            chainTxtBox.Clear();
            langTxtBox.Text = "{}";
            langList.Clear();
        }

        private void rulesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (rulesListBox.SelectedItem != null)
            {
                string indexString = rulesListBox.SelectedItem.ToString();
                string chaintText = chainTxtBox.Text.ToString();
                if (chainTxtBox.Text == "")
                {
                    if (indexString.Substring(0, indexString.IndexOf("-")) == "Σ")
                    {
                        chainTxtBox.Text = rulesListBox.SelectedItem.ToString();
                        this.leftTxtBox.Clear();
                        this.rightTxtBox.Clear();
                        Dev = chainTxtBox.Text.ToString().Split('>').Last();
                        bool isLowerorDigit = Regex.IsMatch(Dev, "^[a-z0-9]+$");
                        if (Dev == "λ")
                        {
                            MessageBox.Show("La derivacion de tu cadena ha terminado.", "Derivacion Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chainTxtBox.Clear();
                            listIndex = langList.FindIndex(collection => collection.SequenceEqual(Dev));
                            if (listIndex < 0)
                            {
                                langList.Add(Dev);
                                result = String.Join(",", langList);
                                langTxtBox.Text = "{" + result + "}";
                            }
                            else
                                MessageBox.Show("Derivacion ya se encuentra en tu lenguaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }                        
                        if (isLowerorDigit == true)
                        {
                            MessageBox.Show("La derivacion de tu cadena ha terminado.", "Derivacion Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chainTxtBox.Clear();
                            listIndex = langList.FindIndex(collection => collection.SequenceEqual(Dev));
                            if (listIndex < 0)
                            {
                                langList.Add(Dev);
                                result = String.Join(",", langList);
                                langTxtBox.Text = "{" + result + "}";
                            }
                            else
                                MessageBox.Show("Derivacion ya se encuentra en tu lenguaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                        MessageBox.Show("Tu primer regla debe contener un Σ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }
                else
                {
                    strSize = indexString.Substring(0, indexString.IndexOf("-")).Length;
                    int index = Dev.IndexOf(indexString.Substring(0, indexString.IndexOf("-")));
                    if (index >= 0)
                    {
                        if (strSize > 1)
                        {
                            Dev = Dev.Substring(0, index) + indexString.Substring(indexString.IndexOf(">") + 1) + Dev.Substring(index + strSize);
                        }
                        else
                        {
                            Dev = Dev.Substring(0, index) + indexString.Substring(indexString.IndexOf(">") + 1) + Dev.Substring(index + 1);
                        }
                        // MessageBox.Show(Dev);
                        chainTxtBox.AppendText("->" + Dev.Split('>').Last());
                        this.leftTxtBox.Clear();
                        this.rightTxtBox.Clear();
                        bool isLowerorDigit = Regex.IsMatch(Dev, "^[a-z0-9]+$");
                        if (isLowerorDigit == true)
                        {
                            MessageBox.Show("La derivacion de tu cadena ha terminado.", "Derivacion Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chainTxtBox.Clear();
                            listIndex = langList.FindIndex(collection => collection.SequenceEqual(Dev));
                            if (listIndex < 0)
                            {
                                langList.Add(Dev);
                                result = String.Join(",", langList);
                                langTxtBox.Text = "{" + result + "}";
                            }
                            else
                                MessageBox.Show("Derivacion ya se encuentra en tu lenguaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {                      
                        MessageBox.Show("Esa regla no puede usarse, intente con otra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leftTxtBox.Clear();
                        rightTxtBox.Clear();
                        for (int i = 0; i < rulesListBox.Items.Count; i++)
                        {
                            string leftRuleString = rulesListBox.Items[i].ToString();
                            
                            indexMatch = Dev.IndexOf(leftRuleString.Substring(0, leftRuleString.IndexOf("-")));
                            if (indexMatch >= 0)
                                break;
                        }
                        if (indexMatch < 0)
                        {
                            MessageBox.Show("Ya no es posible hacer mas derivaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clnButton_Click(object sender, EventArgs e)
        {
            chainTxtBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rulesListBox.Items.Count > 0)
            {
                string RuleString;
                int size2 = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        for (int i = 0; i < rulesListBox.Items.Count; i++)
                        {
                            RuleString = rulesListBox.Items[i].ToString();
                            leftList.Add(RuleString.Substring(0, RuleString.IndexOf("-")));
                            rightList.Add(RuleString.Substring(RuleString.IndexOf(">") + 1));
                            if (rightList[i].Length == 2)
                                size2++;
                            if (leftList[i].Length > rightList[i].Length)
                            {
                                flag = 1;
                                break;
                            }
                        }
                        if (flag == 1)
                            break;
                    }
                    else if (j == 1)
                    {
                        for (int i = 0; i < rulesListBox.Items.Count; i++)
                        {
                            if (leftList[i].Length > 1)
                            {
                                flag = 2;
                                break;
                            }
                        }
                        if (flag == 2)
                            break;
                    }
                    else if (j == 2)
                    {
                        for (int i = 0; i < rulesListBox.Items.Count; i++)
                        {
                            if (rightList[i].Length > 2)
                            {
                                flag = 3;
                                break;
                            }
                            else if (rightList[i].Length == 1)
                                flag2++;
                        }
                        if (flag2 == rulesListBox.Items.Count || flag == 3)
                        {
                            flag = 3;
                            break;
                        }
                    }
                    else if (j == 3)
                    {
                        flag2 = 0;
                        for (int i = 0; i < rulesListBox.Items.Count; i++)
                        {
                            string right = rightList[i];
                            if ((char.IsLower(right[0]) || char.IsDigit(right[0]) ) && rightList[i].Length == 2)
                            {
                                flag2++;
                            }
                        }
                        if (flag2 == size2)
                        {
                            flag = 4;
                            break;
                        }
                        flag2 = 0;
                        for (int i = 0; i < rulesListBox.Items.Count; i++)
                        {
                            string right = rightList[i];
                            if ((char.IsUpper(right[0]) && rightList[i].Length == 2))
                            {
                                if (char.IsLower(right[1]) || char.IsDigit(right[1]) )
                                    flag2++;
                            }
                        }
                        if (flag2 == size2)
                        {
                            flag = 5;
                            break;
                        }
                    }
                }
                if (flag == 0)
                    flag = 3;
                switch (flag)
                {
                    case 1:
                        flag = 0;
                        MessageBox.Show("La Gramatica es Tipo 0 o Contractiva", "Tipo de Gramatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leftList.Clear();
                        rightList.Clear();
                        break;
                    case 2:
                        flag = 0;
                        MessageBox.Show("La Gramatica es Tipo 1 o Sensitiva de Contexto", "Tipo de Gramatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leftList.Clear();
                        rightList.Clear();
                        break;
                    case 3:
                        flag = 0;
                        flag2 = 0;
                        MessageBox.Show("La Gramatica es Tipo 2 o Libre de Contexto", "Tipo de Gramatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leftList.Clear();
                        rightList.Clear();
                        break;
                    case 4:
                        flag = 0;
                        flag2 = 0;
                        MessageBox.Show("La Gramatica es Tipo 3 o Lineal Derecha", "Tipo de Gramatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leftList.Clear();
                        rightList.Clear();
                        break;
                    case 5:
                        flag = 0;
                        flag2 = 0;
                        MessageBox.Show("La Gramatica es Tipo 3 o Lineal Izquierda", "Tipo de Gramatica", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        leftList.Clear();
                        rightList.Clear();
                        break;
                }
            }
            else
                MessageBox.Show("Debe de haber minimo 1 regla, para poder decir que tipo de gramatica es.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
                
     

        private void leftTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab )
            {
                rightTxtBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void rightTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtn_Click(this, new EventArgs());
                e.SuppressKeyPress = true;
            }
        }
    }
}
