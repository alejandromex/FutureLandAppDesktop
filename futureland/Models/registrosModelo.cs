using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace futureland.Models
{
    class registrosModelo
    {
        private SqlCommand cmd = new SqlCommand();
        private DataTable dt = new DataTable();
        Helpers.conectar conectar = new Helpers.conectar();
        public string mdlRegistrarHumedad(int valor)
        {
            string status = "error";
            string query = @"INSERT INTO registros values (@valor, @date)";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.AddSeconds(10f));
            cmd.CommandText = query;
            try
            {
                conectar.Ejecutar(cmd);
                return  "ok";
            }
            catch
            {
                return status;

            }
        }

        public DataTable mdlMostrarRegistrosHumedad()
        {
            string status = "error";
            string query = @"SELECT * from registros";
            cmd.Parameters.Clear();
            cmd.CommandText = query;
            dt = conectar.Ejecutar(cmd);
            return dt;
        }

        public DataTable mdlMostrarRegistrosHumedadFiltro(string min = null, string max = null, string fechai = null, string fechaf = null)
        {

            string query = @"SELECT * from registros where valor >= @min and valor <= @max and fecha >= @fechai and fecha <= @fechaf";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@min", min);
            cmd.Parameters.AddWithValue("@max", max);
            cmd.Parameters.AddWithValue("@fechai", fechai);
            cmd.Parameters.AddWithValue("@fechaf", fechaf);



            cmd.CommandText = query;
            dt = conectar.Ejecutar(cmd);
            return dt;
        }

        public void createDataTable()
        {

            conectar.CrearDb();
            
           
        }
    }
}
