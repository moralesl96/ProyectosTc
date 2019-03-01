namespace WindowsFormsApp1
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
            this.sigmaBtn = new System.Windows.Forms.Button();
            this.rulesListBox = new System.Windows.Forms.ListBox();
            this.leftTxtBox = new System.Windows.Forms.TextBox();
            this.lambdaBtn = new System.Windows.Forms.Button();
            this.rightTxtBox = new System.Windows.Forms.TextBox();
            this.arrowlbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.chainTxtBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.typeGrBtn = new System.Windows.Forms.Button();
            this.clnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.langTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sigmaBtn
            // 
            this.sigmaBtn.Location = new System.Drawing.Point(24, 57);
            this.sigmaBtn.Name = "sigmaBtn";
            this.sigmaBtn.Size = new System.Drawing.Size(75, 23);
            this.sigmaBtn.TabIndex = 0;
            this.sigmaBtn.Text = "Σ";
            this.sigmaBtn.UseVisualStyleBackColor = true;
            this.sigmaBtn.Click += new System.EventHandler(this.sigmaBtn_Click);
            // 
            // rulesListBox
            // 
            this.rulesListBox.FormattingEnabled = true;
            this.rulesListBox.Location = new System.Drawing.Point(12, 113);
            this.rulesListBox.Name = "rulesListBox";
            this.rulesListBox.Size = new System.Drawing.Size(120, 329);
            this.rulesListBox.TabIndex = 1;
            this.rulesListBox.SelectedIndexChanged += new System.EventHandler(this.rulesListBox_SelectedIndexChanged);
            this.rulesListBox.DoubleClick += new System.EventHandler(this.rulesListBox_DoubleClick);
            // 
            // leftTxtBox
            // 
            this.leftTxtBox.Location = new System.Drawing.Point(12, 31);
            this.leftTxtBox.Name = "leftTxtBox";
            this.leftTxtBox.Size = new System.Drawing.Size(100, 20);
            this.leftTxtBox.TabIndex = 2;
            this.leftTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leftTxtBox_KeyDown);
            // 
            // lambdaBtn
            // 
            this.lambdaBtn.Location = new System.Drawing.Point(150, 57);
            this.lambdaBtn.Name = "lambdaBtn";
            this.lambdaBtn.Size = new System.Drawing.Size(75, 23);
            this.lambdaBtn.TabIndex = 3;
            this.lambdaBtn.Text = "λ";
            this.lambdaBtn.UseVisualStyleBackColor = true;
            this.lambdaBtn.Click += new System.EventHandler(this.lambdaBtn_Click);
            // 
            // rightTxtBox
            // 
            this.rightTxtBox.Location = new System.Drawing.Point(140, 31);
            this.rightTxtBox.Name = "rightTxtBox";
            this.rightTxtBox.Size = new System.Drawing.Size(100, 20);
            this.rightTxtBox.TabIndex = 4;
            this.rightTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightTxtBox_KeyDown);
            // 
            // arrowlbl
            // 
            this.arrowlbl.AutoSize = true;
            this.arrowlbl.Location = new System.Drawing.Point(118, 34);
            this.arrowlbl.Name = "arrowlbl";
            this.arrowlbl.Size = new System.Drawing.Size(16, 13);
            this.arrowlbl.TabIndex = 5;
            this.arrowlbl.Text = "->";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(6, 19);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // chainTxtBox
            // 
            this.chainTxtBox.Location = new System.Drawing.Point(150, 113);
            this.chainTxtBox.Multiline = true;
            this.chainTxtBox.Name = "chainTxtBox";
            this.chainTxtBox.ReadOnly = true;
            this.chainTxtBox.Size = new System.Drawing.Size(598, 329);
            this.chainTxtBox.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem1,
            this.guardarToolStripMenuItem,
            this.leerToolStripMenuItem});
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.crearToolStripMenuItem.Text = "Opciones";
            // 
            // crearToolStripMenuItem1
            // 
            this.crearToolStripMenuItem1.Name = "crearToolStripMenuItem1";
            this.crearToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.crearToolStripMenuItem1.Text = "1.-Crear";
            this.crearToolStripMenuItem1.Click += new System.EventHandler(this.crearToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.guardarToolStripMenuItem.Text = "2.- Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // leerToolStripMenuItem
            // 
            this.leerToolStripMenuItem.Name = "leerToolStripMenuItem";
            this.leerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.leerToolStripMenuItem.Text = "3.- Leer";
            this.leerToolStripMenuItem.Click += new System.EventHandler(this.leerToolStripMenuItem_Click);
            // 
            // modifyBtn
            // 
            this.modifyBtn.Location = new System.Drawing.Point(6, 48);
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Size = new System.Drawing.Size(75, 23);
            this.modifyBtn.TabIndex = 9;
            this.modifyBtn.Text = "Modificar";
            this.modifyBtn.UseVisualStyleBackColor = true;
            this.modifyBtn.Click += new System.EventHandler(this.modifyBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(100, 19);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Borrar";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeGrBtn);
            this.groupBox1.Controls.Add(this.clnButton);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.modifyBtn);
            this.groupBox1.Location = new System.Drawing.Point(278, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // typeGrBtn
            // 
            this.typeGrBtn.Location = new System.Drawing.Point(181, 19);
            this.typeGrBtn.Name = "typeGrBtn";
            this.typeGrBtn.Size = new System.Drawing.Size(97, 23);
            this.typeGrBtn.TabIndex = 12;
            this.typeGrBtn.Text = "Tipo Gramatica";
            this.typeGrBtn.UseVisualStyleBackColor = true;
            this.typeGrBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clnButton
            // 
            this.clnButton.Location = new System.Drawing.Point(100, 48);
            this.clnButton.Name = "clnButton";
            this.clnButton.Size = new System.Drawing.Size(75, 23);
            this.clnButton.TabIndex = 11;
            this.clnButton.Text = "Limpiar";
            this.clnButton.UseVisualStyleBackColor = true;
            this.clnButton.Click += new System.EventHandler(this.clnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reglas Gramaticales";
            // 
            // langTxtBox
            // 
            this.langTxtBox.Location = new System.Drawing.Point(150, 458);
            this.langTxtBox.Multiline = true;
            this.langTxtBox.Name = "langTxtBox";
            this.langTxtBox.ReadOnly = true;
            this.langTxtBox.Size = new System.Drawing.Size(598, 81);
            this.langTxtBox.TabIndex = 13;
            this.langTxtBox.Text = "{}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lenguaje L(G):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.langTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chainTxtBox);
            this.Controls.Add(this.arrowlbl);
            this.Controls.Add(this.rightTxtBox);
            this.Controls.Add(this.lambdaBtn);
            this.Controls.Add(this.leftTxtBox);
            this.Controls.Add(this.rulesListBox);
            this.Controls.Add(this.sigmaBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Reglas Gramaticales";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sigmaBtn;
        private System.Windows.Forms.ListBox rulesListBox;
        private System.Windows.Forms.TextBox leftTxtBox;
        private System.Windows.Forms.Button lambdaBtn;
        private System.Windows.Forms.TextBox rightTxtBox;
        private System.Windows.Forms.Label arrowlbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox chainTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerToolStripMenuItem;
        private System.Windows.Forms.Button modifyBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem1;
        private System.Windows.Forms.Button clnButton;
        private System.Windows.Forms.TextBox langTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button typeGrBtn;
    }
}

