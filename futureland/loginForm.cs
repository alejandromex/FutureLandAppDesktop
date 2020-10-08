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

        public loginForm()
        {
            InitializeComponent();
           //this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
           //this.WindowState = FormWindowState.Maximized;


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ajusteInicial();
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

       

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void loginForm_MaximumSizeChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width > 978)
            {
                txtUsuario.Width = 500;
                txtPassword.Width = 500;

                lblPassword.Width = 500;
                lblUsuario.Width = 500;

                lblUsuario.Location = new Point((this.Width / 2) - 250, 260);
                txtUsuario.Location = new Point((this.Width / 2)-250, 290);


                lblPassword.Location = new Point((this.Width/2)-250,320);
                txtPassword.Location = new Point((this.Width / 2)-250,350);

                btnIniciar.Location = new Point((this.Width / 2) - btnIniciar.Width / 2, 410);
            }
            else
            {
                ajusteInicial();
            }
        }

        private void ajusteInicial()
        {
            txtUsuario.Width = 204;
            txtPassword.Width = 204;

            lblPassword.Width = 500;
            lblUsuario.Width = 500;

            lblUsuario.Location = new Point((this.Width / 2) - lblUsuario.Width / 2, 260);
            txtUsuario.Location = new Point((this.Width / 2) - txtUsuario.Width / 2, 290);


            lblPassword.Location = new Point((this.Width / 2) - lblPassword.Width / 2, 320);
            txtPassword.Location = new Point((this.Width / 2) - txtPassword.Width / 2, 350);

            btnIniciar.Location = new Point((this.Width / 2) - btnIniciar.Width / 2, 410);
        }



        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if(txtPassword.Text == "admin" && txtUsuario.Text == "admin")
            {
                this.Hide();

                Views.mainForm main = new Views.mainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Error, Revise usuario y/o Contrasena");
            }
        }
    }
}
