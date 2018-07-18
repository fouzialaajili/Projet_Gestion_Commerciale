using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_AffaireConfiguration : EntityTypeConfiguration<GES_Affaire>
    {
        public GES_AffaireConfiguration()
        {
            ToTable("Affaire");
            HasKey(a => a.AffaireId);
            HasOptional<Societe>(a => a.AffaireSociete)
            .WithMany(d => d.SocieteAffaire)
             .HasForeignKey<long?>(a => a.AffaireSocieteId);
        }
    }
}
