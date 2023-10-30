using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using ProgramaInventario1.logicaDeNegocios;

namespace ProgramaInventario1.DAO
{
    internal class DAOPlato
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


        //***** CRUD de Licores de consumo interno Tiki de la base de datos *****

        public void InsertarPlato(string nombre, decimal cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO Plato (nombre, cantidad) " +
                               "VALUES (@nombre, @cantidad)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cantidad", cantidad);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarPlato(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM Plato WHERE idPlato = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarPlato(int id, string nombre, decimal cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE Plato SET nombre=@nombre, cantidad=@cantidad WHERE idPlato = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Plato> ObtenerPlatos()
        {
            List<Plato> platos = new List<Plato>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPlato, nombre, cantidad FROM Plato";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlato = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal cantidad = reader.GetDecimal(2);

                            Plato plato = new Plato(idPlato, nombre, cantidad);
                            platos.Add(plato);
                        }
                    }

                }
            }

            return platos;
        }

        public Plato ObtenerPlatoPorId(int id)
        {
            Plato plato = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPlato, nombre, cantidad FROM Plato WHERE idPlato = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idPlato = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal cantidad = reader.GetDecimal(2);

                            plato = new Plato(idPlato, nombre, cantidad);
                        }
                    }
                }
            }

            return plato;
        }
    }
}
