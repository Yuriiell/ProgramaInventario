using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class ReporteGastoVerdura
    {
        public int IdReporteVerduras { get; set; }
        public int IdProducto { get; set; }
        public double CantidadGastoXDia { get; set; }
        public int Dia { get; set; }

        public ReporteGastoVerdura(int idReporteVerduras,int idProducto, double cantidadGastoXDia, int dia)
        {
            IdReporteVerduras = idReporteVerduras;
            IdProducto = idProducto;
            CantidadGastoXDia = cantidadGastoXDia;
            Dia = dia;
        }
        public override string ToString()
        {
            return $"IdReporteVerduras: {IdReporteVerduras}, IdProducto: {IdProducto}, CantidadGastoXDia: {CantidadGastoXDia}, Dia: {Dia}";
        }
    }
}
