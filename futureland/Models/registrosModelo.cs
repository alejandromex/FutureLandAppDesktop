using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

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
            string query = @"INSERT INTO registros values (@valor)";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@valor", valor);
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
    }
}
