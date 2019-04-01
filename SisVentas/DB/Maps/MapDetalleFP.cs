using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SisVentas.Models;

namespace SisVentas.DB.Maps
{
    public class MapDetalleFP : EntityTypeConfiguration<DetalleFP>
    {
        public MapDetalleFP()
        {
            ToTable("DetalleFP");
            HasKey(o => o.IdDetalle);

            HasRequired(o => o.Productos)
                .WithMany(o => o.DetallesFP)
                .HasForeignKey(o => o.IdProducto);
            HasRequired(o => o.Facturas)
                .WithMany(o => o.DetallesFP)
                .HasForeignKey(o => o.IdFactura);
        }
    }
}