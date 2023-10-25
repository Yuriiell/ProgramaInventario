using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Gasto
    {
        public int IdGasto { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }

        public Gasto(int idProducto , decimal cantidad)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
        }

        public Gasto(int idGasto, int idProducto, decimal cantidad)
        {
            IdGasto = idGasto;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"IdGasto: {IdGasto}, IdProducto: {IdProducto}, Cantidad: {Cantidad}";
        }
    }
}
