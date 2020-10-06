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

namespace futureland.Views
{

    public partial class registroForm : Form
    {
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
                string[] row = { dt.Rows[i]["id"].ToString(), dt.Rows[i]["valor"].ToString(), dt.Rows[i]["fecha"].ToString() };
                dgvRegistros.Rows.Add(row);

            }
        }

        private void fillDataGridView()
        {
            dgvRegistros.Rows.Clear();

            dt = registrosController.ctrMostrarRegistrosHumedad();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] row = {dt.Rows[i]["id"].ToString() , dt.Rows[i]["valor"].ToString(), dt.Rows[i]["fecha"].ToString() };
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

        private void dgvRegistros_SelectionChanged(object sender, EventArgs e)
        {
            //   MessageBox.Show(dgvRegistros.SelectedRows.Count.ToString());
            if(dgvRegistros.SelectedRows.Count > 0)
            {
                btnEliminarRegistros.Enabled = true;
                
            }
            else
            {
                btnEliminarRegistros.Enabled = false;
            }
            


        }

        private void btnEliminarRegistros_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Eliminar "+dgvRegistros.SelectedRows.Count.ToString()+" registros seleccionados?", "Eliminar registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    // registrosController.ctrEliminarRegistro(rowId); 
                    for (int i = 0; i < dgvRegistros.SelectedRows.Count; i++)
                    {
                        int selectedIndex = dgvRegistros.SelectedRows[i].Index;
                        int rowID = Convert.ToInt32(dgvRegistros[0, selectedIndex].Value);
                        registrosController.ctrEliminarRegistros(rowID);
                    }
                    MessageBox.Show("Registros eliminados Correctamente");
                    if(cbFiltro.Checked)
                    {
                        cbFiltro.Checked = false;
                    }
                    fillDataGridView();

                }
            }
        }

        public registroForm()
        {
            InitializeComponent();
        }


    }
}
