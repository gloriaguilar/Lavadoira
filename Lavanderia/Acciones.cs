using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace Lavanderia
{
    class CerrarBd
    {
        sqlite_conex con;
        SQLiteCommand comando;
        string query;
        SQLiteDataReader lector;
        public int numNota = 0;
        public string nomEmpleada;
        public string nomCliente;
        public int Cantidad = 0;
        public int Fecha = 0;
        public int Pagado = 0;
        public int NumLavado = 0;
        public int NumDoblo = 0;
        public string Pendientes;
        public string Turno;
        int resultado = 0;
        int date = 0;

        public void AbrirConexion()
        {
            con = new sqlite_conex();
            con.AbrirConexion();
        }

        public void MostrarNotas(DataGridView ver, string fecha)
        {
            date = int.Parse(fecha);
            query = "SELECT * FROM notas_clientes WHERE fecha_creacion=@fecha";
            AbrirConexion();
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@fecha", date);
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            ver.DataSource = tabla;
            ver.Columns[0].HeaderText = "Número de nota";
            ver.Columns[1].HeaderText = "Nombre Cliente";
            ver.Columns[2].HeaderText = "Fecha ";
            ver.Columns[3].HeaderText = "Lavado";
            ver.Columns[4].HeaderText = "Recibo pagado";
            ver.Columns[5].HeaderText = "Nombre empleada recibio";
            ver.Columns[6].HeaderText = "Cantidad recibo";

            con.CerrarConexion();
        }

        public void MostrarDatosComboBox(ComboBox notas)
        {
            query = "SELECT * from notas_clientes where lavado=@lavado";
            AbrirConexion();
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@lavado", "NO");
            lector = comando.ExecuteReader();
            while(lector.Read())
            {
                notas.Items.Add(lector["id_notas"].ToString());
            }
            con.CerrarConexion();
        }
        public void MostrarRegistrosComboBox(DataGridView registro, string fecha)
        {
            date = int.Parse(fecha);
            query = "SELECT * from registros_lavanderia WHERE fecha_registro=@fecha";
            AbrirConexion();
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@fecha", date);
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            registro.DataSource = tabla;
            registro.Columns[0].Visible = false;
            registro.Columns[1].HeaderText = "Número de nota";
            registro.Columns[2].HeaderText = "Nombre Empleada";
            registro.Columns[3].HeaderText = "Número que lavó";
            registro.Columns[4].HeaderText = "Número que dobló";
            registro.Columns[5].HeaderText = "Pendientes";
            registro.Columns[6].HeaderText = "Fecha de registro";
            con.CerrarConexion();
        }

        public int InsertarNuevaNota(TextBox numnota, TextBox nomcliente, TextBox empleada, TextBox cantidad, ComboBox pagado)
        {
            numNota = int.Parse(numnota.Text);
            nomCliente = nomcliente.Text;
            nomEmpleada = empleada.Text;
            Cantidad = int.Parse(cantidad.Text);

            DateTime theDate = DateTime.Now;
            int fechaCreacion = Convert.ToInt32(theDate.ToString("yyyyMMdd"));

            if (pagado.SelectedItem=="Si")
            {
                Pagado = 1;
            }else if(pagado.SelectedItem=="No")
            {
                Pagado = 0;
            }


            AbrirConexion();
            query = "INSERT INTO notas_clientes ('id_notas','nombre_cliente','fecha_creacion','lavado','notaPagada','empleadaRecibio','cantidadNota')" +
                "VALUES (@idNotas,@nombreCliente,@FechaCreacion,@lavado,@notaPagada,@empleada,@cantidad)";
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@idNotas", numNota);
            comando.Parameters.AddWithValue("@nombreCliente", nomCliente);
            comando.Parameters.AddWithValue("@FechaCreacion", fechaCreacion);
            comando.Parameters.AddWithValue("@lavado", "NO");
            comando.Parameters.AddWithValue("@notaPagada", Pagado);
            comando.Parameters.AddWithValue("@empleada", nomEmpleada);
            comando.Parameters.AddWithValue("@cantidad", Cantidad);
            resultado = comando.ExecuteNonQuery();
            return resultado;
        }

        public int InsertarNuevoRegistros(ComboBox nota, TextBox empleada, TextBox numLavadras, TextBox numDoblo, TextBox pendientes,TextBox turno)
        {
            numNota = int.Parse(nota.GetItemText(nota.SelectedItem));
            nomEmpleada = empleada.Text;
            NumLavado = int.Parse(numLavadras.Text);
            NumDoblo = int.Parse(numDoblo.Text);
            Pendientes = pendientes.Text;
            Turno = turno.Text;

            DateTime theDate = DateTime.Now;
            int fechaCreacion = Convert.ToInt32(theDate.ToString("yyyyMMdd"));

            AbrirConexion();
            query = "INSERT INTO registros_lavanderia ('id_registro','notas_id','empleada','num_lavadoras'," +
                "'num_doblo','pedientes','fecha_registro','turno') VALUES (@idRegistro,@nota,@empleada,@numLavo,@numDoblo,@pendientes,@fechaRegistro,@turno)";
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@idRegistro", numNota);
            comando.Parameters.AddWithValue("@nota", numNota);
            comando.Parameters.AddWithValue("@empleada", nomEmpleada);
            comando.Parameters.AddWithValue("@numLavo", NumLavado);
            comando.Parameters.AddWithValue("@numDoblo", NumDoblo);
            comando.Parameters.AddWithValue("@pendientes", Pendientes);
            comando.Parameters.AddWithValue("@fechaRegistro", fechaCreacion);
            comando.Parameters.AddWithValue("@turno", Turno);
            resultado = comando.ExecuteNonQuery();

            query = "UPDATE notas_clientes SET lavado=@lavado WHERE id_notas=@notas_id";
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@lavado", "SI");
            comando.Parameters.AddWithValue("@notas_id", numNota);
            resultado = comando.ExecuteNonQuery();
            return resultado;





        }

        public int EliminarRegistro(int id)
        {
            query = "DELETE FROM registros_lavanderia where notas_id=@id_nota";
            AbrirConexion();
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@id_nota", id);
            resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public int EliminarNota(int id)
        {
            query = "DELETE FROM notas_clientes where id_notas=@id_nota";
            AbrirConexion();
            comando = new SQLiteCommand(query, con.myConnection);
            comando.Parameters.AddWithValue("@id_nota", id);
            resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        /*
         public void getValores(Textfield txf){
            
        

         
         
         */


        /*INSERTAR DATOS
       sqlite_conex var = new sqlite_conex();
       string query = "INSERT INTO notas_clientes ('id_notas','nombre_cliente','fecha_creacion') VALUES (@id,@nombres,@fecha)";
       SQLiteCommand mycommand = new SQLiteCommand(query, var.myConnection);
       var.AbrirConexion();
       mycommand.Parameters.AddWithValue("@id", "");
       mycommand.Parameters.AddWithValue("@nombres", "Gloriku");
       mycommand.Parameters.AddWithValue("@fecha", "20180903");
       var resultado=mycommand.ExecuteNonQuery();
       var.CerrarConexion();
       Console.WriteLine("SE inserto con eso chido {0} "+var);*/
    }
}
