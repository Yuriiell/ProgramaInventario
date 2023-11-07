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
    internal class DAOGastoComidaPersonal
    {

        //***** CRUD de Gasto comida personal *****


        public void InsertarComidaPersonal(int idProducto, decimal KilosXMes)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO GastoComidaPersonal (idProducto, KilosXMes) " +
                               "VALUES (@idProducto, @KilosXMes)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@KilosXMes", KilosXMes);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarPlatoDevuelto(int idComidaPersonal)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM GastoComidaPersonal WHERE idComidaPersonal = @idComidaPersonal";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idComidaPersonal", idComidaPersonal);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarPlatoDevuelto(int idComidaPersonal, int idProducto, decimal KilosXMes)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE GastoComidaPersonal SET idProducto= @idProducto, KilosXMes=@KilosXMes WHERE idComidaPersonal = @idComidaPersonal";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {

                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@KilosXMes", KilosXMes);
                    command.Parameters.AddWithValue("@idComidaPersonal", idComidaPersonal);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<ComidaPersonal> ObtenerPlatoDevuelto()
        {
            List<ComidaPersonal> comidasPersonal = new List<ComidaPersonal>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idComidaPersonal, idProducto, KilosXMes FROM GastoComidaPersonal";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idComidaPersonal = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            decimal KilosXMes = reader.GetDecimal(2);

                            ComidaPersonal comidaPersonal = new ComidaPersonal(idComidaPersonal, idProducto, KilosXMes);
                            comidasPersonal.Add(comidaPersonal);
                        }
                    }

                }
            }

            return comidasPersonal;
        }

        public ComidaPersonal ObtenerPlatoDevueltoPorId(int id)
        {
            ComidaPersonal comidaPersonal = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idComidaPersonal, idProducto, KilosXMes FROM GastoComidaPersonal WHERE idComidaPersonal = @idComidaPersonal";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idComidaPersonal", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idComidaPersonal = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            decimal KilosXMes = reader.GetDecimal(2);

                            comidaPersonal = new ComidaPersonal(idComidaPersonal, idProducto, KilosXMes);
                        }
                    }
                }
            }
            return comidaPersonal;
        }
    }
}
