using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_MarqueConfiguration : EntityTypeConfiguration<GES_Marque>
    {
        public GES_MarqueConfiguration()
        {
            ToTable("Marque");
            HasKey(a => a.MarqueId);
            HasOptional<GES_Societe>(a => a.MarqueSociete)
                .WithMany(d => d.SocieteMarque)
                .HasForeignKey<long?>(a => a.MarqueSocieteId);
        }
    }
    }
