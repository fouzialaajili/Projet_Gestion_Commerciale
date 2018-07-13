using Store.Data.Configuration;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data
{
    class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreEntities") { }

        public DbSet<Admin> Admins{ get; set; }
        public DbSet<Affaire> Affaires { get; set; }
        public DbSet<Articles> Articless { get; set; }
        public DbSet<ArticlesKits> ArticlesKitss { get; set; }
        public DbSet<ArticlesPrix> ArticlesPrixs { get; set; }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<CrmContact> CrmContacts { get; set; }
        public DbSet<Depot> Depots { get; set; }
        public DbSet<DepotContact> DepotContacts { get; set; }
        public DbSet<Devises> Devisess { get; set; }
        public DbSet<Doclie> Doclies { get; set; }
        public DbSet<Doclieart> Docliearts { get; set; }
        public DbSet<DocumentCommercial> DocumentCommercials { get; set; }
        public DbSet<DocumentCommercialDetail> DocumentCommercialDetails { get; set; }
        public DbSet<DocumentCommercialDetailSerie> DocumentCommercialDetailSeries { get; set; }
        public DbSet<Famille> Familles { get; set; }
        public DbSet<Fichetiers> Fichetierss { get; set; }
        public DbSet<FichetiersContact> FichetiersContacts { get; set; }
        public DbSet<FichetiersRepresentants> FichetiersRepresentantss { get; set; }
        public DbSet<FournisseurArticle> FournisseurArticles { get; set; }
        public DbSet<Ged> Geds { get; set; }
        public DbSet<GEN_Items> GEN_Itemss { get; set; }
        public DbSet<GEN_Model> GEN_Models { get; set; }
        public DbSet<Impression> Impressions { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public DbSet<Marque> Marques { get; set; }
        public DbSet<Motif> Motifs { get; set; }
        public DbSet<MotifTicket> MotifTickets { get; set; }
        public DbSet<MouvementStock> MouvementStocks { get; set; }
        public DbSet<Nomenclature> Nomenclatures { get; set; }
        public DbSet<Objectif> Objectifs { get; set; }
        public DbSet<Opportunite> Opportunites { get; set; }
        public DbSet<OpportuniteDetail> OpportuniteDetails { get; set; }
        public DbSet<Paiement> Paiements
        { get; set; }
           public DbSet<Parametrage> Parametrage { get; set; }
        public DbSet<Periode> Periodes { get; set; }

        public DbSet<Profil> Profils { get; set; }
        public DbSet<ProfilDetail> ProfilDetails { get; set; }

        public DbSet<Reglement> Reglements { get; set; }
        public DbSet<ReglementFacture> ReglementFactures { get; set; }

        public DbSet<Representant> Representants { get; set; }
        public DbSet<Societe> Societes { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetail> TicketDetails { get; set; }

        public DbSet<Tolerance> Tolerances { get; set; }
        public DbSet<Tva> Tvas { get; set; }

        public DbSet<Unite> Unites { get; set; }
       
  

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminConfiguration());
            modelBuilder.Configurations.Add(new AffaireConfiguration());
            modelBuilder.Configurations.Add(new ArticlesConfiguration());
            modelBuilder.Configurations.Add(new ArticlesKitsConfiguration());

            modelBuilder.Configurations.Add(new ArticlesPrixConfiguration());
            modelBuilder.Configurations.Add(new CategorieConfiguration());
            modelBuilder.Configurations.Add(new CrmContactConfiguration());
            modelBuilder.Configurations.Add(new DepotConfiguration());

            modelBuilder.Configurations.Add(new DepotContactConfiguration());
            modelBuilder.Configurations.Add(new DevisesConfiguration());
            modelBuilder.Configurations.Add(new DoclieConfiguration());
            modelBuilder.Configurations.Add(new DoclieartConfiguration());

            modelBuilder.Configurations.Add(new DocumentCommercialConfiguration());
            modelBuilder.Configurations.Add(new DocumentCommercialDetailConfiguration());
            modelBuilder.Configurations.Add(new DocumentCommercialDetailSerieConfiguration());
            modelBuilder.Configurations.Add(new FamilleConfiguration());


        
    }
    }
}
