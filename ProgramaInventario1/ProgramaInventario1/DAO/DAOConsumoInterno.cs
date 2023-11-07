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
    internal class DAOConsumoInterno
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

        public void InsertarConsumoInterno(string nombre, decimal GRM, decimal costo)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO ConsumoInterno (nombre, GRM, costo) " +
                               "VALUES (@nombre, @GRM, @costo)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@GRM", GRM);
                    command.Parameters.AddWithValue("@costo", costo);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarConsumoInterno(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM ConsumoInterno WHERE idConsumoInterno = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarConsumoInterno(int id, string nombre, decimal GRM, decimal costo)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE ConsumoInterno SET nombre=@nombre, GRM=@GRM, costo=@costo WHERE idConsumoInterno = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@GRM", GRM);
                    command.Parameters.AddWithValue("@costo", costo);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<ConsumoInterno> ObtenerConsumos()
        {
            List<ConsumoInterno> consumos = new List<ConsumoInterno>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idConsumoInterno,nombre, GRM, costo FROM ConsumoInterno";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idConsumoInterno = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal GRM = reader.GetDecimal(2);
                            decimal costo = reader.GetDecimal(3);

                            ConsumoInterno consumo = new ConsumoInterno(idConsumoInterno, nombre, GRM, costo);
                            consumos.Add(consumo);
                        }
                    }

                }
            }

            return consumos;
        }

        public ConsumoInterno ObtenerConsumoPorId(int id)
        {
            ConsumoInterno consumo = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idConsumoInterno,nombre, GRM, costo FROM ConsumoInterno WHERE idConsumoInterno = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idConsumoInterno = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            decimal GRM = reader.GetDecimal(2);
                            decimal costo = reader.GetDecimal(3);

                            consumo = new ConsumoInterno(idConsumoInterno, nombre, GRM, costo);
                        }
                    }
                }
            }

            return consumo;
        }
    }
}
