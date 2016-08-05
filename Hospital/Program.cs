using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

     /*
            login lg = new login();
            lg.ShowDialog();
            
            if (lg.Iniciar)
       */
            Application.Run(new Principal());
         
         /*  
            else
                Application.Exit();
           */
        }
    }
}
