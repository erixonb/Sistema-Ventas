using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SisVentas.Models;

namespace SisVentas.DB.Maps
{
    public class MapCliente : EntityTypeConfiguration<Cliente>
    {
        public MapCliente()
        {
            ToTable("Cliente");
            HasKey(o => o.Id);

            HasMany(o => o.Facturas)
                .WithRequired(o => o.Clientes)
                .HasForeignKey(o => o.IdCliente);
        }
    }
}