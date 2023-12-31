﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaInventario1.logicaDeNegocios
{
    internal class LicorConsumo
    {
        public int IdConsumoLicRest { get; set; }
        public int IdLicor { get; set; }
        public decimal Pedidos { get; set; }
        public decimal Medida { get; set; }
        public decimal InvInicial { get; set; }
        public int Botella { get; set; }
        public decimal Trago { get; set; }
        public decimal Ventas { get; set; }

        public LicorConsumo(int idConsumoLicRest, int idLicor, decimal pedidos, decimal medida, decimal invInicial, int botella, decimal trago, decimal ventas)
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
