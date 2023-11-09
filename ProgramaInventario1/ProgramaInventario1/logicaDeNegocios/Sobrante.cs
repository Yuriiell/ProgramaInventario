using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class Sobrante
    {
        public int IdSobrante { get; set; }
        public double TurnoAM { get; set; }
        public double TurnoPM { get; set; }

        public Sobrante(int idSobrante, double turnoAM, double turnoPM)
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
