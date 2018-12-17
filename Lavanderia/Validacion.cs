using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavanderia
{
    class Validacion
    {
        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                //Si es un numero (si se quiere validar solo letras seria: isLetter)
                if (Char.IsNumber(e.KeyChar))
                    e.Handled = false;
                //para borrar
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                //espacio
                else if (Char.IsSeparator(e.KeyChar))
                    e.Handled = false;
                //aqui se niega, si es diferente a espacio, o borrar, no deja
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
