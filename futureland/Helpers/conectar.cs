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


        public void CrearDb()
        {
            System.Data.SqlClient.SqlConnection tmpConn;
            string sqlCreateDBQuery;
            tmpConn = new SqlConnection();
            tmpConn.ConnectionString = "Data Source="+globales.globalDatabase+";Initial Catalog=master;Integrated Security=True";
            sqlCreateDBQuery = "IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'GUTACION')" +
                " BEGIN " +
                " CREATE DATABASE GUTACION" +
                "" +
                " END "; 
               //"GO " +

            string queryTable = " USE" +
                " GUTACION " +
                "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='registros' and xtype='U')" +
                " BEGIN" +
                " CREATE TABLE registros (" +
                " id INT PRIMARY KEY IDENTITY (1, 1), " +
                "valor INT," +
                " fecha datetime ) " +
                "END";
            SqlCommand myCommand = new SqlCommand(sqlCreateDBQuery, tmpConn);
            SqlCommand cmd = new SqlCommand(queryTable, tmpConn);
            try
            {
                tmpConn.Open();
                myCommand.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Create Database",
                                            MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            }
            finally
            {
                tmpConn.Close();
            }
            return;
        }
    }
}
