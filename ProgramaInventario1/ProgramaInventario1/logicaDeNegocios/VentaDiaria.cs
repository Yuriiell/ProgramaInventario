using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class VentaDiaria
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public double TurnoAM { get; set; }
        public double TurnoPM { get; set; }

        public VentaDiaria(int idVenta, DateTime fecha, double turnoAM, double turnoPM)
        {
            IdVenta = idVenta;
            Fecha = fecha;
            TurnoAM = turnoAM;
            TurnoPM = turnoPM;
        }

        public override string ToString()
        {
            return $"IdVenta: {IdVenta}, Fecha: {Fecha}, TurnoAM: {TurnoAM}, TurnoPM: {TurnoPM}";
        }

    }
}
