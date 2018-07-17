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
            Property(g => g.FichetiersNatureTiers).IsRequired().HasMaxLength(20);
            Property(g => g.FichetiersCode).IsRequired();
            Property(g => g.FichetiersRaisonSociale).IsRequired();
            Property(g => g.FichetiersActivite).IsRequired();
            Property(g => g.FichetiersAdresse).IsRequired();
            Property(g => g.FichetiersAdresseLivraison).IsRequired();
            Property(g => g.FichetiersTel).IsRequired();
            Property(g => g.FichetiersFax).IsRequired();
            Property(g => g.FichetiersEmail).IsRequired();
            Property(g => g.FichetiersVille).IsRequired();
            Property(g => g.FichetiersPays).IsRequired();
            Property(g => g.FichetiersIdentifiantFiscale).IsRequired();
            Property(g => g.TvaId).IsRequired();
            Property(g => g.FichetiersIce).IsRequired();
            Property(g => g.FichetiersPatente).IsRequired();
            Property(g => g.RepresentantId).IsRequired();
            Property(g => g.FichetiersDeviseFacturation).IsRequired();
            Property(g => g.FichetiersEncours).IsRequired();
            Property(g => g.PaiementId).IsRequired();
            Property(g => g.FichetiersRisque).IsRequired();
            Property(g => g.FichetiersActif).IsRequired();
            Property(g => g.FichetiersSys_user).IsRequired();
            Property(g => g.RepresentantId).IsRequired();


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

            HasOptional<CompteG>(a => a.PartenaireCompteG_CompteCollectifFournisseur)
                .WithMany(i => i.Agence_CompteCollectifFournisseur)
                .HasForeignKey<long?>(a => a.PartenaireIdCompteCollectifFournisseur);



        }
    }
}
