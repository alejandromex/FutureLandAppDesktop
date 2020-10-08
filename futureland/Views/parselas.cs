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
    public partial class parselas : Form
    {
        public parselas()
        {
            InitializeComponent();
        }

        private void btnParcelas_Click(object sender, EventArgs e)
        {
            if(txtNumParselas.Text != "" && txtNumParselas.Text != "0")
            {
                globales.globalParselas = int.Parse(txtNumParselas.Text.ToString());
                this.Close();
            }
          // globales.globalParselas = 
        }

        private void txtNumParselas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
