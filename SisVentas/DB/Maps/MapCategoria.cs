using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SisVentas.Models;

namespace SisVentas.DB.Maps
{
    public class MapCategoria : EntityTypeConfiguration<Categoria>
    {
        public MapCategoria()
        {
            ToTable("Categoria");
            HasKey(o => o.Id);

            HasMany(o => o.Productos)
                .WithRequired(o => o.Categorias)
                .HasForeignKey(o => o.IdCategoria);
        }
    }
}