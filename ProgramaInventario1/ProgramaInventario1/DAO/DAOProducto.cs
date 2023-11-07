using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace ProgramaInventario1.DAO
{
    internal class DAOProducto
    {
        //Prueba Actualización

        /**static void Main(string[] args)
        {
            int id = 1;
            string nombre = "NuevoNombre";
            double precio = 10.99;
            string unidadMedida = "Unidad";
            string tipo = "TipoEjemplo";

            ActualizarProducto(id, nombre, precio, unidadMedida, tipo);

            Console.WriteLine("Producto actualizado con éxito.");
        }**/


        //***** CRUD de Producto de la base de datos *****

        public void InsertarProducto(string nombre, double precio, string unidadMedida, string tipo)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO Producto (nombre, precio, unidadMedida, tipo) " +
                               "VALUES (@Nombre, @Precio, @UnidadMedida, @Tipo)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
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
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

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


        public static void ActualizarProducto(int id, string nombre, double precio, string unidadMedida, string tipo)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

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
                }
            }
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT id, nombre, precio, unidadMedida, tipo FROM Producto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal precio = reader.GetDecimal(2);
                            string unidadMedida = reader.GetString(3);
                            string tipo = reader.GetString(4);

                            Producto producto = new Producto(nombre, precio, unidadMedida, tipo);
                            productos.Add(producto);
                        }
                    }

                }
            }

            return productos;
        }

        public Producto ObtenerProductoPorId(int id)
        {
            Producto producto = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT id, nombre, precio, unidadMedida, tipo FROM Producto WHERE id = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader.GetString(1);
                            decimal precio = reader.GetDecimal(2);
                            string unidadMedida = reader.GetString(3);
                            string tipo = reader.GetString(4);

                            producto = new Producto(id, nombre, precio, unidadMedida, tipo);
                        }
                    }
                }
            }

            return producto;
        }


    }
}
