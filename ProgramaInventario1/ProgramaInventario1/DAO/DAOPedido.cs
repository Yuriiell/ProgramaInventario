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
    internal class DAOPedido
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


        //***** CRUD de reporte Pedidos *****

        public void InsertarPedido(int idProducto, string dia,decimal CantidadPedido, decimal invInicial, decimal invFinal)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO Pedido (idProducto,dia,CantidadPedido,invInicial,invFinal) " +
                               "VALUES (@idProducto, @dia, @CantidadPedido, @invInicial, @invFinal)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@dia", dia);
                    command.Parameters.AddWithValue("@CantidadPedido", CantidadPedido);
                    command.Parameters.AddWithValue("@invInicial", invInicial);
                    command.Parameters.AddWithValue("@invFinal", invFinal);
                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarPedido(int id)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM Pedido WHERE idPedido = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarPedido(int idProducto, string dia, decimal CantidadPedido, decimal invInicial, decimal invFinal)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE Pedido SET idProducto=@idProducto,dia=@dia,CantidadPedido=@CantidadPedido,invInicial=@invInicial,invFina=@invFinal WHERE idPedido = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@dia", dia);
                    command.Parameters.AddWithValue("@CantidadPedido", CantidadPedido);
                    command.Parameters.AddWithValue("@invInicial", invInicial);
                    command.Parameters.AddWithValue("@invFinal", invFinal);
                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Pedido> ObtenerPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPedido, idProducto,dia,CantidadPedido,invInicial,invFinal FROM Pedido";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPedido = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            string dia = reader.GetString(2);
                            decimal CantidadPedido = reader.GetDecimal(3);
                            decimal invInicial = reader.GetDecimal(4);
                            decimal invFinal = reader.GetDecimal(5);

                            Pedido pedido = new Pedido(idPedido, idProducto, dia, CantidadPedido, invInicial, invFinal);
                            pedidos.Add(pedido);
                        }
                    }

                }
            }

            return pedidos;
        }

        public Pedido ObtenerPedidoPorId(int id)
        {
            Pedido pedido = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idPedido, idProducto,dia,CantidadPedido,invInicial,invFinal FROM Pedido WHERE idPedido = @Id";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idPedido = reader.GetInt32(0);
                            int idProducto = reader.GetInt32(1);
                            string dia = reader.GetString(2);
                            decimal CantidadPedido = reader.GetDecimal(3);
                            decimal invInicial = reader.GetDecimal(4);
                            decimal invFinal = reader.GetDecimal(5);

                            pedido = new Pedido(idPedido, idProducto, dia, CantidadPedido, invInicial, invFinal);
                        }
                    }
                }
            }

            return pedido;
        }
    }
}
