using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using SisVentas.Models;

namespace SisVentas.DB.Maps
{
    public class MapModoPago : EntityTypeConfiguration<ModoPago>
    {
        public MapModoPago()
        {
            ToTable("ModoPago");
            HasKey(o => o.IdPago);
        }
    }
}