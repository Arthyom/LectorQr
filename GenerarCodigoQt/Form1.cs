using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;
using MySql.Data.MySqlClient;
using AForge.Controls;
using BarcodeLib.BarcodeReader;
using System.Security.Principal;
using System.Collections;

// el primer paso es enlazar la dll del conector que el paquete msi, agrego al sistema, hecho esto solo es necesario agregar el espacio de nombres


namespace GenerarCodigoQt
{



    public partial class Form1 : Form
    {
        public FilterInfoCollection ColeccionDisp;

        public string cadenaConexion = "Server = localhost; Database=estudiantes; Uid=root; Pwd= ;";
        public MySqlConnection conexion;
        public string rutaGuardado = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ingles/CodigosGenerados/";
        public string rutaSql  = "../../../scripBaseDatos.sql";
        public string menAceptado = "ACEPTADO", menRechazado = "RECHAZADO", menVacio = "VACIO";

        public string rutaCrono = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ingles/cronograma.txt" ;
        public string rutaAsist = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ingles/asistentes.txt";
        public string rutaGenl = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ingles/";
        public StreamWriter escritorActual;
        public string[,] ListadoNombres;
        public Evento eventoAcual;

        void LeerDeTxt()
        {
            int i = 0;
            //Lee cada linea del archivo y la asigna en un arreglo.
            //Cada elemento del arreglo es una linea del archivo!
            string[] lines = System.IO.File.ReadAllLines(this.rutaAsist);

            //se reestructuran dimensiones para matriz donde será alojado el nombre y nua del alumno
            ListadoNombres = new string[lines.Length, 2];

            //Mostramos en consola el contenido del archivo.
            System.Console.WriteLine("Contenido de text.txt = ");
            foreach (string line in lines)
            {
                //se divide en nua y nombre la línea leída previamente 
                string[] values = line.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
                //se guardan los valores por separado en la matriz
                ListadoNombres[i, 0] = values[0];
                ListadoNombres[i, 1] = values[1] + " " + values[2] + " " + values[3];
                //Para ver en consola de visual studio los datos almacenados
                Console.WriteLine("\t" + ListadoNombres[i, 0]);
                Console.WriteLine("\t" + ListadoNombres[i, 1]);
                i++;
            }
            System.Console.Read();


        }
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
            //LeerDeTxt();
            //           //prueba mostrar nombre y nua
            //MessageBox.Show(" nua ", ListadoNombres[1, 0] + " nombre " + ListadoNombres[1, 1]);
           
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

