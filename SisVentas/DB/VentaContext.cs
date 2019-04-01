using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SisVentas.Models;
using SisVentas.DB.Maps;

namespace SisVentas.DB
{
    public class VentaContext : DbContext
    {
        public IDbSet<Categoria> Categorias { get; set; }
        public IDbSet<Cliente> Clientes { get; set; }
        public IDbSet<DetalleFP> DetallesFP { get; set; }
        public IDbSet<Factura> Facturas { get; set; }
        public IDbSet<ModoPago> ModoPagos { get; set; }
        public IDbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new MapCategoria());
            modelBuilder.Configurations.Add(new MapCliente());
            modelBuilder.Configurations.Add(new MapDetalleFP());
            modelBuilder.Configurations.Add(new MapFactura());
            modelBuilder.Configurations.Add(new MapModoPago());
            modelBuilder.Configurations.Add(new MapProducto());
        }
    }
}