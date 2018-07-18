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
  public  class StoreEntities : DbContext
    {
        public StoreEntities() : base("StoreEntities") { }

        public DbSet<GES_Admin> Admins { get; set; }
        public DbSet<GES_Affaire> Affaires { get; set; }
        public DbSet<GES_Article> Articless { get; set; }
        public DbSet<GES_ArticlesKit> ArticlesKitss { get; set; }
        public DbSet<GES_ArticlesPrix> ArticlesPrixs { get; set; }
        public DbSet<GES_Categorie> Categories { get; set; }
        public DbSet<CrmContact> CrmContacts { get; set; }
        public DbSet<GES_Depot> Depots { get; set; }
        public DbSet<DepotContact> DepotContacts { get; set; }
        public DbSet<Devise> Devises { get; set; }
        public DbSet<GES_Doclie> Doclies { get; set; }
        public DbSet<GES_Doclieart> Docliearts { get; set; }
        public DbSet<GES_DocumentCommercial> DocumentCommercials { get; set; }
        public DbSet<GES_DocumentCommercialDetail> DocumentCommercialDetails { get; set; }
        public DbSet<GES_DocumentCommercialDetailSerie> DocumentCommercialDetailSeries { get; set; }
        public DbSet<GES_Famille> Familles { get; set; }
        public DbSet<Fichetier> Fichetierss { get; set; }
        public DbSet<FichetiersContact> FichetiersContacts { get; set; }
        public DbSet<FichetiersRepresentant> FichetiersRepresentantss { get; set; }
        public DbSet<FournisseurArticle> FournisseurArticles { get; set; }
        public DbSet<Ged> Geds { get; set; }
        public DbSet<GEN_Items> GEN_Itemss { get; set; }
        public DbSet<GEN_Model> GEN_Models { get; set; }
        public DbSet<GES_Impression> Impressions { get; set; }
        public DbSet<GES_Licence> Licences { get; set; }
        public DbSet<GES_Marque> Marques { get; set; }
        public DbSet<Motif> Motifs { get; set; }
        public DbSet<MotifTicket> MotifTickets { get; set; }
        public DbSet<MouvementStock> MouvementStocks { get; set; }
        public DbSet<Nomenclature> Nomenclatures { get; set; } 
        public DbSet<Objectif> Objectifs { get; set; }
        public DbSet<Opportunite> Opportunites { get; set; }
        public DbSet<OpportuniteDetail> OpportuniteDetails { get; set; }
        public DbSet<Paiement> Paiements
        { get; set; }
           public DbSet<Parametrage> Parametrages { get; set; }
        public DbSet<Periode> Periodes { get; set; }

        public DbSet<Profil> Profils { get; set; }
        public DbSet<ProfilDetail> ProfilDetails { get; set; }

        public DbSet<Reglement> Reglements { get; set; }
        public DbSet<ReglementFacture> ReglementFactures { get; set; }

        public DbSet<Representant> Representants { get; set; }
        public DbSet<Societe> Societes { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketDetail> TicketDetails { get; set; }

        public DbSet<GES_Tolerance> Tolerances { get; set; }
        public DbSet<GES_Tva> Tvas { get; set; }

        public DbSet<GES_Unite> Unites { get; set; }
       
  

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GES_AdminConfiguration());
            modelBuilder.Configurations.Add(new GES_AffaireConfiguration());
            modelBuilder.Configurations.Add(new GES_ArticleConfiguration());
            modelBuilder.Configurations.Add(new GES_ArticlesKitConfiguration());

            modelBuilder.Configurations.Add(new GES_ArticlesPrixConfiguration());
            modelBuilder.Configurations.Add(new GES_CategorieConfiguration());
            modelBuilder.Configurations.Add(new CrmContactConfiguration());
            modelBuilder.Configurations.Add(new GES_DepotConfiguration());

            modelBuilder.Configurations.Add(new DepotContactConfiguration());
            modelBuilder.Configurations.Add(new GES_DeviseConfiguration());
            modelBuilder.Configurations.Add(new GES_DoclieConfiguration());
            modelBuilder.Configurations.Add(new GES_DoclieartConfiguration());

            modelBuilder.Configurations.Add(new GES_DocumentCommercialConfiguration());
            modelBuilder.Configurations.Add(new GES_DocumentCommercialDetailConfiguration());
            modelBuilder.Configurations.Add(new DocumentCommercialDetailSerieConfiguration());
            modelBuilder.Configurations.Add(new FamilleConfiguration());
            /****************************/
            modelBuilder.Configurations.Add(new FichetiersConfiguration());
            modelBuilder.Configurations.Add(new FichetiersContactConfiguration());
            modelBuilder.Configurations.Add(new FichetiersRepresentantsConfiguration());
            modelBuilder.Configurations.Add(new FournisseurArticleConfiguration());
            modelBuilder.Configurations.Add(new GedConfiguration());
            modelBuilder.Configurations.Add(new MotifConfiguration());
            modelBuilder.Configurations.Add(new MotifTicketConfiguration());
            modelBuilder.Configurations.Add(new MouvementStockConfiguration());
            modelBuilder.Configurations.Add(new NomenclatureConfiguration());
            modelBuilder.Configurations.Add(new NumerotationConfiguration());
            modelBuilder.Configurations.Add(new ObjectifConfiguration());
            modelBuilder.Configurations.Add(new OpportuniteConfiguration());
            modelBuilder.Configurations.Add(new OpportuniteDetailConfiguration());
            modelBuilder.Configurations.Add(new PaiementConfiguration());
            modelBuilder.Configurations.Add(new ParametrageConfiguration());
            modelBuilder.Configurations.Add(new PeriodeConfiguration()); 
            modelBuilder.Configurations.Add(new PeriodeConfiguration());
            modelBuilder.Configurations.Add(new ReglementConfiguration());
            modelBuilder.Configurations.Add(new ReglementFactureConfiguration());
            modelBuilder.Configurations.Add(new RepresentantConfiguration());
            modelBuilder.Configurations.Add(new SocieteConfiguration());
            modelBuilder.Configurations.Add(new TicketConfiguration());
            modelBuilder.Configurations.Add(new TicketDetailConfiguration());
        }
    }
}
