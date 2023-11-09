using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class ComidaPersonal
    {
        public int IdComidaPersonal { get; set; }
        public int IdProducto { get; set; }
        public double KilosXMes { get; set; }

        public ComidaPersonal(int idComidaPersonal, int idProducto, double kilosXMes)
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
