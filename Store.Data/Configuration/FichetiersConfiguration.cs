using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class FichetiersConfiguration : EntityTypeConfiguration<Fichetiers>
    {
        public FichetiersConfiguration()
        {
            ToTable("Fichetiers");
            HasKey(x => x.FichetiersId);
         /*   Property(g => g.FichetiersNatureTiers).IsRequired().HasMaxLength(20);
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




            HasOptional<Paiement>(a => a.Fichetiers)
                .WithMany(d => d.Agence)
                .HasForeignKey<long?>(a => a.PaiementId);

            HasOptional<Devise>(a => a.PartenaireDevise)
                .WithMany(d => d.Partenaire)
                .HasForeignKey<long?>(a => a.PartenaireIdDeviseDefault);


            HasOptional<TypePaiement>(a => a.PartenaireTypePaiement)
               .WithMany(i => i.Agence)
               .HasForeignKey<long?>(a => a.PartenaireIdEcheancement);

            HasOptional<CompteG>(a => a.PartenaireCompteG_CompteCollectifClient)
                .WithMany(i => i.Agence_CompteCollectifClient)
                .HasForeignKey<long?>(a => a.PartenaireIdCompteCollectifClient);

            HasOptional<CompteG>(a => a.PartenaireCompteG_CompteCollectifFournisseur)
                .WithMany(i => i.Agence_CompteCollectifFournisseur)
                .HasForeignKey<long?>(a => a.PartenaireIdCompteCollectifFournisseur);
                */


        }
    }
}
