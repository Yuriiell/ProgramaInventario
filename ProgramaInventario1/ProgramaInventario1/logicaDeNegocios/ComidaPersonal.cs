using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class ComidaPersonal
    {
        public int IdComidaPersonal { get; set; }
        public int IdProducto { get; set; }
        public decimal KilosXMes { get; set; }

        public ComidaPersonal(int idComidaPersonal, int idProducto, decimal kilosXMes)
        {
            IdComidaPersonal = idComidaPersonal;
            IdProducto = idProducto;
            KilosXMes = kilosXMes;
        }

        public override string ToString()
        {
            return $"IdComidaPersonal: {IdComidaPersonal}, IdProducto: {IdProducto}, KilosXMes: {KilosXMes}";
        }

    }
}
