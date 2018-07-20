namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
 

    public partial class Pivot
    {
       
        public long Id { get; set; }
        public string code { get; set; }
   
        public long? TypeTiers { get; set; }
      
        public string RaisonSociale { get; set; }
       
        public string activite { get; set; }
       
        public long? FormeJuridique { get; set; }
       
        public string Adresse { get; set; }
       
        public string adresseLivraison { get; set; }

     
        public string Tel { get; set; }

   
        public string Fax { get; set; }
     
        public string Email { get; set; }
       
        public long? Ville { get; set; }
      
        public string SiteWeb { get; set; }
   
        public string CapitalSocial { get; set; }
    
        public long? Pays { get; set; }

    
        public string IdentifiantFiscale { get; set; }
      
        public string IdentifiantTVA { get; set; }
      
        public string ice { get; set; }
      
        public string Patente { get; set; }
      
        public long? IdDeviseDefault { get; set; }
   
        public bool Actif { get; set; }
    
        public long? IdCompteCollectifClient { get; set; }
      
        public long? IdCompteCollectifFournisseur { get; set; }
      
        public long? IdEcheancement { get; set; }
     
        public long? IdGroupeRemise { get; set; }
       
        public long? IdGroupeStatistiques { get; set; }
       
        public long? IdCategorieFiscale { get; set; }
  
        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        public PivotCompteG CPT_CompteG_CompteCollectifClient { get; set; }

        public PivotCompteG CPT_CompteG_CompteCollectifFournisseur { get; set; }
        public  PivotDevises GEN_Devises { get; set; }

        public PivotDossiers GEN_Dossiers { get; set; }

        public PivotItems GEN_Items_CategorieFiscale { get; set; }

        public PivotItems GEN_Items_FormeJuridique { get; set; }

        public PivotItems GEN_Items_TypeTiers { get; set; }

        public PivotTypePaiement GEN_TypePaiement { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotTiersContacts> GEN_TiersContacts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotComptesBancairesTiers> CPT_ComptesBancairesTiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotEcritures> CPT_Ecritures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotPieces> CPT_Pieces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<RelevesBancairesDetail> CPT_RelevesBancairesDetail { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotFournisseurArticle> GES_FournisseurArticle { get; set; }
        public  ICollection<PivotOpportunite> GES_Opportunite { get; set; }
        public ICollection<PivotOpportuniteDetail> GES_OpportuniteDetail { get; set; }
        public  ICollection<PivotReglement> GES_Reglement { get; set; }
        public ICollection<PivotTicket> GES_Ticket { get; set; }
        public  ICollection<PivotTicketDetail> GES_TicketDetail { get; set; }
            public long TvaSocieteId { get; set; }
        public  PivotCodesTVA TvaSociete { get; set; }
    }
}
