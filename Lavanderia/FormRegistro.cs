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
            
            if (txtNomEmpleada.Text.Trim() == ""|| txtNomEmpleada.Text.Trim() == ""|| txtNumDoblo.Text.Trim() == ""|| txtPendientes.Text.Trim() == "" || txtTurno.Text.Trim() == "")
            {
                MessageBox.Show("RECUERDA LLENAR TODOS LOS CAMPOS");
                }else{
            int resultado=mostrar.InsertarNuevoRegistros(cbNumNota, txtNomEmpleada, txtNumLavadoras, txtNumDoblo, txtPendientes, txtTurno);
            if (resultado > 0)
            {
                this.Hide();
                em = new Empleados();
                em.Show();
            }
            
            else { MessageBox.Show("NO SE PUDO GENERAR REGISTRO"); }
           }
        }
        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.
        private void validar(Form formulario)
        {
            foreach (Control oControls in formulario.Controls) // Buscamos en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verificamos que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a nuestra variable.
                }
            }
            if (vacio == true) MessageBox.Show("Favor de llenar todos los campos."); // Si nuestra variable es verdadera mostramos un mensaje.
            vacio = false; // Devolvemos el valor original a nuestra variable.
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
