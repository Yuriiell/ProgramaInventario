using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class ConsumoInterno
    {
        public int IdConsumoInterno { get; set; }
        public string Nombre { get; set; }
        public decimal GRM { get; set; }
        public decimal Costo { get; set; }

        public ConsumoInterno(int idConsumoInterno, string nombre, decimal grm, decimal costo)
        {
            IdConsumoInterno = idConsumoInterno;
            Nombre = nombre;
            GRM = grm;
            Costo = costo;
        }

        public override string ToString()
        {
            return $"IdConsumoInterno: {IdConsumoInterno}, Nombre: {Nombre}, GRM: {GRM}, Costo: {Costo}";
        }

    }
}
