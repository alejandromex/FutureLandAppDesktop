using futureland.Helpers;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace futureland.Views
{
    public partial class configuracionForm : Form
    {
        public string database;
        public string COM;
        List<string> parselas = new List<string>();

        public configuracionForm()
        {
            
            InitializeComponent();
            ajusteInicial();
         

        }



        private void GetDataSources2()
        {
            
            string ServerName = Environment.MachineName;
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        cmbServidores.Items.Clear();
                        cmbServidores.Items.Add((ServerName + "\\" + instanceName).ToString());
                    }
                }
            }
        }

        private void getCom()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    //MessageBox.Show(desc);
                    if (desc.Contains("Arduino"))
                    {
                        cmbCom.Items.Clear();
                        cmbCom.Items.Add(deviceId);

                        COM = deviceId;
                        return;
                    }

                }
            }
            catch
            {
                //RECORDATORIO IMPORTANTE
                //En caso de presentar anomalia - Controlarla - Si no dejamos solo
            }
            MessageBox.Show("Hardware Gutacion no detectado");
        }

        private void configuracionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("¿Desea guardar los cambios?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                database = cmbServidores.Text;
                COM = cmbCom.Text;
                globales.globalDatabase = database;
                globales.globalCom = COM;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(parselas.Count > 0)
            {
                database = cmbServidores.Text;
                COM = cmbCom.Text;
                globales.globalDatabase = database;
                globales.globalCom = COM;

                if (cmbServidores.Text != "")
                {
                    Models.registrosModelo registrosModelo = new Models.registrosModelo();
                    registrosModelo.createDataTable();
                }


                this.Close();
            }
            else
            {
                MessageBox.Show("Registre al menos 1 Parsela", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }


        private void configuracionForm_Load(object sender, EventArgs e)
        {
            getCom();
            GetDataSources2();
            if (globales.globalCom != "" || globales.globalCom != null)
            {
                cmbCom.Text = globales.globalCom;
            }

            if (globales.globalDatabase != "" || globales.globalDatabase != null)
            {
                cmbServidores.Text = globales.globalDatabase;
            }
        }

        private void btnRegistrarParsela_Click(object sender, EventArgs e)
        {
            listParselas.Items.Add(txtNombreParsela.Text);

            globales.globalesParselas(txtNombreParsela.Text);
            parselas = globales.globalesParselasret();
            txtNombreParsela.Text = "";

            lblNumeroDeParselas.Text = "Numero de parselas: " + parselas.Count;
        }

        private void configuracionForm_Resize(object sender, EventArgs e)
        {
            if (this.Size.Width > 978)
            {

                lblServidores.Location = new Point((this.Width / 2) - lblServidores.Width / 2, 20);
                cmbServidores.Location = new Point((this.Width / 2) - cmbServidores.Width / 2, 50);

                lblCom.Location = new Point((this.Width / 2) - lblCom.Width / 2, 100);
                cmbCom.Location = new Point((this.Width / 2) - cmbCom.Width / 2, 130);

                lblNuevaParsela.Location = new Point((this.Width / 2) - (lblNuevaParsela.Width / 2) - txtNombreParsela.Width/2 -20, 180);
                txtNombreParsela.Location = new Point((this.Width / 2) - (txtNombreParsela.Width / 2) + lblNuevaParsela.Width / 2, 180);

                listParselas.Location = new Point(lblNuevaParsela.Location.X, lblNuevaParsela.Location.Y + 50);
                btnRegistrarParsela.Location = new Point(listParselas.Location.X + listParselas.Width , listParselas.Location.Y);

                btnGuardar.Location = new Point((this.Width / 2) - btnGuardar.Width / 2, listParselas.Location.Y + 250);
                btnEliminarParsela.Location  = new Point(btnRegistrarParsela.Location.X, btnRegistrarParsela.Location.Y + 35);
                lblNumeroDeParselas.Location = new Point(btnRegistrarParsela.Location.X , btnRegistrarParsela.Location.Y + 80);


            }
            else
            {
                ajusteInicial();
            }
        }

        private void ajusteInicial()
        {
            lblServidores.Location = new Point(20, 20);
            cmbServidores.Location = new Point(30 + lblCom.Width, 20);

            lblCom.Location = new Point(20, 70);
            cmbCom.Location = new Point(30 + lblCom.Width, 70);

            lblNuevaParsela.Location = new Point(20, 170);
            txtNombreParsela.Location = new Point(30 + lblNuevaParsela.Width, 170);
            listParselas.Location = new Point(lblNuevaParsela.Location.X, lblNuevaParsela.Location.Y + 50);
            btnRegistrarParsela.Location = new Point(listParselas.Location.X + listParselas.Width, listParselas.Location.Y);
            btnEliminarParsela.Location = new Point(listParselas.Location.X + listParselas.Width, listParselas.Location.Y+35);

            lblNumeroDeParselas.Location = new Point(listParselas.Location.X, listParselas.Location.Y + 60 + listParselas.Height/2);
        }

        private void btnEliminarParsela_Click(object sender, EventArgs e)
        {
            if (parselas.Count > 0)
            {
                globales.removeParsela();
                listParselas.Items.RemoveAt(listParselas.Items.Count - 1);
                lblNumeroDeParselas.Text = "Numero de parselas: " + parselas.Count;
            }

        }
    }
}
