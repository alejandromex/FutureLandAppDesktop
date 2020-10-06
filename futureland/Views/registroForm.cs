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
            if(cbFiltro.Checked)
            {
                //Con filtro
                string valorMin = txtHumedadMin.Text;
                string valorMax = txtHumedadMax.Text;
                string fechaInicial = dtpFecha.Value.ToString();
                string fechaFinal = dtpFechaFinal.Value.ToString();

                if(txtHumedadMin.Text == "")
                {
                    valorMin = "0";
                }
                if(txtHumedadMax.Text == "")
                {
                    valorMax = "100";
                }
                fillDataGridViewFiltro(valorMin, valorMax, fechaInicial, fechaFinal);
            }
            else
            {
                fillDataGridView();
            }
        }

        private void registroForm_Load(object sender, EventArgs e)
        {

            fillDataGridView();
        }

        private void fillDataGridViewFiltro(string min, string max, string fechai, string fechaf)
        {
            dgvRegistros.Rows.Clear();

            dt = registrosController.ctrMostrarRegistrosHumedadFiltro(min, max, fechai, fechaf);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] row = { dt.Rows[i]["valor"].ToString(), dt.Rows[i]["fecha"].ToString()};
                dgvRegistros.Rows.Add(row);

            }
        }

        private void fillDataGridView()
        {
            dgvRegistros.Rows.Clear();

            dt = registrosController.ctrMostrarRegistrosHumedad();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] row = { dt.Rows[i]["valor"].ToString(), dt.Rows[i]["fecha"].ToString() };
                dgvRegistros.Rows.Add(row);

            }
        }

        private void cbFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFiltro.Checked)
            {
                dtpFecha.Enabled = true;
                dtpFechaFinal.Enabled = true;
                txtHumedadMax.Enabled = true;
                txtHumedadMin.Enabled = true;
            }
            else
            {
                dtpFecha.Enabled = false;
                dtpFechaFinal.Enabled = false;
                txtHumedadMax.Enabled = false;
                txtHumedadMin.Enabled = false;
            }
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public registroForm()
        {
            InitializeComponent();
        }


    }
}
