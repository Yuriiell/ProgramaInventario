using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Producto
    {
        private String nombre;
        private decimal precio;
        private String unidadMedida;
        private String tipo;

        public Producto(string nombre, decimal precio, string unidadMedida, string tipo)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.unidadMedida = unidadMedida;
            this.tipo = tipo;
        }
    }
}
