using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class TvaConfiguration : EntityTypeConfiguration<Tva>
    {
        public TvaConfiguration()
        {
            ToTable("Tva");
            HasKey(a => a.TvaId);
HasOptional<Societe>(a => a.TvaSociete)
              .WithMany(d => d.SocieteTva)
              .HasForeignKey<long?>(a => a.TvaSocieteId);
        }

    }
}
