using SistemasVentas.Modelos;
using SistemasVentas.VISTA.InterfazGerenteVista;
using SistemasVentas.VISTA.InterfazInicioSesionVista;
using SistemasVentas.VISTA.PersonaVistas;
using SistemasVentas.VISTA.ProveeVistas;

namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new InterfazInicioSesionVista.inicioSesionMenu());
        }
    }
}