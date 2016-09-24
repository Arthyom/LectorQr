namespace GenerarCodigoQt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabModo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEve = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNUA = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rutaImagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.desdeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabModo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabModo
            // 
            this.tabModo.Controls.Add(this.tabPage1);
            this.tabModo.Controls.Add(this.tabPage2);
            this.tabModo.Location = new System.Drawing.Point(2, 150);
            this.tabModo.Name = "tabModo";
            this.tabModo.SelectedIndex = 0;
            this.tabModo.Size = new System.Drawing.Size(860, 423);
            this.tabModo.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(852, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modo Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtEve);
            this.panel5.Controls.Add(this.txtNombre);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtNUA);
            this.panel5.Controls.Add(this.txtPaterno);
            this.panel5.Controls.Add(this.txtMaterno);
            this.panel5.Controls.Add(this.txtCarrera);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(6, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 167);
            this.panel5.TabIndex = 8;
            // 
            // txtEve
            // 
            this.txtEve.Location = new System.Drawing.Point(158, 142);
            this.txtEve.Name = "txtEve";
            this.txtEve.Size = new System.Drawing.Size(299, 20);
            this.txtEve.TabIndex = 6;
            this.txtEve.Tag = "6";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(299, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "2";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Evento";
            // 
            // txtNUA
            // 
            this.txtNUA.Location = new System.Drawing.Point(158, 9);
            this.txtNUA.Name = "txtNUA";
            this.txtNUA.Size = new System.Drawing.Size(299, 20);
            this.txtNUA.TabIndex = 1;
            this.txtNUA.Tag = "1";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(158, 62);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(299, 20);
            this.txtPaterno.TabIndex = 3;
            this.txtPaterno.Tag = "3";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(158, 90);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(299, 20);
            this.txtMaterno.TabIndex = 4;
            this.txtMaterno.Tag = "4";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(158, 116);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(299, 20);
            this.txtCarrera.TabIndex = 5;
            this.txtCarrera.Tag = "5";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Apeido Materno";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apeido Paterno";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "NUA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Location = new System.Drawing.Point(6, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 25);
            this.panel3.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(466, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salidaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(107, 22);
            this.toolStripDropDownButton1.Text = "Configuraciones";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutaImagenesToolStripMenuItem});
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salidaToolStripMenuItem.Text = "Salida";
            // 
            // rutaImagenesToolStripMenuItem
            // 
            this.rutaImagenesToolStripMenuItem.Name = "rutaImagenesToolStripMenuItem";
            this.rutaImagenesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rutaImagenesToolStripMenuItem.Text = "Ruta Imagenes";
            this.rutaImagenesToolStripMenuItem.Click += new System.EventHandler(this.rutaImagenesToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desdeSQLToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButton2.Text = "Generar";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(6, 339);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(152, 52);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Generar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(481, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(368, 380);
            this.panel4.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(852, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modo Lector";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(437, 348);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 43);
            this.button6.TabIndex = 13;
            this.button6.Text = "Encender";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(357, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 43);
            this.button7.TabIndex = 12;
            this.button7.Text = "Apagar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 361);
            this.panel2.TabIndex = 11;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(357, 240);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(154, 108);
            this.listBox2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(357, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 228);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(856, 163);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(738, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // desdeSQLToolStripMenuItem
            // 
            this.desdeSQLToolStripMenuItem.Name = "desdeSQLToolStripMenuItem";
            this.desdeSQLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desdeSQLToolStripMenuItem.Text = "Desde SQL";
            this.desdeSQLToolStripMenuItem.Click += new System.EventHandler(this.desdeSQLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 571);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabModo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabModo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabModo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNUA;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rutaImagenesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem desdeSQLToolStripMenuItem;
    }
}

