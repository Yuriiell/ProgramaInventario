using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class LicorConsumoInterno
    {
        public int IdPlato { get; set; }
        public int IdLicor { get; set; }
        public decimal Medida { get; set; }
        public decimal Cantidad { get; set; }

        public LicorConsumoInterno(int idPlato, int idLicor, decimal medida, decimal cantidad)
        {
            IdPlato = idPlato;
            IdLicor = idLicor;
            Medida = medida;
            Cantidad = cantidad;
        }

        public override string ToString()
        {
            return $"IdPlato: {IdPlato}, IdLicor: {IdLicor}, Medida: {Medida}, Cantidad: {Cantidad}";
        }
    }
}
