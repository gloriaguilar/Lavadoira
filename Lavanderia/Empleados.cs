using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavanderia
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nueva_nota nota = new Nueva_nota();
            nota.Show();
        }

        private void btnGenerarRegisto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistro dale = new FormRegistro();
            dale.Show();
        }

        private void bntRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ver = new Inicio();
            ver.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha_dia.Text = DateTime.Now.ToLongDateString();
        }
    }
}
