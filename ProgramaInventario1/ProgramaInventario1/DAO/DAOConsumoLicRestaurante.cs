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
    internal class DAOConsumoLicRestaurante
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

        public void InsertarLicorConsumo(int idLicor, decimal pedidos, decimal medida, decimal invInicial, int botella,decimal trago,decimal ventas)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO ConsumoLicRestaurante (idLicor, pedidos, medida, invInicial,botella,trago,ventas) " +
                               "VALUES (@idLicor, @pedidos, @medida, @invInicial,@botella,@trago,@ventas)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idLicor", idLicor);
                    command.Parameters.AddWithValue("@pedidos", pedidos);
                    command.Parameters.AddWithValue("@medida", medida);
                    command.Parameters.AddWithValue("@invInicial", invInicial);
                    command.Parameters.AddWithValue("@botella", botella);
                    command.Parameters.AddWithValue("@trago", trago);
                    command.Parameters.AddWithValue("@ventas", ventas);

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
                string query = "DELETE FROM ConsumoLicRestaurante WHERE idConsumoLicRest = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarLicorConsumo(int id, int idLicor, decimal pedidos, decimal medida, decimal invInicial, int botella, decimal trago, decimal ventas)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE ConsumoLicRestaurante SET idLicor=@idLicor, pedidos=@pedidos, medida=@medida, invInicial=@invInicial,botella=@botella,trago=@trago,ventas=@ventas WHERE idConsumoLicRest = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@idLicor", idLicor);
                    command.Parameters.AddWithValue("@pedidos", pedidos);
                    command.Parameters.AddWithValue("@medida", medida);
                    command.Parameters.AddWithValue("@invInicial", invInicial);
                    command.Parameters.AddWithValue("@botella", botella);
                    command.Parameters.AddWithValue("@trago", trago);
                    command.Parameters.AddWithValue("@ventas", ventas);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<LicorConsumo> ObtenerLicoresConsumo()
        {
            List<LicorConsumo> licores = new List<LicorConsumo>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idConsumoLicRest, idLicor, pedidos, medida, invInicial,botella,trago,ventas FROM ConsumoLicRestaurante";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idConsumoLicRest = reader.GetInt32(0);
                            int idLicor = reader.GetInt32(1);
                            decimal pedidos = reader.GetDecimal(2);
                            decimal medida = reader.GetDecimal(3);
                            decimal invInicial = reader.GetDecimal(4);
                            int botella = reader.GetInt32(2);
                            decimal trago = reader.GetDecimal(3);
                            decimal ventas = reader.GetDecimal(4);

                            LicorConsumo licor = new LicorConsumo(idConsumoLicRest, idLicor, pedidos, medida, invInicial, botella, trago, ventas);
                            licores.Add(licor);
                        }
                    }

                }
            }

            return licores;
        }

        public LicorConsumo ObtenerLicorConsumoPorId(int id)
        {
            LicorConsumo licor = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idConsumoLicRest, idLicor, pedidos, medida, invInicial,botella,trago,ventas FROM ConsumoLicRestaurante WHERE idConsumoLicRest = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idConsumoLicRest = reader.GetInt32(0);
                            int idLicor = reader.GetInt32(1);
                            decimal pedidos = reader.GetDecimal(2);
                            decimal medida = reader.GetDecimal(3);
                            decimal invInicial = reader.GetDecimal(4);
                            int botella = reader.GetInt32(2);
                            decimal trago = reader.GetDecimal(3);
                            decimal ventas = reader.GetDecimal(4);

                            licor = new LicorConsumo(idConsumoLicRest, idLicor, pedidos, medida, invInicial, botella, trago, ventas);
                        }
                    }
                }
            }

            return licor;
        }
    }
}
