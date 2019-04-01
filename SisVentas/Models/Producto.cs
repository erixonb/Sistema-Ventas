using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVentas.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int IdCategoria { get; set; }

        public Categoria Categorias { get; set; }
        public List<DetalleFP> DetallesFP { get; set; }
    }
}