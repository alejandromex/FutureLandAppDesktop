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
        public static string globalDatabase
        {
            get { return _database; }
            set { _database = value; }
        }

        public static string globalCom
        {
            get { return _com; }
            set { _com = value; }
        }
    }

}
