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
    internal class DAOLicorConsumoInterno
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

        public void InsertarLicorInterno(decimal tipo, string nombre, decimal precio)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO LicorConsumoInterno (tipo, nombre, precio) " +
                               "VALUES (@tipo, @nombre, @precio)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@precio", precio);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarLicorConsumo(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM LicorConsumoInterno WHERE idLicor = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarLicor(int id, decimal tipo, string nombre, decimal precio)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE LicorConsumoInterno SET tipo = @tipo, nombre = @nombre, precio = @precio WHERE idLicor = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@tipo", tipo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Licor> ObtenerLicoresInterno()
        {
            List<Licor> licores = new List<Licor>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idLicor, tipo, nombre, precio FROM LicorConsumoInterno";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idLicor = reader.GetInt32(0);
                            decimal tipo = reader.GetInt32(1);
                            string nombre = reader.GetString(2);
                            decimal precio = reader.GetDecimal(3);

                            Licor licor = new Licor(idLicor, tipo, nombre, precio);
                            licores.Add(licor);
                        }
                    }

                }
            }

            return licores;
        }

        public Licor ObtenerLicorPorId(int id)
        {
            Licor licor = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idLicor, tipo, nombre, prest, precio FROM LicorConsumoInterno WHERE idLicor = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idLicor = reader.GetInt32(0);
                            decimal tipo = reader.GetInt32(1);
                            string nombre = reader.GetString(2);
                            decimal precio = reader.GetDecimal(3);

                            licor = new Licor(idLicor, tipo, nombre, precio);
                        }
                    }
                }
            }

            return licor;
        }
    }
}
