namespace Practica3Tc
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statesTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.instatesTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fistatesTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.crtableBtn = new System.Windows.Forms.Button();
            this.deterministicBtn = new System.Windows.Forms.Button();
            this.fsaTable = new System.Windows.Forms.TableLayoutPanel();
            this.dfsaTable = new System.Windows.Forms.TableLayoutPanel();
            this.fsaLabel = new System.Windows.Forms.Label();
            this.dfsaLabel = new System.Windows.Forms.Label();
            this.QLabel = new System.Windows.Forms.Label();
            this.SLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.FLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.crearToolStripMenuItem.Text = "1.-Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.guardarToolStripMenuItem.Text = "2.-Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cargarToolStripMenuItem.Text = "3.-Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.salirToolStripMenuItem.Text = "4.-Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // entryTxtBox
            // 
            this.entryTxtBox.Location = new System.Drawing.Point(12, 40);
            this.entryTxtBox.Name = "entryTxtBox";
            this.entryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.entryTxtBox.TabIndex = 1;
            this.entryTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryTxtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entradas";
            // 
            // statesTxtBox
            // 
            this.statesTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.statesTxtBox.Location = new System.Drawing.Point(118, 40);
            this.statesTxtBox.Name = "statesTxtBox";
            this.statesTxtBox.Size = new System.Drawing.Size(100, 20);
            this.statesTxtBox.TabIndex = 3;
            this.statesTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.statesTxtBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estados";
            // 
            // instatesTxtBox
            // 
            this.instatesTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.instatesTxtBox.Location = new System.Drawing.Point(224, 40);
            this.instatesTxtBox.Name = "instatesTxtBox";
            this.instatesTxtBox.Size = new System.Drawing.Size(100, 20);
            this.instatesTxtBox.TabIndex = 5;
            this.instatesTxtBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.instatesTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.instatesTxtBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estados Iniciales";
            // 
            // fistatesTxtBox
            // 
            this.fistatesTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fistatesTxtBox.Location = new System.Drawing.Point(330, 40);
            this.fistatesTxtBox.Name = "fistatesTxtBox";
            this.fistatesTxtBox.Size = new System.Drawing.Size(100, 20);
            this.fistatesTxtBox.TabIndex = 7;
            this.fistatesTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fistatesTxtBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estados Finales";
            // 
            // crtableBtn
            // 
            this.crtableBtn.Location = new System.Drawing.Point(447, 36);
            this.crtableBtn.Name = "crtableBtn";
            this.crtableBtn.Size = new System.Drawing.Size(102, 24);
            this.crtableBtn.TabIndex = 9;
            this.crtableBtn.Text = "Crear Tabla";
            this.crtableBtn.UseVisualStyleBackColor = true;
            this.crtableBtn.Click += new System.EventHandler(this.crtableBtn_Click);
            // 
            // deterministicBtn
            // 
            this.deterministicBtn.Location = new System.Drawing.Point(555, 36);
            this.deterministicBtn.Name = "deterministicBtn";
            this.deterministicBtn.Size = new System.Drawing.Size(90, 24);
            this.deterministicBtn.TabIndex = 10;
            this.deterministicBtn.Text = "Deterministico";
            this.deterministicBtn.UseVisualStyleBackColor = true;
            this.deterministicBtn.Visible = false;
            this.deterministicBtn.Click += new System.EventHandler(this.deterministicBtn_Click);
            // 
            // fsaTable
            // 
            this.fsaTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.fsaTable.ColumnCount = 1;
            this.fsaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fsaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fsaTable.Location = new System.Drawing.Point(12, 135);
            this.fsaTable.Name = "fsaTable";
            this.fsaTable.RowCount = 1;
            this.fsaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fsaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.fsaTable.Size = new System.Drawing.Size(297, 369);
            this.fsaTable.TabIndex = 11;
            this.fsaTable.Visible = false;
            // 
            // dfsaTable
            // 
            this.dfsaTable.ColumnCount = 2;
            this.dfsaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dfsaTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dfsaTable.Location = new System.Drawing.Point(447, 85);
            this.dfsaTable.Name = "dfsaTable";
            this.dfsaTable.RowCount = 2;
            this.dfsaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dfsaTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dfsaTable.Size = new System.Drawing.Size(297, 353);
            this.dfsaTable.TabIndex = 12;
            this.dfsaTable.Visible = false;
            // 
            // fsaLabel
            // 
            this.fsaLabel.AutoSize = true;
            this.fsaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsaLabel.Location = new System.Drawing.Point(12, 119);
            this.fsaLabel.Name = "fsaLabel";
            this.fsaLabel.Size = new System.Drawing.Size(130, 13);
            this.fsaLabel.TabIndex = 13;
            this.fsaLabel.Text = "FSA no deterministico";
            this.fsaLabel.Visible = false;
            // 
            // dfsaLabel
            // 
            this.dfsaLabel.AutoSize = true;
            this.dfsaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsaLabel.Location = new System.Drawing.Point(444, 69);
            this.dfsaLabel.Name = "dfsaLabel";
            this.dfsaLabel.Size = new System.Drawing.Size(116, 13);
            this.dfsaLabel.TabIndex = 14;
            this.dfsaLabel.Text = "FSA  deterministico";
            this.dfsaLabel.Visible = false;
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLabel.Location = new System.Drawing.Point(12, 63);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(41, 13);
            this.QLabel.TabIndex = 15;
            this.QLabel.Text = "label5";
            this.QLabel.Visible = false;
            // 
            // SLabel
            // 
            this.SLabel.AutoSize = true;
            this.SLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLabel.Location = new System.Drawing.Point(12, 76);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(41, 13);
            this.SLabel.TabIndex = 16;
            this.SLabel.Text = "label5";
            this.SLabel.Visible = false;
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILabel.Location = new System.Drawing.Point(12, 89);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(41, 13);
            this.ILabel.TabIndex = 17;
            this.ILabel.Text = "label5";
            this.ILabel.Visible = false;
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLabel.Location = new System.Drawing.Point(12, 102);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(41, 13);
            this.FLabel.TabIndex = 18;
            this.FLabel.Text = "label5";
            this.FLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.FLabel);
            this.Controls.Add(this.ILabel);
            this.Controls.Add(this.SLabel);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.dfsaLabel);
            this.Controls.Add(this.fsaLabel);
            this.Controls.Add(this.dfsaTable);
            this.Controls.Add(this.fsaTable);
            this.Controls.Add(this.deterministicBtn);
            this.Controls.Add(this.crtableBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fistatesTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.instatesTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statesTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entryTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Practica 3 TC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox entryTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox statesTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox instatesTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fistatesTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button crtableBtn;
        private System.Windows.Forms.Button deterministicBtn;
        private System.Windows.Forms.TableLayoutPanel fsaTable;
        private System.Windows.Forms.TableLayoutPanel dfsaTable;
        private System.Windows.Forms.Label fsaLabel;
        private System.Windows.Forms.Label dfsaLabel;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Label SLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Label FLabel;
    }
}

