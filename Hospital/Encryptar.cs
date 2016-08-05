using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Encryptar
    {
        public static string GetSHA1HashData(string data)
        {
            //crea una nueva instancia de sha1
            SHA1Managed sha1 = new SHA1Managed();

            //Convierte la cadena encriptada en un array de bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            //crea una nueva instancia de StringBuilder para guardar la cadena encriptada
            StringBuilder returnValue = new StringBuilder();

            //hace un bucle por cada byte y lo agrega a el StringBuilder
            foreach (byte b in hashData)
            {
                returnValue.Append(b.ToString("x2"));
            }

            // retorna la cadena en hexadecimal
            return returnValue.ToString();
        }
    }
}
