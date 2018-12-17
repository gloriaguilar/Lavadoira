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
    public partial class FormRegistro : Form
    {
        Validacion val = new Validacion();
        CerrarBd mostrar;
        Empleados em;
        public FormRegistro()
        {
            InitializeComponent();
            Mostrar_datos();
            this.Text = "Generar nuevo registro";
        }

        public void Mostrar_datos()
        {
            mostrar = new CerrarBd();
            mostrar.MostrarDatosComboBox(cbNumNota);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            em = new Empleados();
            em.Show();
        }

        private void bntAgregarRegistro_Click(object sender, EventArgs e)
        {
            mostrar = new CerrarBd();
            int resultado=mostrar.InsertarNuevoRegistros(cbNumNota, txtNomEmpleada, txtNumLavadoras, txtNumDoblo, txtPendientes, txtTurno);
            if (resultado > 0)
            {
                this.Hide();
                em = new Empleados();
                em.Show();
            }
            else { MessageBox.Show("NO SE PUDO GENERAR REGISTRO"); }
        }

        private void txtNumLavadoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtNumDoblo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void cbNumNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
