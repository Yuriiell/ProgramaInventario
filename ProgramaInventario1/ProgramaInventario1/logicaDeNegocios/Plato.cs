using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Plato
    {
        public int IdPlato { get; set; }
        public string NombreProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Plato(int idPlato, string nombreProducto, decimal cantidad, decimal precio)
        {
            IdPlato = idPlato;
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
        }

        public Plato(string nombreProducto, decimal cantidad, decimal precio)
        {
            NombreProducto = nombreProducto;
            Cantidad = cantidad;
            Precio = precio;
        }

        public Plato(int idPlato, string nombreProducto, decimal cantidad)
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
