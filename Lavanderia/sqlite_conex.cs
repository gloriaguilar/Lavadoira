using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Lavanderia
{
    class sqlite_conex
    {

        public SQLiteConnection myConnection;

        public sqlite_conex()
        {
            myConnection = new SQLiteConnection("Data Source=lavanderia.sqlite3;");
            if (!File.Exists("./lavanderia.sqlite3"))
            {
                Console.WriteLine("Se creo");
                SQLiteConnection.CreateFile("lavanderia.sqlite3");
            }
        }

        public void AbrirConexion()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }
        public void CerrarConexion()
        {
            if(myConnection.State!=System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
