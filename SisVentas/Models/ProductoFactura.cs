using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class ProductoFactura: Producto
    {
        public int Cantidad { get; set; }
        public double Parcial { get { return Precio * Cantidad; } }
    }
}