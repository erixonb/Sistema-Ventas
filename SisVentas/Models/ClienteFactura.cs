using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class ClienteFactura : Cliente
    {
        public DateTime FacturaFecha { get; set; }
    }
}