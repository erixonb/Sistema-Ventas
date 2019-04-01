using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class ModoPago
    {
        public int IdPago { get; set; }
        public string Nombre { get; set; }
        public string OtrosDetalles { get; set; }

        public List<Factura> Facturas { get; set; }
    }
}