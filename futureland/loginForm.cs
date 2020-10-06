using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//using System.Web.UI;

namespace futureland
{
    public partial class loginForm : Form
    {
        System.IO.Ports.SerialPort Port;
        //bool isClosed = false;

        public loginForm()
        {
            InitializeComponent();
            //Port = new System.IO.Ports.SerialPort();
            //Port.BaudRate = 9600;
            //Port.PortName = "COM3";
            //Port.ReadTimeout = 500;
            //Port.Open();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
        //    Thread arduino = new Thread(LecturaArduino);
        //    arduino.Start();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin" && txtPassword.Text == "admin")
            {
                Views.mainForm mainForm = new Views.mainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta", "Error al iniciar sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
            
            
        }

        //private void LecturaArduino()
        //{
        //    while (!isClosed)
        //    {
        //        try
        //        {
        //            string cadena = Port.ReadLine();
        //            txtPrueba.Invoke(new MethodInvoker(delegate
        //            {
        //                txtPrueba.Text = cadena;

        //            }));
        //        }
        //        catch
        //        {

        //        }
               
        //    }
        //}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        //    if (Port.IsOpen)
        //    {
        //        Port.Close();
        //    }

        //    isClosed = true;
        }
    }
}
