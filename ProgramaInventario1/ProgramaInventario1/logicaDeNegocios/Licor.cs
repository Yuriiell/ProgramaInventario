using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class Licor
    {
        public int IdLicor { get; set; }
        public double Tipo { get; set; }
        public string Nombre { get; set; }
        public string Prest { get; set; }
        public double Precio { get; set; }

        public Licor(int idLicor, double tipo, string nombre, string prest, double precio)
        {
            IdLicor = idLicor;
            Tipo = tipo;
            Nombre = nombre;
            Prest = prest;
            Precio = precio;
        }

        public Licor(int idLicor, double tipo, string nombre, double precio)
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
