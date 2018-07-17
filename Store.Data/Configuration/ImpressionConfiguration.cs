using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ImpressionConfiguration : EntityTypeConfiguration<Impression>
    {
        public ImpressionConfiguration()
        {
            ToTable("Impression");
            HasKey(a => a.ImpressionId);
            HasOptional<Societe>(a => a.ImpressionSociete)
                .WithMany(d => d.SocieteImpression)
                .HasForeignKey<long?>(a => a.ImpressionSocieteId);
        }
    }
}
