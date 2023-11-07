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
    internal class DAOSobranteTiki
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


        //***** CRUD de sobrantes de la base de datos *****

        public void InsertarSobrante(decimal turnoAM, decimal turnoPM)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO sobranteTiki (turnoAM, turnoPM) " +
                               "VALUES (@turnoAM, @turnoPM)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@turnoAM", turnoAM);
                    command.Parameters.AddWithValue("@turnoPM", turnoPM);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void Eliminarsobrante(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM sobranteTiki WHERE idSobranteTiki = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarSobrante(int id, decimal turnoAM, decimal turnoPM)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE sobranteTiki SET turnoAM=@turnoAM, turnoPM=@turnoPM WHERE idSobranteTiki = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@turnoAM", turnoAM);
                    command.Parameters.AddWithValue("@turnoPM", turnoPM);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Sobrante> ObtenerSobrante()
        {
            List<Sobrante> sobrantes = new List<Sobrante>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idSobranteTiki, turnoAM, turnoPM FROM sobranteTiki";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idVentaTiki = reader.GetInt32(0);
                            decimal turnoAM = reader.GetDecimal(1);
                            decimal turnoPM = reader.GetDecimal(2);

                            Sobrante sobrante = new Sobrante(idVentaTiki,turnoAM, turnoPM);
                            sobrantes.Add(sobrante);
                        }
                    }

                }
            }

            return sobrantes;
        }

        public Sobrante ObtenerSobrantePorId(int id)
        {
            Sobrante sobrante = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idSobranteTiki, turnoAM, turnoPM FROM sobranteTiki WHERE idSobranteTiki = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idVentaTiki = reader.GetInt32(0);
                            decimal turnoAM = reader.GetDecimal(1);
                            decimal turnoPM = reader.GetDecimal(2);

                            sobrante = new Sobrante(idVentaTiki, turnoAM, turnoPM);
                        }
                    }
                }
            }

            return sobrante;
        }
    }
}
