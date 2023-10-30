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
    internal class DAOReporteGastoVerdura
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


        //***** CRUD de reporte degasto de verduras *****

        public void InsertarReporteGastoVerdura(int idProducto, decimal CantidadGastoXDia, int dia)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO ReporteGastoVerdura (idProducto, CantidadGastoXDia, dia) " +
                               "VALUES (@idProducto, @CantidadGastoXDia, @dia)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@CantidadGastoXDia", CantidadGastoXDia);
                    command.Parameters.AddWithValue("@dia", dia);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarReporteGastoVerdura(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM ReporteGastoVerdura WHERE idReporteVerduras = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarReporteGastoVerdura(int idProducto, decimal CantidadGastoXDia, int dia)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE ReporteGastoVerdura SET idProducto = @idProducto, CantidadGastoXDia = @CantidadGastoXDia, dia = @dia WHERE idReporteVerduras = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@CantidadGastoXDia", CantidadGastoXDia);
                    command.Parameters.AddWithValue("@dia", dia);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<ReporteGastoVerdura> ObtenerReportesGastoVerdura()
        {
            List<ReporteGastoVerdura> reportes = new List<ReporteGastoVerdura>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idReporteVerduras, idProducto, CantidadGastoXDia, dia FROM ReporteGastoVerdura";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idReporteVerduras = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            decimal CantidadGastoXDia = reader.GetDecimal(2);
                            int dia = reader.GetInt32(3);

                            ReporteGastoVerdura reporte = new ReporteGastoVerdura(idReporteVerduras, idProducto, CantidadGastoXDia, dia);
                            reportes.Add(reporte);
                        }
                    }

                }
            }

            return reportes;
        }

        public ReporteGastoVerdura ObtenerReporteGastoVerduraPorId(int id)
        {
            ReporteGastoVerdura reporte = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idReporteVerduras, idProducto, CantidadGastoXDia, dia FROM ReporteGastoVerdura WHERE idReporteVerduras = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idReporteVerduras = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            decimal CantidadGastoXDia = reader.GetDecimal(2);
                            int dia = reader.GetInt32(3);

                            reporte = new ReporteGastoVerdura(idReporteVerduras, idProducto, CantidadGastoXDia, dia);
                        }
                    }
                }
            }

            return reporte;
        }
    }
}
