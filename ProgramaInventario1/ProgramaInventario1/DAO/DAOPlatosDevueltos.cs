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
    internal class DAOPlatosDevueltos
    {

        //***** CRUD de Platos Devueltos *****


        public void InsertarPlatoDevuelto(string NombreProducto, double Cantidad, float Precio)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO PlatosDevueltos (NombreProducto, Cantidad, Precio) " +
                               "VALUES (@NombreProducto, @Cantidad, @Precio)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);
                    command.Parameters.AddWithValue("@Precio", Precio);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarPlatoDevuelto(int idPlatoDevuelto)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM PlatosDevueltos WHERE idPlatosDevueltos = @idPlatoDevuelto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idPlatoDevuelto", idPlatoDevuelto);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarPlatoDevuelto(int id, string NombreProducto, double Cantidad, float Precio)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE PlatosDevueltos SET NombreProducto = @NombreProducto, Cantidad = @Cantidad, Precio=@Precio WHERE idPlatosDevueltos = @id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {

                    command.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                    command.Parameters.AddWithValue("@Cantidad", Cantidad);
                    command.Parameters.AddWithValue("@Precio", Precio);
                    command.Parameters.AddWithValue("@idPlatosDevueltos", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Plato> ObtenerPlatoDevuelto()
        {
            List<Plato> platos = new List<Plato>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPlatoDevuelto, NombreProducto, Cantidad, Precio FROM PlatosDevueltos";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPlatoDevuelto = reader.GetInt32(0);
                            string NombreProducto = reader.GetString(1);
                            double Cantidad = reader.GetDouble(2);
                            double Precio = reader.GetDouble(3);

                            Plato plato = new Plato(idPlatoDevuelto, NombreProducto, Cantidad, Precio);
                            platos.Add(plato);
                        }
                    }

                }
            }

            return platos;
        }

        public Plato ObtenerPlatoDevueltoPorId(int id)
        {
            Plato plato = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPlatoDevuelto, NombreProducto, Cantidad, Precio FROM PlatosDevueltos WHERE idPlatoDevuelto = @idPlatoDevuelto";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@IdMerma", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idPlato = reader.GetInt32(1);
                            string NombreProducto = reader.GetString(2);
                            double Cantidad = reader.GetDouble(3);
                            double Precio = reader.GetDouble(4);

                            plato = new Plato(idPlato, NombreProducto, Cantidad, Precio);
                        }
                    }
                }
            }
            return plato;
        }
    }
}
