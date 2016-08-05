using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Modelo;
using Hospital.Controladores;
using Hospital.Conexion;

namespace Hospital.Validaciones
{
    class Validar
    {


        
      public void validaSoloNumero(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {


                e.Handled = true;
                return;
            }
            else if (e.KeyChar.Equals((char)Keys.Back))
            {



            }


        }





      public void validaCaracteres(KeyPressEventArgs e)
      {
          if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsLetter(e.KeyChar)))
          {


              e.Handled = true;
              return;
          }
          else if (e.KeyChar.Equals((char)Keys.Back))
          {



          }


      }


      public void validaComa(KeyPressEventArgs e)
      {
          string cadena = "!#$%&/()=?¡[]{}:.<>°|~.;*+´'¿_";
          if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && cadena.Contains(e.KeyChar))
          {

              e.Handled = true;
          }
          else if (e.KeyChar.Equals((char)Keys.Back))
          {



          }

      }


   public  void validaSoloLetra(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {


                e.Handled = true;
                return;
            }
            else if (e.KeyChar.Equals((char)Keys.Back))
            {



            }


        }




    }
    }
