using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class MotifConfiguration : EntityTypeConfiguration<Motif>
    {
        public MotifConfiguration()
        {
            ToTable("Motif");
            HasKey(x => x.MotifId);


            /***********************************/

            // virtual public Opportunite MotifOpportunite { get; set; }

            //virtual public Societe MotifSociete { get; set; }


            HasOptional<Opportunite>(a => a.MotifOpportunite)
                    .WithMany(d => d.OpportuniteMotif)
                    .HasForeignKey<long?>(a => a.OpportuniteId);

            HasOptional<Societe>(a => a.MotifSociete)
                    .WithMany(d => d.SocieteMotif)
                    .HasForeignKey<long?>(a => a.MotifSocieteId);

        }
    }
}
