using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public string Dia { get; set; }
        public double CantidadPedido { get; set; }
        public double InvInicial { get; set; }
        public double InvFinal { get; set; }

        public Pedido(int idPedido, int idProducto, string dia, double cantidadPedido, double invInicial, double invFinal)
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
