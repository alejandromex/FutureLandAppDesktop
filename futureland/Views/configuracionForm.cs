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
        public configuracionForm()
        {
            
            InitializeComponent();

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
                /* Do Nothing */
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

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            database = cmbServidores.Text;
            COM = cmbCom.Text;
            globales.globalDatabase = database;
            globales.globalCom = COM;
            this.Close();
            
        }


        private void configuracionForm_Load(object sender, EventArgs e)
        {
            getCom();
            GetDataSources2();
        }
    }
}
