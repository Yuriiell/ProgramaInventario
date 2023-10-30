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
    internal class DAOFiestaChicas
    {

        //***** CRUD de Fiesta Chicas de la base de datos *****

        public void InsertarFiestaChicas(string idProducto, double Cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO FiestaChicas (idProducto, Cantidad) " +
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

        public void EliminarFiestaChicas(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM FiestaChicas WHERE idFiestaChicas = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarGasto(int idFiestaChicas, int idProducto, string Cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE FiestaChicas SET idProducto = @idProducto, Cantidad = @Cantidad WHERE idFiestaChicas = @idFiestaChicas";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idFiestaChicas", idFiestaChicas);
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
                string query = "SELECT idFiestaChicas, idProducto, Cantidad FROM FiestaChicas";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idFiestaChicas = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            decimal cantidad = reader.GetDecimal(2);

                            Gasto gasto = new Gasto(idFiestaChicas, idProducto, cantidad);
                            gastos.Add(gasto);
                        }
                    }

                }
            }

            return gastos;
        }

        public Gasto ObtenerFiestaChicasPorId(int id)
        {
            Gasto gasto = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idFiestaChicas, idProducto, Cantidad FROM FiestaChicas WHERE idFiestaChicas = @idFiestaChicas";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idFiestaChicas", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idFiestaChicas = reader.GetInt32(1);
                            int idProducto = reader.GetInt32(2);
                            decimal Cantidad = reader.GetDecimal(3);

                            gasto = new Gasto(idFiestaChicas, idProducto, Cantidad);
                        }
                    }
                }
            }

            return gasto;
        }
    }
}
