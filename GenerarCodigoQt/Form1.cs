using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;
using MySql.Data.MySqlClient;
using AForge.Controls;
using BarcodeLib.BarcodeReader;
using System.Security.Principal;
// el primer paso es enlazar la dll del conector que el paquete msi, agrego al sistema, hecho esto solo es necesario agregar el espacio de nombres


namespace GenerarCodigoQt
{



    public partial class Form1 : Form
    {
        public FilterInfoCollection ColeccionDisp;

        public string cadenaConexion = "Server = localhost; Database=estudiantes; Uid=root; Pwd= ;";
        public MySqlConnection conexion;
        public string rutaGuardado = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/CodigosGenerados";

        void ConectarConMysql()
        {
            // crear cadena de conexion, se puede hacer a mano o creando un connectionbuilder
            MySqlConnection Conexion = new MySqlConnection("Server = localhost; Database=qr; Uid=root; Pwd= ;");

            // crear un comando para la base de datos
            MySqlCommand Comando = new MySqlCommand("INSERT INTO usuario( carrera ) VALUES ('victor');",Conexion);

            // abrir la conexion con la base de datos para ejecutar el comando 
            Conexion.Open();

            int a = 2, c = 43;

            if ( Convert.ToBoolean(Comando.ExecuteNonQuery() ) )
                 a = 2;
            else
                 c = 3;

           

            Conexion.Close();
        }
        



        public Form1()
        {
            InitializeComponent();
        }

