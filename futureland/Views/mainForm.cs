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
using System.Data;
using futureland.Helpers;
using System.IO.Ports;
using System.Threading;

namespace futureland.Views
{
    public partial class mainForm : Form
    {
        public int xClick = 0, yClick = 0;
        configuracionForm configuracionForm = new configuracionForm();
        Controllers.registrosController registrosController = new Controllers.registrosController();
        private DataTable dt = new DataTable();
        SerialPort Port;
        public bool isClosed = true;


        public mainForm()
        {
            InitializeComponent();
            

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
                if (Port.IsOpen)
                {
                    Port.Close();
                }

                isClosed = false;
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
            configuracionForm.Show();




        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            Thread arduino;
            arduino = new Thread(lecturaArduino);
            arduino.Start();

        }

        private void lecturaArduino()
        {
            //Iniciamos lectura de arduino
            if (globales.globalCom == null)
            {
                MessageBox.Show("Seleccione el puerto COM para la lectura de humedad");
            }
            else
            {
                Port = new SerialPort();
                Port.BaudRate = 9600;
                //            Port.PortName = "COM3";
                Port.ReadTimeout = 500;
                Port.PortName = globales.globalCom;

                Port.Open();
                while (isClosed)
                {
                    try
                    {
                        string cadena = Port.ReadLine();
                        medidorHumedad.Invoke(new MethodInvoker(delegate
                        {
                            if (cadena.Contains("holamundo"))
                            {
                                cadena = cadena.Replace("holamundo", "");
                                cadena = cadena.Trim();
                                medidorHumedad.Value = int.Parse(cadena);
                                medidorHumedad.Text = "Humedad: " + cadena;
                                lblEstado.Text = "Estado: Prendido";
                                string status = registrosController.ctrRegistrarHumedad(int.Parse(cadena));
                                if (status == "error")
                                {
                                    MessageBox.Show("Error al registrar humedad");
                                }
                            }
                        }));
                    }
                    catch
                    {
                    }
                }
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
