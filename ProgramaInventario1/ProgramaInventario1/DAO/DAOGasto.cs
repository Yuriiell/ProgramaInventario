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
    internal class DAOGasto
    {

        //***** CRUD de Producto de la base de datos *****

        public void InsertarGasto(string idProducto, double Cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO Gasto (idProducto, Cantidad) " +
                               "VALUES (@idProducto, @Cantidad)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarGasto(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM Gasto WHERE idGasto = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarGasto(int idGasto, int idProducto, string Cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE Gasto SET idProducto = @idProducto, Cantidad = @Cantidad WHERE idGasto = @idGasto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idGasto", idGasto);
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Gasto> ObtenerGastos()
        {
            List<Gasto> gastos = new List<Gasto>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idGasto, idProducto, Cantidad FROM Gasto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idGasto = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            decimal cantidad = reader.GetDecimal(2);

                            Gasto gasto = new Gasto(idGasto, idProducto, cantidad);
                            gastos.Add(gasto);
                        }
                    }

                }
            }

            return gastos;
        }

        public Gasto ObtenerGastoPorId(int id)
        {
            Gasto gasto = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idProducto, Cantidad FROM Gasto WHERE idGasto = @IdGasto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@IdGasto", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idGasto = reader.GetInt32(1);
                            int idProducto = reader.GetInt32(2);
                            decimal Cantidad = reader.GetDecimal(3);

                            gasto = new Gasto(idGasto, idProducto, Cantidad);
                        }
                    }
                }
            }

            return gasto;
        }
    }
}
