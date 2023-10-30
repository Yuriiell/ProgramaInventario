using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class Sobrante
    {
        public int IdSobrante { get; set; }
        public decimal TurnoAM { get; set; }
        public decimal TurnoPM { get; set; }

        public Sobrante(int idSobrante, decimal turnoAM, decimal turnoPM)
        {
            IdSobrante = idSobrante;
            TurnoAM = turnoAM;
            TurnoPM = turnoPM;
        }

        public override string ToString()
        {
            return $"IdSobrante: {IdSobrante},  TurnoAM: {TurnoAM}, TurnoPM: {TurnoPM}";
        }
    }
}
