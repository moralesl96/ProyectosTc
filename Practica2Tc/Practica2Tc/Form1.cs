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

namespace Practica2Tc
{
    public partial class Practica2Form : Form
    {
        private string[] entries, answers, states;
        int flagS1 = 0, flagS2 = 0;
        Dictionary<string, string> transitions = new Dictionary<string, string>();
        Dictionary<string, string> statesflow = new Dictionary<string, string>();
        List<TextBox> boxList = new List<TextBox>();

        public Practica2Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.entryTxtBox.Text != "" && this.answersTxtBox.Text != "" && this.statesTxtBox.Text != "" && machineBox.SelectedIndex != -1)
            {
                if (drawTableBtn.Text == "Modificar")
                    machineTable.Visible = false;
                entries = entryTxtBox.Text.Split(',');
                answers = answersTxtBox.Text.Split(',');
                states = statesTxtBox.Text.Split(',');
                if (machineBox.SelectedItem.ToString().Contains("Estados"))
                    GenerateTableStates(entries.Length + 2, states.Length + 1);
                else
                    GenerateTableTransition(entries.Length + 1, states.Length + 1);
                machineTable.Visible = true;
                reductionBtn.Visible = true;
                machineLabel.Visible = true;
                drawTableBtn.Text = "Modificar";
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos y selecciona un tipo de maquina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (this.entryTxtBox.Text != "")
            {
                answersTxtBox.Text = this.entryTxtBox.Text;
                answersTxtBox.Focus();
            }

            else
            {
                entryTxtBox.Text = answersTxtBox.Text;
            }
        }

