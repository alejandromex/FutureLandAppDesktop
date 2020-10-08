using futureland.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futureland.Views
{
    public partial class programarSmsForm : Form
    {
        private List<string> parselas = new List<string>();
        private List<TextBox> textBoxes = new List<TextBox>();
        private List<int> notificaciones = new List<int>();
        int y = 5;
        public programarSmsForm()
        {
            InitializeComponent();
            parselas = globales.globalesParselasret();
            notificaciones = globales.notificaciones();
            for (int i = 0; i < parselas.Count; i++)
            {

                Label lbl = new Label();
                lbl.AutoSize = false;
                lbl.Width = 200;
                lbl.Height = 20;
                lbl.Text = parselas[i].ToString();
                lbl.Location = new Point(5, y);
                lbl.Name = "lblParsela" + (i + 1).ToString();
                lbl.Font = new Font("Arial", 12, FontStyle.Bold);
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Transparent;


                TextBox txtBox = new TextBox();
                txtBox.Width = 75;
                txtBox.Height = 80;
                txtBox.Location = new Point(lbl.Width + 30, y);
                txtBox.Name = "txtParsela" + (i + 1).ToString();
                txtBox.KeyPress += new KeyPressEventHandler(txtHumedadProgramar_KeyPress);
                if(notificaciones.Count > 0)
                {
                    txtBox.Text = notificaciones[i].ToString();
                }
                textBoxes.Add(txtBox);



                y += 30;
                //Controls.Add(progressBar);
                panelLabels.Controls.Add(lbl);
                panelLabels.Controls.Add(txtBox);
            }
        }

        private void txtHumedadProgramar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void programarSmsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarHorarios_Click(object sender, EventArgs e)
        {
            bool vacio = false;
            bool valor = false;
            foreach(TextBox txt in textBoxes)
            {
                if(txt.Text == "")
                {
                    vacio = true;
                }
                if(txt.Text != "")
                {
                    if (int.Parse(txt.Text) > 100 || int.Parse(txt.Text) < 0)
                    {
                        valor = true;
                    }
                }
                
            }

            if (vacio)
            {
                MessageBox.Show("Rellene todos los campos antes de guardar");
            }

            if (valor)
            {
                MessageBox.Show("Los valores deben ser entre 0 y 100");
            }

            if(!vacio && !valor)
            {
                globales.eliminarNotificaciones();  
                //Registramos los valores en los globales
                foreach(TextBox txt in textBoxes)
                {
                    globales.agregarNotificacion(int.Parse(txt.Text));
                }
                if(txtNumero.Text == "" || txtNumero.Text == null)
                {
                    MessageBox.Show("ingrese un numero de celular valido");
                    txtNumero.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Notificaciones Registradas Correctamente", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
               
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
