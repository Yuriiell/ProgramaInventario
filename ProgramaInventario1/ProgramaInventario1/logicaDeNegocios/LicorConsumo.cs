using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    public class LicorConsumo
    {
        public int IdConsumoLicRest { get; set; }
        public int IdLicor { get; set; }
        public double Pedidos { get; set; }
        public double Medida { get; set; }
        public double InvInicial { get; set; }
        public int Botella { get; set; }
        public double Trago { get; set; }
        public double Ventas { get; set; }

        public LicorConsumo(int idConsumoLicRest, int idLicor, double pedidos, double medida, double invInicial, int botella, double trago, double ventas)
        {
            IdConsumoLicRest = idConsumoLicRest;
            IdLicor = idLicor;
            Pedidos = pedidos;
            Medida = medida;
            InvInicial = invInicial;
            Botella = botella;
            Trago = trago;
            Ventas = ventas;
        }

        public override string ToString()
        {
            return $"IdConsumoLicRest: {IdConsumoLicRest}, IdLicor: {IdLicor}, Pedidos: {Pedidos}, Medida: {Medida}, InvInicial: {InvInicial}, Botella: {Botella}, Trago: {Trago}, Ventas: {Ventas}";
        }
    }
}
