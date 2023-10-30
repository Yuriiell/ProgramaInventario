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
    internal class DAOConsumoInternoLicTiki
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

        public void InsertarLicorInternoTiki(int idLicor, decimal medida, decimal cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO ConsumoInternoLicTiki (idLicor, medida, cantidad) " +
                               "VALUES (@idLicor, @medida, @cantidad)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idLicor", idLicor);
                    command.Parameters.AddWithValue("@medida", medida);
                    command.Parameters.AddWithValue("@cantidad", cantidad);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarLicorInternoTiki(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM ConsumoInternoLicTiki WHERE idPlato = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarLicorInternoTiki(int id, int idLicor, decimal medida, decimal cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE ConsumoInternoLicTiki SET idLicor=@idLicor, medida=@medida, cantidad=@cantidad WHERE idPlato = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idLicor", idLicor);
                    command.Parameters.AddWithValue("@medida", medida);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<LicorConsumoInterno> ObtenerLicoresInternoTiki()
        {
            List<LicorConsumoInterno> licores = new List<LicorConsumoInterno>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPlato, idLicor, medida, cantidad FROM ConsumoInternoLicTiki";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlato = reader.GetInt32(0);
                            int idLicor = reader.GetInt32(1);
                            decimal medida = reader.GetDecimal(2);
                            decimal cantidad = reader.GetDecimal(3);

                            LicorConsumoInterno licor = new LicorConsumoInterno(idPlato, idLicor, medida, cantidad);
                            licores.Add(licor);
                        }
                    }

                }
            }

            return licores;
        }

        public LicorConsumoInterno ObtenerLicorInternoTikiPorId(int id)
        {
            LicorConsumoInterno licor = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPlato, idLicor, medida, cantidad FROM ConsumoInternoLicTiki WHERE idPlato = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idPlato = reader.GetInt32(0);
                            int idLicor = reader.GetInt32(1);
                            decimal medida = reader.GetDecimal(2);
                            decimal cantidad = reader.GetDecimal(3);

                            licor = new LicorConsumoInterno(idPlato, idLicor, medida, cantidad);
                        }
                    }
                }
            }

            return licor;
        }
    }
}
