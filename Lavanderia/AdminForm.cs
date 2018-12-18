using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Lavanderia
{
    public partial class AdminForm : Form
    {
        CerrarBd DatosBd;
        public AdminForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            btnEliminarRegistro.Hide();
            btnElimNota.Hide();
            this.Text = "Administración";
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*MOSTRAR REGISTROS*/
            string fecha = dateTimePicker1.Value.ToString("yyyyMMdd");
            DatosBd = new CerrarBd();
            DatosBd.MostrarRegistrosComboBox(dataGridView1,fecha);
            dataGridView1.Show();
            btnEliminarRegistro.Show();
            btnElimNota.Hide();
        }

        private void bntVerNotas_Click(object sender, EventArgs e)
        {
            /*MOSTRAR EN EL GRIDVIEW*/
            string fecha = dateTimePicker1.Value.ToString("yyyyMMdd");
            Console.WriteLine(fecha);
            DatosBd = new CerrarBd();
            DatosBd.MostrarNotas(dataGridView1,fecha);
            dataGridView1.Show();
            btnEliminarRegistro.Hide();
            btnElimNota.Show();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha_dia.Text = DateTime.Now.ToLongDateString();
        }

        private void bntRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio traer = new Inicio();
            traer.Show();
        }

        #region EVENTO ELIMINAR REGISTRO
        /*
        *Se verifica si lo que selecciono el usuario es nulo, si es nulo
        *se descarta la funcion y manda un mensaje
        *si no, obtiene el id de la columna y lo manda a l función eliminarRegistro
        */
        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow==null)
            {
                MessageBox.Show("Por favor, seleccione una fila");
            }else
            {
                DialogResult resultado = MessageBox.Show("¿ESTAS SEGURO QUE DESEAS ELIMINAR?", "ELIMINARAS UN REGISTRO", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["notas_id"].Value);
                    DatosBd = new CerrarBd();
                    int res = DatosBd.EliminarRegistro(id);
                    if (res > 0)
                    { Console.WriteLine("SI ELIMINO"); }
                    else
                    {
                        MessageBox.Show("Error al eliminar");
                    }
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
          
        }
        #endregion
        #region EVENTO ELIMINAR NOTA.
        /*
        *Se verifica si lo que selecciono el usuario es nulo, si es nulo
        *se descarta la funcion y manda un mensaje
        *si no, obtiene el id de la columna y lo manda a l función eliminarNota
        */
        private void btnElimNota_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione una fila");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿ESTAS SEGURO QUE DESEAS ELIMINAR?", "ELIMINARAS UNA NOTA", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_notas"].Value);
                    DatosBd = new CerrarBd();
                    int res = DatosBd.EliminarNota(id);
                    if (res > 0)
                    { Console.WriteLine("SI ELIMINO"); }
                    else
                    {
                        MessageBox.Show("Error al eliminar");
                    }
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }
          
        }
        #endregion
    }
}
