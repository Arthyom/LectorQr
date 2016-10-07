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
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cronogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.desdeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qrSinSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.borrarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reestablecerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lec = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabModo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tabModo.Controls.Add(this.tabPage3);
            this.tabModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabModo.Location = new System.Drawing.Point(-2, 124);
            this.tabModo.Name = "tabModo";
            this.tabModo.SelectedIndex = 0;
            this.tabModo.Size = new System.Drawing.Size(1444, 643);
            this.tabModo.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1436, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modo Registro";
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
            this.panel5.Location = new System.Drawing.Point(6, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(757, 299);
            this.panel5.TabIndex = 8;
            // 
            // txtEve
            // 
            this.txtEve.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEve.Location = new System.Drawing.Point(263, 257);
            this.txtEve.Name = "txtEve";
            this.txtEve.Size = new System.Drawing.Size(491, 39);
            this.txtEve.TabIndex = 6;
            this.txtEve.Tag = "6";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(263, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(491, 39);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Tag = "2";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 35);
            this.label6.TabIndex = 39;
            this.label6.Text = "Evento";
            // 
            // txtNUA
            // 
            this.txtNUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNUA.Location = new System.Drawing.Point(263, 10);
            this.txtNUA.Name = "txtNUA";
            this.txtNUA.Size = new System.Drawing.Size(491, 39);
            this.txtNUA.TabIndex = 1;
            this.txtNUA.Tag = "1";
            // 
            // txtPaterno
            // 
            this.txtPaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaterno.Location = new System.Drawing.Point(263, 103);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(491, 39);
            this.txtPaterno.TabIndex = 3;
            this.txtPaterno.Tag = "3";
            // 
            // txtMaterno
            // 
            this.txtMaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterno.Location = new System.Drawing.Point(263, 160);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(491, 39);
            this.txtMaterno.TabIndex = 4;
            this.txtMaterno.Tag = "4";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(263, 212);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(491, 39);
            this.txtCarrera.TabIndex = 5;
            this.txtCarrera.Tag = "5";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(399, 45);
            this.label5.TabIndex = 32;
            this.label5.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 44);
            this.label4.TabIndex = 31;
            this.label4.Text = "Apellido Materno";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 53);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 39);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 43);
            this.label1.TabIndex = 28;
            this.label1.Text = "NUA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Location = new System.Drawing.Point(6, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 28);
            this.panel3.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salidaToolStripMenuItem,
            this.entradaToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(107, 25);
            this.toolStripDropDownButton1.Text = "Configuraciones";
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rutaImagenesToolStripMenuItem});
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.salidaToolStripMenuItem.Text = "Salida";
            // 
            // rutaImagenesToolStripMenuItem
            // 
            this.rutaImagenesToolStripMenuItem.Name = "rutaImagenesToolStripMenuItem";
            this.rutaImagenesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rutaImagenesToolStripMenuItem.Text = "Ruta Imagenes";
            this.rutaImagenesToolStripMenuItem.Click += new System.EventHandler(this.rutaImagenesToolStripMenuItem_Click);
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cronogramaToolStripMenuItem,
            this.asistentesToolStripMenuItem});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // cronogramaToolStripMenuItem
            // 
            this.cronogramaToolStripMenuItem.Name = "cronogramaToolStripMenuItem";
            this.cronogramaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.cronogramaToolStripMenuItem.Text = "Cronograma";
            this.cronogramaToolStripMenuItem.Click += new System.EventHandler(this.cronogramaToolStripMenuItem_Click);
            // 
            // asistentesToolStripMenuItem
            // 
            this.asistentesToolStripMenuItem.Name = "asistentesToolStripMenuItem";
            this.asistentesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.asistentesToolStripMenuItem.Text = "Asistentes";
            this.asistentesToolStripMenuItem.Click += new System.EventHandler(this.asistentesToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desdeSQLToolStripMenuItem,
            this.qrSinSQLToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(77, 25);
            this.toolStripDropDownButton2.Text = "Generar Qr";
            // 
            // desdeSQLToolStripMenuItem
            // 
            this.desdeSQLToolStripMenuItem.Name = "desdeSQLToolStripMenuItem";
            this.desdeSQLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.desdeSQLToolStripMenuItem.Text = "Desde SQL";
            this.desdeSQLToolStripMenuItem.Click += new System.EventHandler(this.desdeSQLToolStripMenuItem_Click);
            // 
            // qrSinSQLToolStripMenuItem
            // 
            this.qrSinSQLToolStripMenuItem.Name = "qrSinSQLToolStripMenuItem";
            this.qrSinSQLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.qrSinSQLToolStripMenuItem.Text = "Desde Txt";
            this.qrSinSQLToolStripMenuItem.Click += new System.EventHandler(this.qrSinSQLToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarBaseDeDatosToolStripMenuItem,
            this.reestablecerToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(70, 25);
            this.toolStripDropDownButton3.Text = "Opciones";
            // 
            // borrarBaseDeDatosToolStripMenuItem
            // 
            this.borrarBaseDeDatosToolStripMenuItem.Name = "borrarBaseDeDatosToolStripMenuItem";
            this.borrarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.borrarBaseDeDatosToolStripMenuItem.Text = "Borrar Base de Datos";
            this.borrarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.borrarBaseDeDatosToolStripMenuItem_Click);
            // 
            // reestablecerToolStripMenuItem
            // 
            this.reestablecerToolStripMenuItem.Name = "reestablecerToolStripMenuItem";
            this.reestablecerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reestablecerToolStripMenuItem.Text = "Reestablecer";
            this.reestablecerToolStripMenuItem.Click += new System.EventHandler(this.reestablecerToolStripMenuItem_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(6, 463);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(220, 75);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Generar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(769, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 535);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(158, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1436, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modo Lector";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(587, 462);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(218, 77);
            this.button7.TabIndex = 12;
            this.button7.Text = "Apagar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(334, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 411);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(811, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 530);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(471, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(334, 462);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 76);
            this.button6.TabIndex = 13;
            this.button6.Text = "Encender";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 530);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-1, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 106);
            this.label7.TabIndex = 0;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.lec);
            this.tabPage3.Controls.Add(this.panel6);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1436, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modo Carga";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(210, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 49);
            this.button5.TabIndex = 4;
            this.button5.Text = "Detener";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(391, 33);
            this.comboBox2.TabIndex = 2;
            // 
            // lec
            // 
            this.lec.BackColor = System.Drawing.Color.Silver;
            this.lec.Location = new System.Drawing.Point(407, 3);
            this.lec.Multiline = true;
            this.lec.Name = "lec";
            this.lec.Size = new System.Drawing.Size(940, 535);
            this.lec.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button4);
            this.panel6.Location = new System.Drawing.Point(3, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(398, 266);
            this.panel6.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(392, 59);
            this.button4.TabIndex = 10;
            this.button4.Text = "Cargar Archivo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-86, -31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1528, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1252, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 699);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabModo);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem desdeSQLToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem borrarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reestablecerToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox lec;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cronogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qrSinSQLToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

