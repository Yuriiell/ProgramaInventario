using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Licor
    {
        public int IdLicor { get; set; }
        public decimal Tipo { get; set; }
        public string Nombre { get; set; }
        public string Prest { get; set; }
        public decimal Precio { get; set; }

        public Licor(int idLicor, decimal tipo, string nombre, string prest, decimal precio)
        {
            IdLicor = idLicor;
            Tipo = tipo;
            Nombre = nombre;
            Prest = prest;
            Precio = precio;
        }

        public Licor(int idLicor, decimal tipo, string nombre, decimal precio)
        {
            IdLicor = idLicor;
            Tipo = tipo;
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"IdLicor: {IdLicor}, Tipo: {Tipo}, Nombre: {Nombre}, Prest: {Prest}, Precio: {Precio}";
        }
    }
}
