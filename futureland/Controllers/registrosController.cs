using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace futureland.Controllers
{
    class registrosController
    {
        Models.registrosModelo registrosModelo = new Models.registrosModelo();
        DataTable dt = new DataTable();
        public string ctrRegistrarHumedad(int valor)
        {
            string status;
            status = registrosModelo.mdlRegistrarHumedad(valor);
            return status;

        }

        public DataTable ctrMostrarRegistrosHumedad()
        {

            dt = registrosModelo.mdlMostrarRegistrosHumedad();

            return dt;
        }
    }
}
