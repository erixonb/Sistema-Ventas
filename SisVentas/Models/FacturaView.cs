using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class FacturaView
    {
        public ClienteFactura Clientes { get; set; }
        public DetalleFP Titulos { get; set; }
        public List<ProductoFactura> Productos { get; set; }
    }
}