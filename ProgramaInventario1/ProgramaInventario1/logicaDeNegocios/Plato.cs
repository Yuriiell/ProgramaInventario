using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class Plato
    {
        public int IdPlato { get; set; }
        public string NombreProducto { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }

        public Plato(int idPlato, string nombreProducto, double cantidad, double precio)
        {
            IdPlato = idPlato;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
        }

        public Plato(string nombreProducto, double cantidad, double precio)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
        }

        public Plato(int idPlato, string nombreProducto, double cantidad)
        {
            IdPlato = idPlato;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"IdPlato: {IdPlato}, nombreProducto: {NombreProducto}, Cantidad: {Cantidad}, Precio: {Precio}";
        }
    }
}
