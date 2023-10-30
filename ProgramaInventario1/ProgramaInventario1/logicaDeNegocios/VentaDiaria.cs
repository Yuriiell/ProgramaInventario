using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class VentaDiaria
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TurnoAM { get; set; }
        public decimal TurnoPM { get; set; }

        public VentaDiaria(int idVenta, DateTime fecha, decimal turnoAM, decimal turnoPM)
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
