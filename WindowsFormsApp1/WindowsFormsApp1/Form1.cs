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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string Dev;
        public Form1()
        {
            InitializeComponent();
        }

        private void sigmaBtn_Click(object sender, EventArgs e)
        {
            leftTxtBox.Text = "Σ";
        }

        private void lambdaBtn_Click(object sender, EventArgs e)
        {
            rightTxtBox.Text = "λ";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (this.leftTxtBox.Text != "" && this.rightTxtBox.Text != "")
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
                            MessageBox.Show("Esa regla ya se encuentra en tu lista, agrega otra diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tu primer regla debe contener Σ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Esa regla ya se encuentra en tu lista, agrega otra diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rulesListBox.SetSelected(match, true);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar ambos lados de la sentencia para formar una regla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Para modificar una regla, primero debe seleccionarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void rulesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (rulesListBox.SelectedItem != null)
            {
                string indexString = rulesListBox.SelectedItem.ToString();
                string chaintText = chainTxtBox.Text.ToString();
                if (chainTxtBox.Text == "")
                {
                    chainTxtBox.Text = rulesListBox.SelectedItem.ToString();
                    this.leftTxtBox.Clear();
                    this.rightTxtBox.Clear();
                }
                else
                {
                   
                    int index = chaintText.IndexOf(indexString.Substring(0, indexString.IndexOf("-")));
                    
                    Dev = chaintText.Substring(0, index) + indexString.Substring(indexString.IndexOf(">") + 1) + chaintText.Substring(index+1);
                    MessageBox.Show(Dev);
                    chainTxtBox.AppendText("->" + Dev.Split('>').Last());
                    this.leftTxtBox.Clear();
                    this.rightTxtBox.Clear();
                }
            }
        }
    }
}