        private void entryTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                answersTxtBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void answersTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                statesTxtBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void statesTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                machineBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void machineBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                drawTableBtn.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (machineBox.SelectedItem.ToString().Contains("Estados"))
                ValidateStatesTable();
            else
                ValidateTransitionTable();
        }

        private void GenerateTableStates(int columnCount, int rowCount)
        {
            int flag = 0;
            //Clear out the existing controls, we are generating a new table layout
            machineTable.Controls.Clear();

            //Clear out the existing row and column styles
            machineTable.ColumnStyles.Clear();
            machineTable.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            machineTable.ColumnCount = columnCount;
            machineTable.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                machineTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, .3f));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    machineTable.RowStyles.Add(new RowStyle(SizeType.Percent, .3f));
                    if (x == 0)
                    {
                        if (y > 0)
                        {
                            Label cmd = new Label();
                            cmd.Text = states[y - 1];     //Finally, add the control to the correct location in the tab
                            machineTable.Controls.Add(cmd, x, y);
                        }
                        else
                        {
                            Label cmd = new Label();
                            cmd.Text = "";     //Finally, add the control to the correct location in the table
                            machineTable.Controls.Add(cmd, x, y);
                        }
                    }
                    //Add the Text Boxes for the table or the labels for the others culumns
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            TextBox cmd = new TextBox();
                            machineTable.Controls.Add(cmd, x, y);
                        }
                        else if (y == 0 && x < columnCount - 1)
                        {
                            Label cmd = new Label();
                            cmd.Text = entries[flag];     //Finally, add the control to the correct location in the table
                            machineTable.Controls.Add(cmd, x, y);
                            if (flag < entries.Length - 1)
                                flag++;
                        }
                        else
                        {
                            Label cmd = new Label();
                            cmd.Text = "R";     //Finally, add the control to the correct location in the table
                            machineTable.Controls.Add(cmd, x, y);
                        }
                    }

                }
            }
        }

        private void GenerateTableTransition(int columnCount, int rowCount)
        {
            int flag = 0;
            //Clear out the existing controls, we are generating a new table layout
            machineTable.Controls.Clear();

            //Clear out the existing row and column styles
            machineTable.ColumnStyles.Clear();
            machineTable.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            machineTable.ColumnCount = columnCount;
            machineTable.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                machineTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, .3f));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    machineTable.RowStyles.Add(new RowStyle(SizeType.Percent, .3f));
                    if (x == 0)
                    {
                        if (y > 0)
                        {
                            Label cmd = new Label();
                            cmd.Text = states[y - 1];     //Finally, add the control to the correct location in the tab
                            machineTable.Controls.Add(cmd, x, y);
                        }
                        else
                        {
                            Label cmd = new Label();
                            cmd.Text = "";     //Finally, add the control to the correct location in the table
                            machineTable.Controls.Add(cmd, x, y);
                        }
                    }
                    //Create the control, in this case we will add a button
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            TextBox cmd = new TextBox();
                            machineTable.Controls.Add(cmd, x, y);
                        }
                        else if (y == 0)
                        {
                            Label cmd = new Label();
                            cmd.Text = entries[flag];     //Finally, add the control to the correct location in the table
                            machineTable.Controls.Add(cmd, x, y);
                            if (flag < entries.Length - 1)
                                flag++;
                        }
                    }

                }
            }
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryTxtBox.Clear();
            statesTxtBox.Clear();
            answersTxtBox.Clear();
            drawTableBtn.Text = "Generar";
            machineLabel.Visible = false;
            machineTable.Visible = false;
            reductionBtn.Visible = false;
            partitionTxtBox.Visible = false;
            partitionTxtBox.Clear();
            processLabel.Visible = false;
            machineBox.SelectedIndex = -1;
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int flag = 0;
            List<string> tablecontent = new List<string>();
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                machineTable.Visible = false;
                machineLabel.Visible = false;
                reductionBtn.Visible = true;
                partitionTxtBox.Visible = false;
                partitionTxtBox.Clear();
                processLabel.Visible = false;
                drawTableBtn.Text = "Modificar";

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        if (flag == 0)
                        {
                            entryTxtBox.Text = line;
                            flag++;
                        }
                        else if (flag == 1)
                        {
                            answersTxtBox.Text = line;
                            flag++;
                        }
                        else if (flag == 2)
                        {
                            statesTxtBox.Text = line;
                            flag++;
                        }
                        else if (flag == 3)
                        {
                            if (line.Contains("Estados"))
                                machineBox.SelectedIndex = 0;
                            else
                                machineBox.SelectedIndex = 1;
                            flag++;
                        }
                        else
                            tablecontent.Add(line);
                    }
                    flag = 0;
                }
                entries = entryTxtBox.Text.Split(',');
                answers = answersTxtBox.Text.Split(',');
                states = statesTxtBox.Text.Split(',');
                if (machineBox.SelectedItem.ToString().Contains("Estados"))
                    GenerateTableStates(entries.Length + 2, states.Length + 1);
                else
                    GenerateTableTransition(entries.Length + 1, states.Length + 1);
                for (int renglon = 0; renglon < machineTable.RowCount; renglon++)
                {

                    for (int columna = 0; columna < machineTable.ColumnCount; columna++)
                    {
                        Control c = machineTable.GetControlFromPosition(columna, renglon);
                        if (renglon > 0 && columna > 0)
                        {
                            c.Text = tablecontent[flag];
                            flag++;
                        }
                    }
                }
                machineTable.Visible = true;
                reductionBtn.Visible = true;
                machineLabel.Visible = true;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (machineTable.RowCount <= 1 && machineTable.ColumnCount <= 1)
            {
                MessageBox.Show("Minimo debe haber 1 regla gramatical para guardar su gramatica.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();

                save.FileName = ".txt";

                save.Filter = "Text File | *.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.WriteLine(String.Join(",", entries));
                    writer.WriteLine(String.Join(",", answers));
                    writer.WriteLine(String.Join(",", states));
                    writer.WriteLine(machineBox.SelectedItem.ToString());
                    for (int renglon = 0; renglon < machineTable.RowCount; renglon++)
                    {

                        for (int columna = 0; columna < machineTable.ColumnCount; columna++)
                        {
                            Control c = machineTable.GetControlFromPosition(columna, renglon);
                            if (renglon > 0 && columna > 0)
                            {
                                writer.WriteLine(c.Text);
                            }

                        }
                    }
                    writer.Dispose();
                    writer.Close();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Practica2Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ValidateStatesTable()
        {
            int flagA = 1, flagS = 1;

            for (int renglon = 0; renglon < machineTable.RowCount; renglon++)
            {

                for (int columna = 0; columna < machineTable.ColumnCount; columna++)
                {
                    Control c = machineTable.GetControlFromPosition(columna, renglon);
                    if (renglon > 0 && columna > 0)
                    {
                        if (columna == machineTable.RowCount - 1)
                        {
                            if (answers.Any(c.Text.Contains))
                                flagA = 1;
                            else
                            {
                                flagA = 0;
                                break;
                            }
                        }
                        if (columna < machineTable.ColumnCount - 1)
                        {
                            if (states.Any(c.Text.Contains))
                                flagS = 1;
                            else
                            {
                                flagS = 0;
                                break;
                            }
                        }
                    }

                }

                if (flagS == 0 || flagA == 0)
                    break;
            }
            if (flagA == 1 && flagS == 1)
            {
                FirstpartitionState();
            }
            else if (flagA == 0)
                MessageBox.Show("Se ingreso una respuesta no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Se ingreso un estado no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void entryTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidateTransitionTable()
        {
            int flagA = 1, flagS = 1;

            for (int renglon = 0; renglon < machineTable.RowCount; renglon++)
            {

                for (int columna = 0; columna < machineTable.ColumnCount; columna++)
                {
                    Control c = machineTable.GetControlFromPosition(columna, renglon);
                    if (renglon > 0 && columna > 0)
                    {
                        if (answers.Any(c.Text.Contains))
                            flagA = 1;
                        else
                        {
                            flagA = 0;
                            break;
                        }

                        if (states.Any(c.Text.Contains))
                            flagS = 1;
                        else
                        {
                            flagS = 0;
                            break;
                        }

                    }

                }

                if (flagS == 0 || flagA == 0)
                    break;
            }
            if (flagA == 1 && flagS == 1)
            {
                MessageBox.Show("Tiene los estados y respuestas");
            }
            else if (flagA == 0)
                MessageBox.Show("Se ingreso una respuesta no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Se ingreso un estado no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FirstpartitionState()
        {
            int flag1 = 1, helper = 0;
            string transition = "", stringhelper;

            // The dictionary that will contain a list for each group of states that output certain set of the input set
            Dictionary<string, List<string>> blocks = new Dictionary<string, List<string>>();
            // Dictionary for the remaining iterations, the key will be the state group numbers
            Dictionary<string, List<string>> blocks2 = new Dictionary<string, List<string>>();
            // string key for the output dictionary
            string outputs = string.Empty;
            // string key for the state dictionary
            string statess = string.Empty;
            // string key for the remaining iterations dictionary
            string stateBlock = string.Empty;

            string debugg = string.Empty;

            string newKey = string.Empty;
            // flag for the partition loop
            bool flag = true;
            // iterator for the states
            int j = 0;
            int blockCount = 0;
            int partCount = 1;
            // List used to get the list of certain key in the dictionary
            List<string> blockList = new List<string>();
            List<string> blockList2 = new List<string>();
            // debug string, will be deleted later
            string blocksStr = string.Empty;
            for (int renglon = 0; renglon < machineTable.RowCount; renglon++)
            {

                for (int columna = 0; columna < machineTable.ColumnCount; columna++)
                {
                    Control c = machineTable.GetControlFromPosition(columna, renglon);
                    if (renglon > 0 && columna > 0)
                    {
                        if (columna < machineTable.ColumnCount - 1)
                        {
                            if (flag1 == 1)
                            {
                                transition = c.Text;
                                flag1 = 0;
                                helper++;
                            }
                            else
                            {
                                if (flagS1 == states.Length)
                                    break;
                                stringhelper = String.Concat(transition, ",", c.Text);
                                transitions.Add(states[flagS1], stringhelper);
                                flag1 = 1;
                                flagS1++;
                                helper++;
                            }
                        }
                        else if (columna == machineTable.ColumnCount - 1)
                        {
                            if (flagS2 == states.Length)
                                break;
                            statesflow.Add(states[flagS2], c.Text);
                            flagS2++;
                            helper++;
                           
                        }
                        

                    }
                }
                
            }
            partitionTxtBox.Visible = true;
            processLabel.Visible = true;


   
            blocksStr += "P1 = {";
            for (int r = 0; r < blocks.Count; r++)
            {
                blocks.TryGetValue(blocks.Keys.ElementAt(r), out blockList);
                blocksStr += "{";
                foreach (var sstate in blockList    )
                {
                    blocksStr += sstate + ", ";
                }

                // Get rid of the last comma
                blocksStr = blocksStr.Substring(0, blocksStr.Length - 2);
                blocksStr += "},";
            }
            blocksStr = blocksStr.Substring(0, blocksStr.Length - 1);
            blocksStr += "}";
            partitionTxtBox.Text += $"\n{blocksStr}";
        }
    }
    
}


