using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class OpportuniteConfiguration : EntityTypeConfiguration<Opportunite>
    {
        public OpportuniteConfiguration()
        {
            ToTable("Opportunite");
            HasKey(x => x.OpportuniteId);


            /***********************************/

        // virtual public Societe OpportuniteSociete { get; set; }
        //virtual public Fichetiers OpportuniteFichetier { get; set; }
        //virtual public Devises OpportuniteDevise { get; set; }


        HasOptional<Societe>(a => a.OpportuniteSociete)
                                  .WithMany(d => d.SocieteOpportunite)
                                  .HasForeignKey<long?>(a => a.OpportuniteSocieteId);

            HasOptional<Fichetier>(a => a.OpportuniteFichetier)
                                  .WithMany(d => d.FichetiersOpportunite)
                                  .HasForeignKey<long?>(a => a.OpportuniteIdtiers);
            HasOptional<Fichetier>(a => a.OpportuniteFichetier)
                                .WithMany(d => d.FichetiersOpportunite)
                                .HasForeignKey<long?>(a => a.OpportuniteIdcommercial);

            HasOptional<Devises>(a => a.OpportuniteDevise)
                               .WithMany(d => d.DeviseOpportunite)
                               .HasForeignKey<long?>(a => a.OpportuniteIdDevise);

        }
    }
}
