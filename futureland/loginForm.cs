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


        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
