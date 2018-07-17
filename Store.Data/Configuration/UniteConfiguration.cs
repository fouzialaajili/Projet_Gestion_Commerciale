using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Store.Model;

namespace Store.Data.Configuration
{
    class UniteConfiguration : EntityTypeConfiguration<Unite>
    {
        public UniteConfiguration()
        {
            ToTable("Unite");
            HasKey(a => a.UniteId);
            HasOptional<Societe>(a => a.UniteSociete)
                .WithMany(d => d.SocieteUnite)
                .HasForeignKey<long?>(a => a.UniteSocieteId);
        }
    }
}
