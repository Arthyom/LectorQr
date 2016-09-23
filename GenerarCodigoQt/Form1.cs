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
// el primer paso es enlazar la dll del conector que el paquete msi, agrego al sistema, hecho esto solo es necesario agregar el espacio de nombres


namespace GenerarCodigoQt
{



    public partial class Form1 : Form
    {
        FilterInfoCollection ColeccionDisp;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Generar";
            button2.Text = "Insertar";
            button3.Text = "Detener";
            button4.Text = "Iniciar";

            // agregar control
            VideoSourcePlayer ControlVideo = new VideoSourcePlayer();
            ControlVideo.BackColor = Color.Red;
            ControlVideo.Size = new Size(panel2.Width,panel2.Height);
            ControlVideo.Name = "ControlVideo";
            panel2.Controls.Add(ControlVideo);

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /// generar un codigo QR para los elementos de la caja 

            // crear un encoder, codificador
            QrEncoder Codificador = new QrEncoder( ErrorCorrectionLevel.H );

            // crear un codigo QR
            QrCode Codigo = new QrCode();

            // generar generar  un codigo apartir de datos, y pasar el codigo por referencia
            Codificador.TryEncode(textBox1.Text, out Codigo);

            // generar un graficador 
            GraphicsRenderer Renderisado = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

            // generar un flujo de datos 
            MemoryStream ms = new MemoryStream();

            // escribir datos en el renderizado
            Renderisado.WriteToStream(Codigo.Matrix, ImageFormat.Png, ms);

            // generar controles para ponerlos en el form
            var ImagenQR = new Bitmap(ms);
            var ImgenSalida = new Bitmap(ImagenQR, new Size(panel1.Width, panel1.Height));

            // asignar la imagen al panel 
            panel1.BackgroundImage = ImgenSalida;
            


                 
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

            MySqlCommand Com = new MySqlCommand("INSERT INTO Usuarios (IdUsuario, nombre, carrera, asistencia) VALUES (" + " ' "+  Convert.ToUInt32( NumeroId) + " ' " + "," + " ' " + textBox1.Text + " ' "+ "," +" ' "+ textBox2.Text + " ' "+","+ 0 +");", Con);
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
                    listBox1.Items.Add(codigo[0]);

                    // verificar si existe coincidencia en la base de datos para "codigo"

                    /* crear una nueva conexion */
                   // MySqlConnection Conexion = new MySqlConnection("server=loclahost; database=codigoqr; uid=root ; pwd=;");

                    /* crear un comando */
                    //MySqlCommand Comando = new MySqlCommand("SELECT * FROM Usuarios WHERE Idusuario = " + " ' " + codigo + " ';", Conexion);

                    /* abrir la conexion y ejecutar el comando */
                    //MySqlDataReader Lector = Comando.ExecuteReader();

                   /* if (Lector != null)
                        panel3.BackColor = Color.Green;
                    else
                        panel3.BackColor = Color.Red;*/
                }
                else
                    panel3.BackColor = Color.Black;

                   
            }
        }
    }
}
