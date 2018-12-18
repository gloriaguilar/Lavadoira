using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Pdfa;
using iText;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;

namespace Lavanderia
{
    public partial class Nueva_nota : Form
    {
        Empleados em;
        Validacion val = new Validacion();
        Random rdn = new Random();
        int a;
        public Nueva_nota()
        {
            InitializeComponent();
            cbPagado.Items.Add("Si");
            cbPagado.Items.Add("No");
            this.Text = "Generar nueva nota";
             a = rdn.Next(10000, 100000);
            txtNumNota.Text = a.ToString();
            txtNumNota.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            em = new Empleados();
            em.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            CerrarBd acc = new CerrarBd();
            if (txtCantidad.Text.Trim() == "" || txtEmpleada.Text.Trim() == "" || txtNombCliente.Text.Trim() == "" || txtNumNota.Text.Trim() == "" || cbPagado.Text.Trim() == "")
            {
                MessageBox.Show("RECUERDA LLENAR TODOS LOS CAMPOS");
            }
            else
            {
                
                int resultado = acc.InsertarNuevaNota(a.ToString(), txtNombCliente, txtEmpleada, txtCantidad, cbPagado);
                if (resultado > 0)
                {
                    Console.WriteLine("se inserto correctamente");
                    DialogResult result = MessageBox.Show("DESEA GENERAR LA NOTA PARA IMPRIMIR?", "GENERAR NOTA", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        DefinirImpresion(result);
                        this.Hide();
                        em = new Empleados();
                        em.Show();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Hide();
                        em = new Empleados();
                        em.Show();
                    }
                }
                else
                {
                    MessageBox.Show("NO SE INGRESO CORRECTAMENTE");
                }
            }
        }

        public void DefinirImpresion(DialogResult resultado)
        {
            switch(resultado)
            {
                case DialogResult.Yes:
                    Console.WriteLine("SI HIZO ALGO");
                    Imprimir();
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
            }
        }

       public void Imprimir()
        {
            var Carpeta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var Archivo = System.IO.Path.Combine(Carpeta, "Numero de nota" + txtNumNota.Text+".pdf");

            using (var escritor = new PdfWriter(Archivo))
            {
                using (var pdf = new PdfDocument(escritor))
                {
                    var doc = new Document(pdf);
                    doc.Add(new Paragraph(DateTime.Now.ToLongDateString()));
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Numero de nota: " + txtNumNota.Text));
                    doc.Add(new Paragraph("Nombre Empleada: " + txtEmpleada.Text));
                    doc.Add(new Paragraph("Nombre Cliente: " + txtNombCliente.Text));
                    doc.Add(new Paragraph("Cantidad: " + txtCantidad.Text));
                    doc.Add(new Paragraph("Encargo Pagado: " + cbPagado.GetItemText(cbPagado.SelectedItem)));
                }
            }
        }

        private void txtNumNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.soloNumeros(e);
        }

        private void cbPagado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
