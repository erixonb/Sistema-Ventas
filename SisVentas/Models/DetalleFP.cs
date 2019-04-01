using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class DetalleFP
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }

        public Factura Facturas { get; set; }
        public Producto Productos { get; set; }

    }
}