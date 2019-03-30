namespace Practica2Tc
{
    partial class Practica2Form
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
            this.entryTxtBox = new System.Windows.Forms.TextBox();
            this.answersTxtBox = new System.Windows.Forms.TextBox();
            this.statesTxtBox = new System.Windows.Forms.TextBox();
            this.drawTableBtn = new System.Windows.Forms.Button();
            this.machineBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.machineTable = new System.Windows.Forms.TableLayoutPanel();
            this.reductionBtn = new System.Windows.Forms.Button();
            this.partitionTxtBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineLabel = new System.Windows.Forms.Label();
            this.processLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entryTxtBox
            // 
            this.entryTxtBox.Location = new System.Drawing.Point(34, 39);
            this.entryTxtBox.Name = "entryTxtBox";
            this.entryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.entryTxtBox.TabIndex = 0;
            this.entryTxtBox.TextChanged += new System.EventHandler(this.entryTxtBox_TextChanged);
            this.entryTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.entryTxtBox_KeyDown);
            // 
            // answersTxtBox
            // 
            this.answersTxtBox.Location = new System.Drawing.Point(184, 39);
            this.answersTxtBox.Name = "answersTxtBox";
            this.answersTxtBox.Size = new System.Drawing.Size(100, 20);
            this.answersTxtBox.TabIndex = 1;
            this.answersTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answersTxtBox_KeyDown);
            // 
            // statesTxtBox
            // 
            this.statesTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.statesTxtBox.Location = new System.Drawing.Point(311, 38);
            this.statesTxtBox.Name = "statesTxtBox";
            this.statesTxtBox.Size = new System.Drawing.Size(100, 20);
            this.statesTxtBox.TabIndex = 2;
            this.statesTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.statesTxtBox_KeyDown);
            // 
            // drawTableBtn
            // 
            this.drawTableBtn.Location = new System.Drawing.Point(569, 36);
            this.drawTableBtn.Name = "drawTableBtn";
            this.drawTableBtn.Size = new System.Drawing.Size(115, 23);
            this.drawTableBtn.TabIndex = 3;
            this.drawTableBtn.Text = "Generar ";
            this.drawTableBtn.UseVisualStyleBackColor = true;
            this.drawTableBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // machineBox
            // 
            this.machineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineBox.FormattingEnabled = true;
            this.machineBox.Items.AddRange(new object[] {
            "Maquina Estados",
            "Maquina de Transición"});
            this.machineBox.Location = new System.Drawing.Point(427, 38);
            this.machineBox.Name = "machineBox";
            this.machineBox.Size = new System.Drawing.Size(136, 21);
            this.machineBox.TabIndex = 4;
            this.machineBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.machineBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entradas ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Respuestas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Estados";
            // 
            // equalsBtn
            // 
            this.equalsBtn.Location = new System.Drawing.Point(149, 38);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(29, 20);
            this.equalsBtn.TabIndex = 8;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = true;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // machineTable
            // 
            this.machineTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.machineTable.ColumnCount = 1;
            this.machineTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.machineTable.Location = new System.Drawing.Point(24, 82);
            this.machineTable.Name = "machineTable";
            this.machineTable.RowCount = 1;
            this.machineTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.machineTable.Size = new System.Drawing.Size(345, 378);
            this.machineTable.TabIndex = 9;
            this.machineTable.Visible = false;
            // 
            // reductionBtn
            // 
            this.reductionBtn.Location = new System.Drawing.Point(690, 37);
            this.reductionBtn.Name = "reductionBtn";
            this.reductionBtn.Size = new System.Drawing.Size(72, 23);
            this.reductionBtn.TabIndex = 10;
            this.reductionBtn.Text = "Reducir";
            this.reductionBtn.UseVisualStyleBackColor = true;
            this.reductionBtn.Visible = false;
            this.reductionBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // partitionTxtBox
            // 
            this.partitionTxtBox.Location = new System.Drawing.Point(427, 82);
            this.partitionTxtBox.Multiline = true;
            this.partitionTxtBox.Name = "partitionTxtBox";
            this.partitionTxtBox.ReadOnly = true;
            this.partitionTxtBox.Size = new System.Drawing.Size(382, 378);
            this.partitionTxtBox.TabIndex = 11;
            this.partitionTxtBox.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.cargarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.crearToolStripMenuItem.Text = "1.-Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.guardarToolStripMenuItem.Text = "2.-Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cargarToolStripMenuItem.Text = "3.-Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.salirToolStripMenuItem.Text = "4.-Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // machineLabel
            // 
            this.machineLabel.AutoSize = true;
            this.machineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineLabel.Location = new System.Drawing.Point(31, 62);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.Size = new System.Drawing.Size(55, 13);
            this.machineLabel.TabIndex = 13;
            this.machineLabel.Text = "Máquina";
            this.machineLabel.Visible = false;
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.Location = new System.Drawing.Point(424, 62);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(168, 13);
            this.processLabel.TabIndex = 14;
            this.processLabel.Text = "Proceso de particionamiento";
            this.processLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de Máquina";
            // 
            // Practica2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.machineLabel);
            this.Controls.Add(this.partitionTxtBox);
            this.Controls.Add(this.reductionBtn);
            this.Controls.Add(this.machineTable);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machineBox);
            this.Controls.Add(this.drawTableBtn);
            this.Controls.Add(this.statesTxtBox);
            this.Controls.Add(this.answersTxtBox);
            this.Controls.Add(this.entryTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Practica2Form";
            this.Text = "Maquinas Finitas";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Practica2Form_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryTxtBox;
        private System.Windows.Forms.TextBox answersTxtBox;
        private System.Windows.Forms.TextBox statesTxtBox;
        private System.Windows.Forms.Button drawTableBtn;
        private System.Windows.Forms.ComboBox machineBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button equalsBtn;
        private System.Windows.Forms.TableLayoutPanel machineTable;
        private System.Windows.Forms.Button reductionBtn;
        private System.Windows.Forms.TextBox partitionTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label machineLabel;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label label4;
    }
}

