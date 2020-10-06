using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace futureland.Helpers
{
    class conectar
    {
        public DataTable Ejecutar(SqlCommand cmd)
        {
            string connect = "Data Source="+globales.globalDatabase+";Initial Catalog=GUTACION;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connect))
            {
                cmd.Connection = con;
                DataTable dt = new DataTable();
                var da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
    }
}
