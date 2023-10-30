using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Merma
    {
        public int IdMerma { get; set; }
        public int IdProducto { get; set; }
        public decimal Cantidad { get; set; }

        public Merma(int idProducto, decimal cantidad)
        {
            IdProducto = idProducto;
            Cantidad = cantidad;
        }

        public Merma(int idMerma, int idProducto, decimal cantidad)
        {
            IdMerma = idMerma;
            IdProducto = idProducto;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"IdGasto: {IdMerma}, IdProducto: {IdProducto}, Cantidad: {Cantidad}";
        }
    }
}
