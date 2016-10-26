using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EscalonadorDeProcessos.Controllers;
using EscalonadorDeProcessos.Views;

namespace EscalonadorDeProcessos
{
    public static class Program
    {
        private static readonly List<Controller> Controllers = new List<Controller>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitControllers();
            Application.Run(Controllers.FirstOrDefault()?.MainView);
        }

        private static void InitControllers()
        {
            var formularioController = new FormularioEscalonadorController();
            var formularioView = new FormularioEscalonador(formularioController);
            formularioController.AddView(formularioView);
            Controllers.Add(formularioController);
        }
    }
}
