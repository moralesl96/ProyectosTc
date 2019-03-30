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

namespace Practica3Tc
{
    public partial class Form1 : Form
    {
        private string[] entries, states, instates, fnstates;
        private string fileName = "", initialState;
        Dictionary<string, List<string>> statesDic = new Dictionary<string, List<string>>();
        List<string> newStatesString = new List<string>();
        List<string> states0 = new List<string>();
        List<string> states1 = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void crtableBtn_Click(object sender, EventArgs e)
        {
            if (this.entryTxtBox.Text != "" && this.statesTxtBox.Text != "" && this.instatesTxtBox.Text != "" && this.fistatesTxtBox.Text != "")
            {
                if (crtableBtn.Text == "Modificar Tabla")
                    fsaTable.Visible = false;
                entries = entryTxtBox.Text.Split(',');
                instates = instatesTxtBox.Text.Split(',');
                states = statesTxtBox.Text.Split(',');
                fnstates = fistatesTxtBox.Text.Split(',');
                    GenerateFSATable(entries.Length + 1, states.Length + 1);
                fsaTable.Visible = true;
                deterministicBtn.Visible = true;
                fsaLabel.Visible = true;
                crtableBtn.Text = "Modificar Tabla";
                QLabel.Text = "Q = {" + String.Join(",", entries) + "}";
                SLabel.Text = "S = {" + String.Join(",", states) + "}";
                ILabel.Text = "I = {" + String.Join(",", instates) + "}";
                FLabel.Text = "F = {" + String.Join(",", fnstates) + "}";
                QLabel.Visible = true; SLabel.Visible = true; ILabel.Visible = true; FLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void entryTxtBox_KeyDown(object sender, KeyEventArgs e)
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
                instatesTxtBox
.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void instatesTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fistatesTxtBox.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void fistatesTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                crtableBtn.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void GenerateFSATable(int columnCount, int rowCount)
        {
            int flag = 0, flagc = 0, helper;
            //Clear out the existing controls, we are generating a new table layout
            fsaTable.Controls.Clear();

            //Clear out the existing row and column styles
            fsaTable.ColumnStyles.Clear();
            fsaTable.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            fsaTable.ColumnCount = columnCount;
            fsaTable.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                fsaTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, .3f));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.
                    fsaTable.RowStyles.Add(new RowStyle(SizeType.Percent, .3f));
                    if (x == 0)
                    {
                        if (y > 0)
                        {
                            Label cmd = new Label();
                            cmd.Text = states[y - 1];
                            helper = Array.IndexOf(fnstates, cmd.Text);
                            if (Array.IndexOf(instates, cmd.Text) >= 0)
                            {
                                cmd.Text = "-> " + states[y - 1];
                                flagc = 1;
                            }
                            if (helper >= 0)
                            {
                                if (flagc == 1)
                                    cmd.Text += " ✔";
                                else
                                    cmd.Text = states[y - 1] + " ✔";
                                flagc = 0;
                            }
                            fsaTable.Controls.Add(cmd, x, y); //Finally, add the control to the correct location in the tab
                        }
                        else
                        {
                            Label cmd = new Label();
                            cmd.Text = "";     //Finally, add the control to the correct location in the table
                            fsaTable.Controls.Add(cmd, x, y);
                        }
                    }
                    //Create the control, in this case we will add a button
                    if (x > 0)
                    {
                        if (y > 0)
                        {
                            TextBox cmd = new TextBox();
                            cmd.CharacterCasing = CharacterCasing.Upper;
                            fsaTable.Controls.Add(cmd, x, y);
                        }
                        else if (y == 0)
                        {
                            Label cmd = new Label();
                            cmd.Text = entries[flag];     //Finally, add the control to the correct location in the table
                            fsaTable.Controls.Add(cmd, x, y);
                            if (flag < entries.Length - 1)
                                flag++;
                        }
                    }

                }
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int flag = 0;
            List<string> tablecontent = new List<string>();
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                fileName = f.SafeFileName;
                int index = fileName.IndexOf("Pr3_");
                if (index >= 0)
                {
                    fsaTable.Visible = false;
                    fsaLabel.Visible = false;
                    deterministicBtn.Visible = true;
                    dfsaTable.Visible = false;
                    dfsaTable.Controls.Clear();
                    dfsaLabel.Visible = false;
                    crtableBtn.Text = "Modificar Tabla";

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
                                statesTxtBox.Text = line;
                                flag++;
                            }
                            else if (flag == 2)
                            {
                                instatesTxtBox.Text = line;
                                flag++;
                            }
                            else if (flag == 3)
                            {
                                fistatesTxtBox.Text = line;
                                flag++;
                            }
                            else
                                tablecontent.Add(line);
                        }
                        flag = 0;
                    }
                    entries = entryTxtBox.Text.Split(',');
                    instates = instatesTxtBox.Text.Split(',');
                    states = statesTxtBox.Text.Split(',');
                    fnstates = fistatesTxtBox.Text.Split(',');
                    GenerateFSATable(entries.Length + 1, states.Length + 1);
                    for (int renglon = 0; renglon < fsaTable.RowCount; renglon++)
                    {

                        for (int columna = 0; columna < fsaTable.ColumnCount; columna++)
                        {
                            Control c = fsaTable.GetControlFromPosition(columna, renglon);
                            if (renglon > 0 && columna > 0)
                            {
                                c.Text = tablecontent[flag];
                                flag++;
                            }
                        }
                    }
                    fsaTable.Visible = true;
                    deterministicBtn.Visible = true;
                    fsaLabel.Visible = true;
                    QLabel.Text = "Q = {" + String.Join(",", entries) + "}";
                    SLabel.Text = "S = {" + String.Join(",", states) + "}";
                    ILabel.Text = "I = {" + String.Join(",", instates) + "}";
                    FLabel.Text = "F = {" + String.Join(",", fnstates) + "}";
                    QLabel.Visible = true; SLabel.Visible = true; ILabel.Visible = true; FLabel.Visible = true;
                }
                else
                    MessageBox.Show("Formato incorrecto de archivo, debe contener Pr3_ para poder abrirlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deterministicBtn_Click(object sender, EventArgs e)
        {
            ValidateFSATable();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entryTxtBox.Clear();
            statesTxtBox.Clear();
            instatesTxtBox.Clear();
            fistatesTxtBox.Clear();
            crtableBtn.Text = "Crear Tabla";
            QLabel.Visible = false;
            SLabel.Visible = false;
            ILabel.Visible = false;
            FLabel.Visible = false;
            deterministicBtn.Visible = false;
            fsaLabel.Visible = false;
            fsaTable.Visible = false;
            dfsaLabel.Visible = false;
            dfsaTable.Visible = false;
            fileName = "";
            fsaTable.ColumnCount = 1;
            fsaTable.RowCount = 1;

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fsaTable.RowCount <= 1 && fsaTable.ColumnCount <= 1)
            {
                MessageBox.Show("Debe haber generado la tabla para poder guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                if (fileName == "")
                    save.FileName = "Pr3_.txt";
                else
                    save.FileName = fileName;

                save.Filter = "Text File | *.txt";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.WriteLine(String.Join(",", entries));
                    writer.WriteLine(String.Join(",", states));
                    writer.WriteLine(String.Join(",", instates));
                    writer.WriteLine(String.Join(",", fnstates));
                    for (int renglon = 0; renglon < fsaTable.RowCount; renglon++)
                    {

                        for (int columna = 0; columna < fsaTable.ColumnCount; columna++)
                        {
                            Control c = fsaTable.GetControlFromPosition(columna, renglon);
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

        private void ValidateFSATable()
        {
            int flagA = 1;
            string[] helper;

            for (int renglon = 0; renglon < fsaTable.RowCount; renglon++)
            {

                for (int columna = 0; columna < fsaTable.ColumnCount; columna++)
                {
                    Control c = fsaTable.GetControlFromPosition(columna, renglon);
                    if (renglon > 0 && columna > 0)
                    {
                        helper = c.Text.Split(',');
                        if (c.Text.Contains("-") || !helper.Except(states).Any())
                            flagA = 1;
                        else
                        {
                            flagA = 0;
                            break;
                        }                        
                    }

                }

                if (flagA == 0)
                    break;
            }
            if (flagA == 1)
            {
                deterministicTable();
            }
            else if (flagA == 0)
                MessageBox.Show("Se ingreso un estado(s) no valido(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deterministicTable()
        {
            initialState = String.Join(",", instates);
            newStatesString.Add(initialState);
            statesDic.Clear();
            bool tableflag = true;
            string entryvalue = ""; 
            // MessageBox.Show(fsaTable.RowCount.ToString());
            for (int renglon = 0; renglon < fsaTable.RowCount; renglon++)
            {
                List<string> entrystate = new List<string>();
                for (int columna = 0; columna < fsaTable.ColumnCount; columna++)
                {
                    Control c = fsaTable.GetControlFromPosition(columna, renglon);
                    if (renglon > 0 && columna > 0)
                    {
                        //MessageBox.Show(columna.ToString());
                        entrystate.Add(c.Text);
                    }
                }
                //MessageBox.Show(renglon.ToString());
                if (renglon > 0)
                    statesDic.Add(states[renglon - 1], entrystate);
            }

           // for (int i=0;tableflag;i++)
           // {
                foreach (char c in newStatesString[0])
                {
                    MessageBox.Show(statesDic[c.ToString(),[0]]);
                }
           //}

            //Code to get the values of the lists on the Dictionaries
            for (int Key = 0; Key < states.Length; Key++)
            {
                for (int ListIndex = 0; ListIndex < statesDic[states[Key]].Count; ListIndex++)
                {
                    MessageBox.Show(statesDic[states[Key]][ListIndex]);
                }
            }

        }
    }
}
