using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_ToleranceConfiguration : EntityTypeConfiguration<GES_Tolerance>
    {
        public GES_ToleranceConfiguration()
        {
            ToTable("Tolerance");
            HasKey(a => a.ToleranceId);

            HasOptional<GES_Societe>(a => a.ToleranceSociete)
              .WithMany(d => d.SocieteTolerance)
              .HasForeignKey<long?>(a => a.ToleranceSocieteId);
        }

    }
}