        // leer matriz de nombres y generar su Qr
        void generarQrFromTxt()
        {
            // crear una conexion
            this.conexion = new MySqlConnection(this.cadenaConexion);
            this.conexion.Open();

            for ( int i = 0; i < 120; i ++ )
            {
                for ( int j = 0; j < 1; j ++ )
                {
                    // crear un encoder, codificador
                    QrEncoder Codificador = new QrEncoder(ErrorCorrectionLevel.H);

                    // crear un codigo QR
                    QrCode Codigo = new QrCode();

                    string nua = ListadoNombres[i, j];
                    string nombre = ListadoNombres[i, j + 1];

                    string com = " INSERT INTO registro ( nombre, nua ) VALUES ('" + nombre + "'," + nua + " )";

                    MySqlCommand comando = new MySqlCommand(com, this.conexion);
                    comando.ExecuteNonQuery();
                 


                    // generar generar  un codigo apartir de datos, y pasar el codigo por referencia
                    Codificador.TryEncode(nombre + " " + nua, out Codigo);

                    // generar un graficador 
                    GraphicsRenderer Renderisado = new GraphicsRenderer(new FixedCodeSize(200, QuietZoneModules.Zero), Brushes.Black, Brushes.White);

                    // generar un flujo de datos 
                    MemoryStream ms = new MemoryStream();

                    // escribir datos en el renderizado
                    Renderisado.WriteToStream(Codigo.Matrix, ImageFormat.Png, ms);

                    // generar controles para ponerlos en el form
                    var ImagenQR = new Bitmap(ms);
                    var ImgenSalida = new Bitmap(ImagenQR, new Size( 114 , 114 ));

                    if (!Directory.Exists(this.rutaGuardado))
                        // crear un directorio 
                        Directory.CreateDirectory(this.rutaGuardado);

                    ImgenSalida.Save(this.rutaGuardado + "/" + nombre+nua + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            this.conexion.Close();
            MessageBox.Show("Lectura termiada", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add( "NUA" , this.listView1.Width/5 );
            listView1.Columns.Add( "Nombre", this.listView1.Width / 5);

            listView1.Columns.Add( "A. Paternod", this.listView1.Width / 3);
            listView1.Columns.Add(" A. Materno", this.listView1.Width / 3);
            listView1.Columns.Add(" Carrera ", this.listView1.Width / 5);

            listView1.View = View.Details;


            // conseguir todos los dispositivos de video
            this.ColeccionDisp = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //MessageBox.Show(this.rutaGuardado);
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
                if (codigo != null)
                {
                    char separador = ' ';
                    string[] matriz = codigo[0].Split(separador);

                    if (matriz.Count() >= 2)
                    {
                        // verificar si existe coincidencia en la base de datos para "codigo"

                        /* crear una nueva conexion */
                        this.conexion = new MySqlConnection(this.cadenaConexion);
                        this.conexion.Open();

                        /* crear un comando */
                        string nua = matriz[matriz.Length-1];
                        string nombre = matriz[2];
                        string comandoInterno = "SELECT * FROM registro WHERE nua =" + Convert.ToInt32(nua) + ";";

                        try
                        {

                            MySqlCommand Comando = new MySqlCommand(comandoInterno, this.conexion);

                            // conseguir un lector
                            MySqlDataReader lectort = Comando.ExecuteReader();


                            if ( lectort.Read() )
                            {
                                this.panel1.BackColor = Color.Green;
                                this.panel1.Refresh();
                                this.label7.Text = this.menAceptado;
                                this.label7.Refresh();


                                if ( true )
                                {
                                    /*
                                    string evens = ",nombreEvento1 = '" + lectort.GetString(2) + "', asistenciaEvento1 = '"+ lectort.GetString(3);

                                    for (int i = 3; i < this.eventoAcual.numeroActividades - 2; i++)
                                        evens += ",nombreEvento" + (i-1).ToString() +  " = '" + lectort.GetString(i+1) + " ', asistenciaEvento" + (i-1).ToString() + " =' " + lectort.GetString(i+2) + "'" ;

                                    this.conexion = new MySqlConnection(this.cadenaConexion);
                                    // actulizar la asistencia de los registrados 
                                    string comandoActu = @"UPDATE registro SET  nombre ='" + lectort.GetString(0) + evens +" WHERE nua =" + lectort.GetInt32(1) + ";";
                                    */

                                    // escribier en el escritor actual 
                                    // MessageBox.Show(" ", nombre + nua);
                                    //MessageBox.Show(this.rutaGenl);
                                    this.escritorActual.WriteLine (nombre + " | " + nua);


                                    ListViewItem itNua = new ListViewItem(lectort.GetString(1));
                                    ListViewItem.ListViewSubItem itNom = new ListViewItem.ListViewSubItem(itNua, lectort.GetString(0));

                                    //System.Threading.Thread.Sleep(1000);


                                    itNua.SubItems.Add(itNom);
                                    listView1.Items.Add(itNua);

                                    this.conexion.Close();

                                    // crear un nuevo commando 
                                    //MySqlCommand comandoUpdate = new MySqlCommand(comandoActu, this.conexion);
                                    //this.conexion.Open();


                                    // ejecutar el nuevo comando
                                    //comandoUpdate.ExecuteNonQuery();
                                    //this.conexion.Close();

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
                                this.label7.Text = this.menRechazado;
                                this.label7.Refresh();

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
                    {
                        this.panel1.BackColor = Color.Red;
                        this.label7.Text = this.menRechazado;
                        this.label7.Refresh();
                    }
                    this.conexion.Close();


                }
                else {
                    panel1.BackColor = Color.Black;
                    this.label7.Text = this.menVacio;
                }

            }
            

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.generarQrFromSQL();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        bool verificarAsis( string nua )
        {
            StreamReader lector = new StreamReader(this.rutaGenl + (string) this.comboBox2.SelectedItem + ".txt");
            string[] matriz;
            char separador = '|';

            while( !lector.EndOfStream )
            {
                matriz = lector.ReadLine().Split(separador);
                if (nua.CompareTo(matriz[1]) == 0)
                    return false;
            }

            return true;
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
                    //listBox2.Items.Add(codigo[0]);

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

                //Graphics e = 


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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void borrarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Realmente desea borrar toda la base de datos?", " ",MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (res == DialogResult.Yes)
            {
                // crear una nueva conexion al servidor 
                this.conexion = new MySqlConnection(this.cadenaConexion);
                this.conexion.Open();

                // crear un comando 
                string comando = "DELETE FROM estudiante; DELETE FROM registro; ";
                MySqlCommand comandoBorrar = new MySqlCommand(comando, this.conexion);
                

                // ejecutar el comando
                comandoBorrar.ExecuteNonQuery();
                MessageBox.Show("la base de datos ha sido borrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.conexion.Close();

            }
            else
                MessageBox.Show("Se ha cancelado el borrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reestablecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Realmente desea reestablecer la base de datos?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                // crear una nueva conexion al servidor 
                this.conexion = new MySqlConnection(this.cadenaConexion);
                this.conexion.Open();

                // conseguir el comando de creacion
                StreamReader lector = new StreamReader(this.rutaSql);

                //leer linea por linea y almacenar la lectura 
                string comando = " ";

                while ( !lector.EndOfStream )
                    comando += lector.ReadLine();

                MessageBox.Show(comando);
                     
                // crear un comando 
                MySqlCommand comandoBorrar = new MySqlCommand(comando, this.conexion);
                

                // ejecutar el comando
                comandoBorrar.ExecuteNonQuery();
                MessageBox.Show("la base de datos ha sido Reestablecida", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.conexion.Close();

            }
            else
                MessageBox.Show("Se ha cancelado la restauracion", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.CargarFormato(@"C:\Users\frodo\Desktop\crono.txt");
        }

        // leer el archivo de texto de configuracion 
        private void CargarFormato ( string ruta )
        {
            StreamReader lector = new StreamReader(ruta);

            // crear un nuevo evento 
            Evento ev = new Evento();

            // leer propiedades del evento
            ev.nombre = lector.ReadLine();
            ev.numeroActividades = Convert.ToInt32(lector.ReadLine());

            // definir un vector de n eventos
            ev.actividadesEvento = new Actividad[ev.numeroActividades];

            // crear la tabla principal para controlar los registros
            this.CrearTablaRegistro();

            string linea;
            string[] matrizNombre;
            string[] matrizFechas;
            char separador1 = '|';
            char separador2 = '-';

            // iterar hasta que se acabe el archivo
            int i = 0;
            while(!lector.EndOfStream)
            {
                linea = lector.ReadLine();
                matrizNombre = linea.Split(separador1);
                matrizFechas = matrizNombre[0].Split(separador2);

                Actividad acn = new Actividad();
                acn.nombre = matrizNombre[1];
                acn.horaInicio = matrizFechas[0];
                acn.horaTermino = matrizFechas[1];
                acn.estado = 0;

                ev.actividadesEvento[i] = acn;

                i++;
               
            }

            this.eventoAcual = ev;

        }

        private void cronogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            f1.ShowDialog();

            this.rutaCrono = f1.SelectedPath;
        }

        private void asistentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f1 = new FolderBrowserDialog();
            f1.ShowDialog();

            this.rutaAsist= f1.SelectedPath;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.CargarFormato(this.rutaCrono);

            // poner en la caja de texto 
            StreamReader lector = new StreamReader(this.rutaCrono);

            while( !lector.EndOfStream )
                this.lec.Text += (lector.ReadLine() + " \n ");

            lec.Refresh();

            foreach (Actividad ac in this.eventoAcual.actividadesEvento)
                this.comboBox2.Items.Add(ac.nombre);

        }

        private void qrSinSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Desea generar codigos Qr desde archivo de registro", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (re == DialogResult.Yes)
            {
                LeerDeTxt();
                generarQrFromTxt();
            }
            else
                MessageBox.Show("Se ha omitido la generacion automatica de Codigo Qr", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // iniciar registro de eventos en un nuevo archivo de texto
        private void button3_Click_2(object sender, EventArgs e)
        {
            this.escritorActual = new StreamWriter( this.rutaGenl + (string) this.comboBox2.SelectedItem+".txt", true);
            MessageBox.Show("Puede Comenzar A Leer Los Qr", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // sacar al primer escritor de la cola
        private void button5_Click_2(object sender, EventArgs e)
        {
            this.escritorActual.Close();
            MessageBox.Show("El Evento Ha Sido Finalizado", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // crear tablas para los horarios de las actividades
        private void CrearTablaHorarios (  )
        {
            // crear comando de creacion
            string ComandoCreacion = @"CREATE TABLE horarios" +
                @"(
                    nombreActidad varchar (20), 
                    horaInicio    varchar (10),
                    horaTermino   varchar (10),
                    estado        integer 
                  );" ;


            // abrir una conexion 
            this.conexion = new MySqlConnection(this.cadenaConexion);
            this.conexion.Open();

            // crear un comando 
            MySqlCommand cm = new MySqlCommand(ComandoCreacion, this.conexion);

            // ejecutar comando de creacion
            cm.ExecuteNonQuery();

            // cerrar la conexion 
            this.conexion.Close();

        }

        // crear tablas para el control de registros aceptados 
        private void CrearTablaRegistro(  )
        {
            // crear comando de creacion
            string ComandoCreacion = @" CREATE TABLE IF NOT EXISTS registro 
                 (
                    nombre        varchar (70), 
                    nua           integer  
                 );";


            // abrir una conexion 
            this.conexion = new MySqlConnection(this.cadenaConexion);
            this.conexion.Open();

            // crear un comando 
            MySqlCommand cm = new MySqlCommand(ComandoCreacion, this.conexion);

            // ejecutar comando de creacion
            cm.ExecuteNonQuery();

            // cerrar la conexion 
            this.conexion.Close();

        }


    }
}
