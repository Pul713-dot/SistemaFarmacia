﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CrudCategorias());
            Application.Run(new CrudClientes());
            Application.Run(new CrudProveedores());
            Application.Run(new CrudUsuarios());
            Application.Run(new Login());
        }
    }
}
