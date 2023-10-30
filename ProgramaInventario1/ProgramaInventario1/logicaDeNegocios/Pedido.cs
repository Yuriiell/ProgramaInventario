using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Pedido
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public string Dia { get; set; }
        public decimal CantidadPedido { get; set; }
        public decimal InvInicial { get; set; }
        public decimal InvFinal { get; set; }

        public Pedido(int idPedido, int idProducto, string dia, decimal cantidadPedido, decimal invInicial, decimal invFinal)
        {
            IdPedido = idPedido;
            IdProducto = idProducto;
            Dia = dia;
            CantidadPedido = cantidadPedido;
            InvInicial = invInicial;
            InvFinal = invFinal;
        }

        public override string ToString()
        {
            return $"idPedido: {IdPedido}, IdProducto: {IdProducto}, Dia: {Dia}, CantidadPedido: {CantidadPedido}, InvInicial: {InvInicial}, InvFinal: {InvFinal}";
        }
    }
}
