﻿using System;
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
    internal class DAOMermasMalEstado
    {

        //***** CRUD de Mermas *****


        public void InsertarMerma(string idProducto, double cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "INSERT INTO MermasMalEstado (idProducto, cantidad) " +
                               "VALUES (@idProducto, @cantidad)";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@cantidad", cantidad);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }

        public void EliminarMerma(int idMerma)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "DELETE FROM MermasMalEstado WHERE idMerma = @idMerma";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idMerma", idMerma);

                    conexion.Open();
                    command.ExecuteNonQuery();
                    conexion.Close();
                }
            }
        }


        public static void ActualizarMerma(int idMerma, int idProducto, string cantidad)
        {
            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "UPDATE MermasMalEstado SET idProducto = @idProducto, cantidad = @cantidad WHERE idMerma = @idMerma";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@idMerma", idMerma);
                    command.Parameters.AddWithValue("@idProducto", idProducto);
                    command.Parameters.AddWithValue("@cantidad", cantidad);

                    conexion.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Merma> ObtenerMermas()
        {
            List<Merma> mermas = new List<Merma>();

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idMerma, idProducto, cantidad FROM MermasMalEstado";

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

                            Merma merma = new Merma(idGasto, idProducto, cantidad);
                            mermas.Add(merma);
                        }
                    }

                }
            }

            return mermas;
        }

        public Merma ObtenerMermaPorId(int id)
        {
            Merma merma = null;

            string conexion1 = ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conexion1);

            using (conexion)
            {
                string query = "SELECT idProducto, cantidad FROM MermasMalEstado WHERE idMerma = @IdMerma";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@IdMerma", id);
                    conexion.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idMerma = reader.GetInt32(1);
                            int idProducto = reader.GetInt32(2);
                            decimal Cantidad = reader.GetDecimal(3);

                            merma = new Merma(idMerma, idProducto, Cantidad);
                        }
                    }
                }
            }

            return merma;
        }
    }
}
