using ProgramaInventario1.vistas;
using ProgramaInventario1.DAO;
namespace WinFormsApp1
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
            Application.Run(new MenuPrincipal());
            //int id = 1;
            //string nombre = "NuevoNombre";
            //double precio = 10.99;
            //string unidadMedida = "Unidad";
            //string tipo = "TipoEjemplo";

            //DAOProducto.ActualizarProducto(id, nombre, precio, unidadMedida, tipo);

            //Console.WriteLine("Producto actualizado con éxito.");
        }
    }
}