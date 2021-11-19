using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP
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
            Application.Run(new GymFabian ());
        }
    }
}
