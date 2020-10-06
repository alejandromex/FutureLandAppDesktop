using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

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

        public DataTable ctrMostrarRegistrosHumedadFiltro(string min, string max, string fechai, string fechaf)
        {

            dt = registrosModelo.mdlMostrarRegistrosHumedadFiltro(min, max, fechai, fechaf);

            return dt;
        }

        public void ctrEliminarRegistros(int rowId)
        {
            registrosModelo.mdlEliminarRegistros(rowId);
        }


    }
}
