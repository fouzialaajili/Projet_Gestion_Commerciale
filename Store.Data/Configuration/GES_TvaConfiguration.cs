using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_TvaConfiguration : EntityTypeConfiguration<GES_Tva>
    {
        public GES_TvaConfiguration()
        {
            ToTable("Tva");
            HasKey(a => a.TvaId);
HasOptional<GES_Societe>(a => a.TvaSociete)
              .WithMany(d => d.SocietesTva)
              .HasForeignKey<long?>(a => a.TvaSocieteId);
        }

    }
}
