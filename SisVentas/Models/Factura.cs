using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        public int IdModoPago { get; set; }
  
        public Cliente Clientes { get; set; }
        public List<DetalleFP> DetallesFP { get; set; }
    }
}