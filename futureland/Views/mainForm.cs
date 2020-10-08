using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using futureland.Helpers;
using System.IO.Ports;
using System.Threading;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using CircularProgressBar;
using futureland.Properties;

namespace futureland.Views
{
    public partial class mainForm : Form
    {
        public int xClick = 0, yClick = 0;
        private int y = 5;
        configuracionForm configuracionForm = new configuracionForm();
        Controllers.registrosController registrosController = new Controllers.registrosController();
        List<string> parselas = new List<string>();
        List<ProgressBar> parselasBarra = new List<ProgressBar>();
        List<Label> parselasLabel = new List<Label>();
        private DataTable dt = new DataTable();
        List<int> notificaciones = new List<int>();

        Random random = new Random();

        SerialPort Port;
        private bool btnInterval = true;
        public bool isClosed = true;


        public mainForm()
        {
            InitializeComponent();
            Port = new SerialPort();
            configuracionForm.ShowDialog();


            parselas = globales.globalesParselasret();

            for (int i = 0; i < parselas.Count; i++)
            {

                


                Label lbl = new Label();
                lbl.Width = 300;
                lbl.Height = 20;
                lbl.Location = new Point(210, y);
                lbl.Name = "lblParsela" + (i + 1).ToString();
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Arial", 12, FontStyle.Bold);
                parselasLabel.Add(lbl);


                ProgressBar progressBar = new ProgressBar();
                progressBar.Width = 200;
                progressBar.Height = 20;
                progressBar.Location = new Point(5, y);
                progressBar.Name = "pbParsela" + (i + 1).ToString();
                progressBar.Click += new EventHandler(button1_Click);
                parselasBarra.Add(progressBar);

                y += 30;
               // panelParcelas.Controls.Add(progressBar);
                panelParcelas.Controls.Add(lbl);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void medidorHumedad_Click(object sender, EventArgs e)
        {
            medidorHumedad.Value = 90;
            medidorHumedad.Maximum = 100;
            medidorHumedad.Minimum = 0;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }


        private void btnRegistros_Click(object sender, EventArgs e)
        {
            if(globales.globalDatabase == null)
            {
                MessageBox.Show("Configure Base de datos y Puerto COM antes de iniciar");
                return;
            }
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "registroForm")
                {
                    return;
                }

            }
            registroForm registroForm = new registroForm();
            registroForm.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (Port.IsOpen)
                    {
                        Port.Close();
                    }
                    isClosed = false;

                }
                catch
                {

                }



                Application.Exit();
            }
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MoverFormulario(sender, e);
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

            FormCollection fc = Application.OpenForms;
            foreach(Form frm in fc)
            {
                if(frm.Name == "configuracionForm")
                {
                    return;
                }

            }
            configuracionForm configuracionForm = new configuracionForm();
            configuracionForm.Show();




        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (globales.globalCom == null || globales.globalDatabase == null || globales.globalCom == "" || globales.globalDatabase == "")
            {
                MessageBox.Show("Seleccione puerto COM y base de datos antes de iniciar");
            }
            else
            {
                
                if (btnInterval)
                {
                   if(notificaciones.Count == 0)
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Desea programar notificaciones de riego?", "Noticiaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Views.programarSmsForm programarSmsForm = new programarSmsForm();
                            programarSmsForm.ShowDialog();
                        }
                        else
                        {
                            //Rellenamos las notificaciones manualmente
                            globales.eliminarNotificaciones();
                            for(int i =0; i < parselas.Count; i++)
                            {
                                globales.agregarNotificacion(101);
                            }
                        }
                    }
                    notificaciones = globales.notificaciones();

                    for (int i = 0; i < notificaciones.Count; i++)
                    {
                        MessageBox.Show("parsela: " + parselas[i] + " Notifica a humedad: " + notificaciones[i]);
                    }

                    Thread arduino;
                    arduino = new Thread(lecturaArduino);
                    arduino.Start();
                    btnEncender.Text = "Apagar";
                    btnInterval = false;
                    isClosed = true;
                    Port.BaudRate = 9600;
                    //            Port.PortName = "COM3";
                    Port.ReadTimeout = 500;
                    Port.PortName = globales.globalCom;
                    Port.Open();
                }
                else
                {
                    isClosed = false;
                    btnEncender.Text = "Encender";
                    btnInterval = true;
                    Port.Close();
                }

            }

        }

        private void lecturaArduino()
        {
            //Iniciamos lectura de arduino
            if (globales.globalCom == null && globales.globalDatabase == null) 
            {
                MessageBox.Show("Seleccione el puerto COM para la lectura de humedad");
            }
            else
            {

                while (isClosed)
                {
                    try
                    {
                        string cadena = Port.ReadLine();
                        string status;
                        medidorHumedad.Invoke(new MethodInvoker(delegate
                        {
                            if (cadena.Contains("holamundo"))
                            {
                                cadena = cadena.Replace("holamundo", "");
                                cadena = cadena.Trim();
                                try
                                {
                                    medidorHumedad.Value = int.Parse(cadena);
                                }
                                catch
                                {

                                }
                                medidorHumedad.Text = "Humedad: " + cadena;
                                try
                                {
                                     status = registrosController.ctrRegistrarHumedad(int.Parse(cadena));
                                }
                                catch
                                {
                                     status = "error";
                                }
                                if (status == "error")
                                {
                                    MessageBox.Show("Error al registrar humedad");
                                }
                            }
                            panelParcelas.Controls.Clear();
                            
                            for(int i = 0; i < parselasBarra.Count; i++)
                            {
                                int number = random.Next(0, 101);
                                parselasLabel[i].Text = parselas[i].ToString()+" - Humedad: "+ number.ToString();
                                parselasBarra[i].Value = number;
                                panelParcelas.Controls.Add(parselasBarra[i]);
                                panelParcelas.Controls.Add(parselasLabel[i]);
                            }
                        }));
                    }
                    catch
                    {
                    }
                }
            }
        }


        private void sendSms(string messageBody)
        {
            const string accountSid = "AC2a00c776f893c3f74d8032fac9d980de";
            const string authToken = "ade81e10d66b1102ed0c8b0246446e23";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: messageBody,
                from: new Twilio.Types.PhoneNumber("+14422155717"),
                to: new Twilio.Types.PhoneNumber("+526863412040")
            );

        }


        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            if(notificaciones.Count == 0)
            {
                MessageBox.Show("Aun no tienes notificaciones programadas");
                return;
            }
            else
            {
                Views.programarSmsForm programarSmsForm = new programarSmsForm();
                programarSmsForm.ShowDialog();
            }
        }

        

        private void MoverFormulario(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }
    }
}