        // genera codigos qr y los guarda en un directorio apartir de los datos de una tabla
        void generarQrFromSQL()
        {
            // conectarse con la base de datos 
            MySqlConnection Conexion = new MySqlConnection("Server = localhost; Database=estudiantes; Uid=root; Pwd= ;");

            // hacer una consulta a la base de datos
            MySqlCommand Comando = new MySqlCommand(" SELECT * from estudiante;", Conexion);

            // abrir la conexion con la base de datos
            Conexion.Open();

            // conseguir un lector de todos los datos que se han leido
            MySqlDataReader lector = Comando.ExecuteReader();

            // leer toda la base de datos 
            while (lector.Read())
            {
                // crear un encoder, codificador
                QrEncoder Codificador = new QrEncoder(ErrorCorrectionLevel.H);

                // crear un codigo QR
                QrCode Codigo = new QrCode();

                txtNUA.Text = lector.GetString(0);
                txtNombre.Text = lector.GetString(1);
                txtCarrera.Text = lector.GetString(2);
                txtEve.Text = lector.GetString(3);
                txtPaterno.Text = lector.GetString(4);
                txtMaterno.Text = lector.GetString(5);

                panel5.Refresh();

                // generar generar  un codigo apartir de datos, y pasar el codigo por referencia
                Codificador.TryEncode(txtNombre.Text + " " + txtNUA.Text, out Codigo);

                // generar un graficador 
                GraphicsRenderer Renderisado = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                // generar un flujo de datos 
                MemoryStream ms = new MemoryStream();

                // escribir datos en el renderizado
                Renderisado.WriteToStream(Codigo.Matrix, ImageFormat.Png, ms);

                // generar controles para ponerlos en el form
                var ImagenQR = new Bitmap(ms);
                var ImgenSalida = new Bitmap(ImagenQR, new Size(panel4.Width / 2, panel4.Height / 2));

                if (!Directory.Exists(this.rutaGuardado))
                    // crear un directorio 
                    Directory.CreateDirectory(this.rutaGuardado);

                ImgenSalida.Save(this.rutaGuardado + "/" + txtNUA.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

                // asignar la imagen al panel 
                // panel4.BackgroundImage = ImgenSalida;
                pictureBox1.Image = ImgenSalida;
                System.Threading.Thread.Sleep(1000);
                pictureBox1.Refresh();
            }
            MessageBox.Show("Lectura termiada", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // conseguir todos los dispositivos de video
            this.ColeccionDisp = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            MessageBox.Show(this.rutaGuardado);
            // desplegar dispositivos en el combo
            foreach (FilterInfo disp in ColeccionDisp)
                comboBox1.Items.Add(disp.Name);

            // agregar control
            VideoSourcePlayer ControlVideo = new VideoSourcePlayer();
            ControlVideo.BackColor = Color.Red;
            ControlVideo.Size = new Size(panel2.Width,panel2.Height);
            ControlVideo.Name = "ControlVideo";
            panel2.Controls.Add(ControlVideo);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // crear un directorio para los codigos 
            string ruta = @"C:\Users\frodo\Desktop\codigosQr";

            if ( ! Directory.Exists(ruta))
            {
                // crear un directorio 
                Directory.CreateDirectory(ruta);
            } 

            /// generar un codigo QR para los elementos de la caja 
        
            for ( int i = 1; i <= 30; i ++)
            {
                // crear un encoder, codificador
                QrEncoder Codificador = new QrEncoder(ErrorCorrectionLevel.H);

                // crear un codigo QR
                QrCode Codigo = new QrCode();

                // generar generar  un codigo apartir de datos, y pasar el codigo por referencia
                Codificador.TryEncode("Gonzalez"+i.ToString(), out Codigo);

                // generar un graficador 
                GraphicsRenderer Renderisado = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                // generar un flujo de datos 
                MemoryStream ms = new MemoryStream();

                // escribir datos en el renderizado
                Renderisado.WriteToStream(Codigo.Matrix, ImageFormat.Png, ms);

                // generar controles para ponerlos en el form
                var ImagenQR = new Bitmap(ms);
                var ImgenSalida = new Bitmap(ImagenQR, new Size(panel1.Width, panel1.Height));

                // guardar la imagen
                ImgenSalida.Save(ruta + "/" + i.ToString() +".png", System.Drawing.Imaging.ImageFormat.Png);

                // asignar la imagen al panel 
                panel1.BackgroundImage = ImgenSalida;

                panel1.Refresh();
                System.Threading.Thread.Sleep(500);
            }
            
            


                 
        }

        // insertar en la base de datos
        private void button2_Click(object sender, EventArgs e)
        {
            Random Generador = new Random();
            // generar 6 numeros aleatorios 
            string NumeroId = "";

            for (int i = 0; i < 6; i++)
                NumeroId += Generador.Next(0, 10).ToString();

            MySqlConnection Con = new MySqlConnection("Server=localhost; Database=codigoqr; Uid=root; Pwd=;");

            MySqlCommand Com = new MySqlCommand("INSERT INTO Usuarios (IdUsuario, nombre, carrera, asistencia) VALUES (" + " ' "+  Convert.ToUInt32( NumeroId) + " ' " + "," + " ' " + txtCarrera.Text + " ' "+ "," +" ' "+ txtMaterno.Text + " ' "+","+ 0 +");", Con);
            MySqlCommand Com2 = new MySqlCommand("SELECT * FROM usuarios", Con);

            Con.Open();


            if ( Convert.ToBoolean( Com.ExecuteNonQuery()))
            {
                MessageBox.Show("Insertado");
        
            }
            Con.Close();


            Con.Open();
            // generar un lector 
            MySqlDataReader Lector = Com2.ExecuteReader();

            //leer toda la consulta 
            while (Lector.Read())
                MessageBox.Show(Lector.GetString(0) + Lector.GetString(1) + Lector.GetString(2));


            Con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            // conseguir todos los dispositivos de video
            this.ColeccionDisp = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // desplegar dispositivos en el combo
            foreach (FilterInfo disp in ColeccionDisp)
                comboBox1.Items.Add(disp.Name);

            comboBox1.SelectedIndex = 0;

            // conseguir el control de video del form
            VideoSourcePlayer Reproductor = (VideoSourcePlayer)this.panel2.Controls["ControlVideo"];

           Reproductor.VideoSource = new VideoCaptureDevice(this.ColeccionDisp[comboBox1.SelectedIndex].MonikerString);
            Reproductor.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            VideoSourcePlayer Reproductor = (VideoSourcePlayer)this.panel2.Controls["ControlVideo"];
            Reproductor.SignalToStop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            VideoSourcePlayer Reproductor = (VideoSourcePlayer)this.panel2.Controls["ControlVideo"];

            // verificar que se leea algo
            if (Reproductor.GetCurrentVideoFrame() != null)
            {
                // conseguir la imagen de la  web cam
                Bitmap imagen = new Bitmap(Reproductor.GetCurrentVideoFrame());

                // conseguir el resultado de la lectura 
                string[] codigo = BarcodeReader.read(imagen, BarcodeReader.QRCODE);


                // limpiar la memoria
                imagen.Dispose();

                // agregar cuando se lea algo
                if (codigo != null /*&& codigo.Count() > 0*/)
                {
                    char separador = ' ';
                    string[] matriz = codigo[0].Split(separador);

                    listBox2.Items.Add(codigo[0]);

                    // verificar si existe coincidencia en la base de datos para "codigo"

                    /* crear una nueva conexion */
                    this.conexion = new MySqlConnection(this.cadenaConexion);
                    this.conexion.Open();

                    /* crear un comando */
                    string nua = matriz[1];
                    string nombre = matriz[0];
                    string comandoInterno = "SELECT * FROM estudiante WHERE nua =" + Convert.ToInt32(nua) + ";";

                    try
                    {

                        MySqlCommand Comando = new MySqlCommand(comandoInterno, this.conexion);

                    // conseguir un lector
                    MySqlDataReader lectort = Comando.ExecuteReader();
                    

                    if (lectort.Read())
                    {
                            this.panel1.BackColor = Color.Green;
                            this.panel1.Refresh();

                            if ( !lectort.GetBoolean(6))
                            {
                               
                                this.conexion = new MySqlConnection(this.cadenaConexion);
                                // actulizar la asistencia de los registrados 
                                string comandoActu = @"UPDATE estudiante SET  nombre ='" + lectort.GetString(1) +
                                     "', evento = '" + lectort.GetString(2) + "', carrera ='" + lectort.GetString(3) + "', apeidoPaterno = '" + lectort.GetString(4) +
                                     "', apeidoMaterno = ' " + lectort.GetString(5) + "', asistencia =" + !lectort.GetBoolean(6) + " WHERE nua =" + lectort.GetInt32(0) + ";";

                                this.conexion.Close();

                                // crear un nuevo commando 
                                MySqlCommand comandoUpdate = new MySqlCommand(comandoActu, this.conexion);
                                this.conexion.Open();

                                // ejecutar el nuevo comando
                                comandoUpdate.ExecuteNonQuery();
                                this.conexion.Close();

                                System.Threading.Thread.Sleep(500);
                                // MessageBox.Show("Asistencia Confirmada");
                                timer1.Stop();
                                System.Threading.Thread.Sleep(500);
                                timer1.Start();
                                return;
                            }                         
                    }
                    else
                    {
                        this.panel1.BackColor = Color.Red;


                    }

                    

                }
                catch (Exception ex)
                {
                    panel1.BackColor = Color.Yellow;
                    panel1.Refresh();
                    System.Threading.Thread.Sleep(500);

                }

                }
                else
                    panel1.BackColor = Color.Black;
            }
            

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.generarQrFromSQL();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        // botonApagar
        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            VideoSourcePlayer Reproductor = (VideoSourcePlayer)this.panel2.Controls["ControlVideo"];
            Reproductor.SignalToStop();
        }

        // encender la camara web
        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            comboBox1.SelectedIndex = 0;

            // conseguir el control de video del form
            VideoSourcePlayer Reproductor = (VideoSourcePlayer)this.panel2.Controls["ControlVideo"];

            Reproductor.VideoSource = new VideoCaptureDevice(this.ColeccionDisp[comboBox1.SelectedIndex].MonikerString);
            Reproductor.Start();

            // verificar que se leea algo
            if (Reproductor.GetCurrentVideoFrame() != null)
            {
                // conseguir la imagen de la  web cam
                Bitmap imagen = new Bitmap(Reproductor.GetCurrentVideoFrame());

                // conseguir el resultado de la lectura 
                string[] codigo = BarcodeReader.read(imagen, BarcodeReader.QRCODE);
                MessageBox.Show(codigo.ToString());

                // limpiar la memoria
                imagen.Dispose();

                // agregar cuando se lea algo
                if (codigo != null /*&& codigo.Count() > 0*/)
                {
                    MessageBox.Show(codigo.Length.ToString());
                    listBox2.Items.Add(codigo[0]);

                    // verificar si existe coincidencia en la base de datos para "codigo"

                    /* crear una nueva conexion */
                    this.conexion = new MySqlConnection(this.cadenaConexion);
                    this.conexion.Open();

                    /* crear un comando */
                    string nua;
                    string nombre;
                    string comandoInterno = "SELECT * FROM estudiante WHERE NUA =";
                    MySqlCommand Comando = new MySqlCommand( comandoInterno,this.conexion);

                    // conseguir un lector
                    MySqlDataReader lectort = Comando.ExecuteReader();

                    if (lectort.Read())
                    {

                        this.panel2.BackColor = Color.Green;

                        
                    }
                    else
                        this.panel2.BackColor = Color.Red;

                }
                else
                    panel3.BackColor = Color.Black;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        // boton de ver el qr
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (txtCarrera.Text != "" && txtEve.Text != "" && txtMaterno.Text != "" && txtPaterno.Text != "" && txtNombre.Text != "" && txtNUA.Text != "")
            {
                // crear un encoder, codificador
                QrEncoder Codificador = new QrEncoder(ErrorCorrectionLevel.H);

                // crear un codigo QR
                QrCode Codigo = new QrCode();

                // generar generar  un codigo apartir de datos, y pasar el codigo por referencia
                Codificador.TryEncode(txtNombre.Text + " " + txtNUA.Text, out Codigo);

                // generar un graficador 
                GraphicsRenderer Renderisado = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                // generar un flujo de datos 
                MemoryStream ms = new MemoryStream();

                // escribir datos en el renderizado
                Renderisado.WriteToStream(Codigo.Matrix, ImageFormat.Png, ms);

                // generar controles para ponerlos en el form
                var ImagenQR = new Bitmap(ms);
                var ImgenSalida = new Bitmap(ImagenQR, new Size(panel4.Width / 2, panel4.Height / 2));

                // asignar la imagen al panel 
                // panel4.BackgroundImage = ImgenSalida;
                pictureBox1.Image = ImgenSalida;
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos del formulario");
            }
                
            
              
        }

        // guardar datos
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (txtCarrera.Text != "" && txtEve.Text != "" && txtMaterno.Text != "" && txtPaterno.Text != "" && txtNombre.Text != "" && txtNUA.Text != "")
            {

                if (!Directory.Exists(this.rutaGuardado))
                    // crear un directorio 
                    Directory.CreateDirectory(this.rutaGuardado);

                // conseguir una nueva conexion y abrirla 
                this.conexion = new MySqlConnection(this.cadenaConexion);
                this.conexion.Open();

                // crear un nuevo comando 
                string comandoTexto =
                    @"INSERT INTO estudiante (nua, nombre,  evento, carrera, apeidoPaterno, apeidoMaterno, asistencia ) 
                    VALUES(" + this.txtNUA.Text + ",'" + txtNombre.Text + "','" + txtEve.Text + "','" + txtCarrera.Text + "','" + txtPaterno.Text + "','" + txtMaterno.Text + "'," + false + ");";
                MySqlCommand comando = new MySqlCommand(comandoTexto, this.conexion);

                var ImgenSalida = this.pictureBox1.Image;



                // guardar la imagen
                ImgenSalida.Save(this.rutaGuardado + "/" + txtNUA.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

                // ejecutar el comando de insercion
                if (Convert.ToBoolean(comando.ExecuteNonQuery()))
                    MessageBox.Show("Registro Insertado Correctamente");
                else
                    MessageBox.Show("No Se Pudo Insertar El Registro");
            }
            else
                MessageBox.Show("Debe llenar todos los campos del formulario");
        }

        //ruta imagenes
        private void rutaImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            f1.ShowDialog();

                this.rutaGuardado = f1.SelectedPath;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.pictureBox1.Image = null;
            foreach (Control c in this.panel5.Controls)
                if (c is TextBox)
                    c.Text = "";
        }

        private void desdeSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult re =  MessageBox.Show("Desea generar codigos Qr desde la base de datos?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           if( re == DialogResult.Yes ) generarQrFromSQL();
           else
                MessageBox.Show("Se ha omitido la generacion automatica de Codigo Qr", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
