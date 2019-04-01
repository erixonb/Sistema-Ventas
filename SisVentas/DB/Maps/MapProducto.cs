using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SisVentas.Models;

namespace SisVentas.DB.Maps
{
    public class MapProducto : EntityTypeConfiguration<Producto>
    {
        public MapProducto()
        {
            ToTable("Producto");
            HasKey(o => o.Id);

            HasRequired(o => o.Categorias)
                .WithMany(o => o.Productos)
                .HasForeignKey(o => o.IdCategoria);
        }
    }
}