using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

//Esta clase devuelve una unica instancia de la conexion con la base de datos

//** En App.config se cambia el nombre del servidor donde se encuentra la base de datos y el nombre de la base de datos para la conexion
//** en el espacio de Source y Catalog, también hay que hacer la base raíz

namespace ProgramaInventario1.conexion
{
    internal class SingletonConexion
    {
        private static string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(conexion1);

        // constructor privado para que se cree una unica instancia
        private SingletonConexion()
        {
        }

        // Obtiene la instancia de la conexion
        public static SqlConnection GetInstancia()
        {
            return conexion;
        }
    }
}
