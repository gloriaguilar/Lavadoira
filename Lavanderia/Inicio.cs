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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Empleados ver = new Empleados();
            ver.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm ad = new AdminForm();
            ad.Show();
        }
    }
}
