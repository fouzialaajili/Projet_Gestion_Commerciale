﻿using Store.Data.Configuration;
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
       
        public DbSet<GES_Depot> Depots { get; set; }
      
        public DbSet<GEN_Devises> Devises { get; set; }
        public DbSet<GES_Doclie> Doclies { get; set; }
        public DbSet<GES_Doclieart> Docliearts { get; set; }
        public DbSet<GES_DocumentCommercial> DocumentCommercials { get; set; }
        public DbSet<GES_DocumentCommercialDetail> DocumentCommercialDetails { get; set; }
        public DbSet<GES_DocumentCommercialDetailSerie> DocumentCommercialDetailSeries { get; set; }
        public DbSet<GES_Famille> Familles { get; set; }
       // public DbSet<Fichetier> Fichetierss { get; set; }
       // public DbSet<FichetiersContact> FichetiersContacts { get; set; }
        //public DbSet<FichetiersRepresentant> FichetiersRepresentantss { get; set; }
        public DbSet<GES_FournisseurArticle> FournisseurArticles { get; set; }
        public DbSet<GES_Ged> Geds { get; set; }
        public DbSet<GEN_Items> GEN_Itemss { get; set; }
        public DbSet<GEN_Model> GEN_Models { get; set; }
        public DbSet<GES_Impression> Impressions { get; set; }
        public DbSet<GES_Licence> Licences { get; set; }
        public DbSet<GES_Marque> Marques { get; set; }
        public DbSet<GES_Motif> Motifs { get; set; }
        public DbSet<GES_MotifTicket> MotifTickets { get; set; }
        public DbSet<GES_MouvementStock> MouvementStocks { get; set; }
        public DbSet<GES_Nomenclature> Nomenclatures { get; set; } 
        public DbSet<GES_Objectif> Objectifs { get; set; }
        public DbSet<GES_Opportunite> Opportunites { get; set; }
        public DbSet<GES_OpportuniteDetail> OpportuniteDetails { get; set; }
       /* public DbSet<Paiement> Paiements
        { get; set; }
           public DbSet<Parametrage> Parametrages { get; set; }*/
        public DbSet<GES_Periode> Periodes { get; set; }

       // public DbSet<Profil> Profils { get; set; }
       // public DbSet<ProfilDetail> ProfilDetails { get; set; }

        public DbSet<GES_Reglement> Reglements { get; set; }
        public DbSet<GES_ReglementFacture> ReglementFactures { get; set; }

        public DbSet<GES_Representant> Representants { get; set; }
        public DbSet<GEN_Dossiers> Societes { get; set; }

        public DbSet<GES_Ticket> Tickets { get; set; }
        public DbSet<GES_TicketDetail> TicketDetails { get; set; }

        public DbSet<GES_Tolerance> Tolerances { get; set; }
    

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
             modelBuilder.Configurations.Add(new GES_DepotConfiguration());

           
            modelBuilder.Configurations.Add(new GES_DeviseConfiguration());
            modelBuilder.Configurations.Add(new GES_DoclieConfiguration());
            modelBuilder.Configurations.Add(new GES_DoclieartConfiguration());

            modelBuilder.Configurations.Add(new GES_DocumentCommercialConfiguration());
            modelBuilder.Configurations.Add(new GES_DocumentCommercialDetailConfiguration());
            modelBuilder.Configurations.Add(new GES_DocumentCommercialDetailSerieConfiguration());
            modelBuilder.Configurations.Add(new GES_FamilleConfiguration());
            /****************************/
            modelBuilder.Configurations.Add(new GEN_TiersConfiguration());
            modelBuilder.Configurations.Add(new GEN_TiersContactsConfiguration());
            modelBuilder.Configurations.Add(new GEN_DossiersContactsConfiguration());
            modelBuilder.Configurations.Add(new GES_FournisseurArticleConfiguration());
            modelBuilder.Configurations.Add(new GES_GedConfiguration());
            modelBuilder.Configurations.Add(new GES_MotifConfiguration());
            modelBuilder.Configurations.Add(new GES_MotifTicketConfiguration());
            modelBuilder.Configurations.Add(new GES_MouvementStockConfiguration());
            modelBuilder.Configurations.Add(new GES_NomenclatureConfiguration());
            modelBuilder.Configurations.Add(new GES_NumerotationConfiguration());
            modelBuilder.Configurations.Add(new GES_ObjectifConfiguration());
            modelBuilder.Configurations.Add(new GES_OpportuniteConfiguration());
            modelBuilder.Configurations.Add(new GES_OpportuniteDetailConfiguration());
            modelBuilder.Configurations.Add(new GEN_TypePaiementConfiguration());
            modelBuilder.Configurations.Add(new GEN_TypePaiementDetailConfiguration());
            modelBuilder.Configurations.Add(new CPT_ParametrageComptableConfiguration());
            modelBuilder.Configurations.Add(new GES_PeriodeConfiguration());
         //   modelBuilder.Configurations.Add(new ProfilConfiguration());
         //   modelBuilder.Configurations.Add(new ProfilDetailConfiguration());
            modelBuilder.Configurations.Add(new GES_PeriodeConfiguration());
            modelBuilder.Configurations.Add(new GES_ReglementConfiguration());
            modelBuilder.Configurations.Add(new GES_ReglementFactureConfiguration());
            modelBuilder.Configurations.Add(new GES_RepresentantConfiguration());
            modelBuilder.Configurations.Add(new GEN_DossiersConfiguration());
            modelBuilder.Configurations.Add(new GES_TicketConfiguration());
            modelBuilder.Configurations.Add(new GES_TicketDetailConfiguration());
            modelBuilder.Configurations.Add(new CPT_CodesTVAConfiguration());
           
         //   modelBuilder.Configurations.Add(new GES_());
        }
    }
}
