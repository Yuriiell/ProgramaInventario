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
    internal class DAOVentaDiariaTiki
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


        //***** CRUD de venta diaria de la base de datos *****

        public void InsertarVentaDiariaTiki(DateTime fecha, decimal turnoAM, decimal turnoPM)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO VentaDiariaTiki (fecha, turnoAM, turnoPM) " +
                               "VALUES (@fecha, @turnoAM, @turnoPM)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@turnoAM", turnoAM);
                    command.Parameters.AddWithValue("@turnoPM", turnoPM);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarVentaDiariaTiki(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM VentaDiariaTiki WHERE idVentaTiki = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarVentaDiariaTiki(int id,DateTime fecha, decimal turnoAM, decimal turnoPM)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE VentaDiariaTiki SET fecha=@fecha, turnoAM=@turnoAM, turnoPM=@turnoPM WHERE idVentaTiki = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@fecha", fecha);
                    command.Parameters.AddWithValue("@turnoAM", turnoAM);
                    command.Parameters.AddWithValue("@turnoPM", turnoPM);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<VentaDiaria> ObtenerVentaDiariaTiki()
        {
            List<VentaDiaria> ventas = new List<VentaDiaria>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idVentaTiki, fecha, turnoAM, turnoPM FROM VentaDiariaTiki";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idVentaTiki = reader.GetInt32(0);
                            DateTime fecha = reader.GetDateTime(1);
                            decimal turnoAM = reader.GetDecimal(2);
                            decimal turnoPM = reader.GetDecimal(3);

                            VentaDiaria venta = new VentaDiaria(idVentaTiki, fecha, turnoAM, turnoPM);
                            ventas.Add(venta);
                        }
                    }

                }
            }

            return ventas;
        }

        public VentaDiaria ObtenerVentaDiariaTikiPorId(int id)
        {
            VentaDiaria venta = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idVentaTiki, fecha, turnoAM, turnoPM FROM VentaDiariaTiki WHERE idVentaTiki = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idVentaTiki = reader.GetInt32(0);
                            DateTime fecha = reader.GetDateTime(1);
                            decimal turnoAM = reader.GetDecimal(2);
                            decimal turnoPM = reader.GetDecimal(3);

                            venta = new VentaDiaria(idVentaTiki, fecha, turnoAM, turnoPM);
                        }
                    }
                }
            }

            return venta;
        }
    }
}
