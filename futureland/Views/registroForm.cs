using futureland.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace futureland.Views
{

    public partial class registroForm : Form
    {
        int xClick = 0, yClick = 0;
        registrosController registrosController = new registrosController();
        DataTable dt = new DataTable();

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void registroForm_Load(object sender, EventArgs e)
        {
            dgvRegistros.Rows.Clear();

            dt = registrosController.ctrMostrarRegistrosHumedad();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string[] row = { dt.Rows[i]["valor"].ToString(), DateTime.Now.ToString() };
                dgvRegistros.Rows.Add(row);

            }
        }

        public registroForm()
        {
            InitializeComponent();
        }


    }
}
