using Store.Model;

using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class FichetiersConfiguration : EntityTypeConfiguration<Fichetier>
    {
        public FichetiersConfiguration()
        {
            ToTable("Fichetiers");
            HasKey(x => x.FichetiersId);
          

            /***********************************/
            //    virtual public Societe FichetierSociete { get; set; }
            //virtual public Paiement FichetierPaiement { get; set; }
            //virtual public Tva FichetierTva { get; set; }
            //     virtual public FichetiersRepresentants FichetiersRepresentants { get; set; }


            HasOptional<Paiement>(a => a.FichetierPaiement)
                .WithMany(d => d.PaiementFichetier)
                .HasForeignKey<long?>(a => a.FichetierIdmodepaie);

            HasOptional<Societe>(a => a.FichetierSociete)
                        .WithMany(d => d.SocieteFichetier)
                        .HasForeignKey<long?>(a => a.FichetierSocieteId);

            HasOptional<Tva>(a => a.FichetierTva)
                       .WithMany(d => d.TvaFichetier)
                       .HasForeignKey<long?>(a => a.FichetierIdentifiantTVA);

            HasOptional<Representant>(a => a.FichetierRepresentant)
                 .WithMany(d => d.RepresentantFichetier)
                 .HasForeignKey<long?>(a => a.FichetierIdrepresentant);


        }
    }
}
