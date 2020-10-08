using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futureland.Helpers
{
    static class globales
    {
        private static string _database;
        private static string _com;
        private static int _numParselas;
        private static string _numeroSms;
        private static List<string> _parselasNombre = new List<string>();
        private static List<int> _humedadNotificar = new List<int>();

        public static string globalDatabase
        {
            get { return _database; }
            set { _database = value; }
        }

        public static string numeroSms
        {
            get { return _numeroSms; }
            set { _numeroSms = value; }
        }

        public static string globalCom
        {
            get { return _com; }
            set { _com = value; }
        }

        public static int globalParselas
        {
            get { return _numParselas; }
            set { _numParselas = value; }
        }

        public static void globalesParselas(string value)
        {
            _parselasNombre.Add(value);
        }

        public static List<string> globalesParselasret()
        {
            return _parselasNombre;
        }

        public static void removeParsela()
        {
            _parselasNombre.RemoveAt(_parselasNombre.Count - 1);
        }

        public static void eliminarNotificaciones()
        {
            _humedadNotificar.Clear();
        }

        public static void agregarNotificacion(int value)
        {
            _humedadNotificar.Add(value);
        }

        public static List<int> notificaciones()
        {
            return _humedadNotificar;
        }
    }

}
