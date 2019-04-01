using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SisVentas.Models;

namespace SisVentas.DB.Maps
{
    public class MapFactura : EntityTypeConfiguration<Factura>
    {
        public MapFactura()
        {
            ToTable("Factura");
            HasKey(o => o.Id);

            HasRequired(o => o.Clientes)
                .WithMany(o => o.Facturas)
                .HasForeignKey(o => o.IdCliente);

        }
    }
}