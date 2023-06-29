using ProgramaInventario1.conexion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ProgramaInventario1.DAO
{
    internal class DAOProducto
    {

        public void InsertarProducto(int id, string nombre, decimal precio, string unidadMedida, string tipo)
        {
            SqlConnection conexion = SingletonConexion.GetInstancia();

            using (conexion)
            {
                string query = "INSERT INTO Producto (id, nombre, precio, unidadMedida, tipo) " +
                               "VALUES (@Id, @Nombre, @Precio, @UnidadMedida, @Tipo)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@UnidadMedida", unidadMedida);
                    command.Parameters.AddWithValue("@Tipo", tipo);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarProducto(int id)
        {
            SqlConnection conexion = SingletonConexion.GetInstancia();

            using (conexion)
            {
                string query = "DELETE FROM Producto WHERE id = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void ActualizarProducto(int id, string nombre, decimal precio, string unidadMedida, string tipo)
        {
            SqlConnection conexion = SingletonConexion.GetInstancia();

            using (conexion)
            {
                string query = "UPDATE Producto SET nombre = @Nombre, precio = @Precio, unidadMedida = @UnidadMedida, tipo = @Tipo WHERE id = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@UnidadMedida", unidadMedida);
                    command.Parameters.AddWithValue("@Tipo", tipo);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }



    }
}
