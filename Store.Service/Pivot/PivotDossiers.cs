namespace Store.Service.Pivot
{
   
    using System;
    using System.Collections.Generic;


    public partial class PivotDossiers
    {
      

        public long DossierId { get; set; }
        public string CodeDossier { get; set; }

        public string DossierRaisonSociale { get; set; }
        public int? IdTypeDossier { get; set; }

        public string DossierAdresse { get; set; }

        public string DossierTel { get; set; }

        public string DossierFax { get; set; }

        public string DossierEmail { get; set; }

        public string DossierVille { get; set; }

        public string DossierPays { get; set; }

        public string DossierSiteWeb { get; set; }

        public string DossierCapitalSocial { get; set; }

        public int? IdDeviseTenueCompte { get; set; }


        public string DossierIdentifiantFiscale { get; set; }

        public string DossierIdentifiantTVA { get; set; }

        public string DossierPatente { get; set; }

        public string DossierRegistreCommerce { get; set; }

        public string DossierNumeroCNSS { get; set; }

        public string DossierICE { get; set; }

        public int? DossierComptaActif { get; set; }

        public int? DossierGescomAtif { get; set; }

        public int? DossierPaieActif { get; set; }

        public bool DossierActif { get; set; }

        public string DossierCleSecuriteCompta { get; set; }

        public string DossierCleSecuritePaie { get; set; }

        public string DossierCleSecuriteGescom { get; set; }

        public string DossierCleSecurite { get; set; }

        public string Dossiersys_user { get; set; }

        public DateTime? Dossiersys_dateUpdate { get; set; }

        public DateTime? Dossiersys_dateCreation { get; set; }

       // public virtual GEN_Societes GEN_Societes { get; set; }

        public  ICollection<CPT_Classe> CPT_Classe { get; set; }

        public  ICollection<PivotCodesTVA> CPT_CodesTVA { get; set; }

        public  ICollection<CPT_CompteG> CPT_CompteG { get; set; }

        public  ICollection<CPT_ComptesBancaires> CPT_ComptesBancaires { get; set; }

        public ICollection<CPT_Journaux> CPT_Journaux { get; set; }

        public ICollection<PivotParametrageComptable> CPT_ParametrageComptable { get; set; }

        public ICollection<CPT_Pieces> CPT_Pieces { get; set; }

    
        public  ICollection<GEN_Documents> GEN_Documents { get; set; }

      

        public  ICollection<PivotDossiersContacts> GEN_DossiersContacts { get; set; }

        public ICollection<GEN_DossiersSites> GEN_DossiersSites { get; set; }

        public ICollection<GEN_Exercices> GEN_Exercices { get; set; }

        public  ICollection<GEN_Numeration> GEN_Numeration { get; set; }
        public  ICollection<GES_Numerotation> GES_Numerotation { get; set; }

        public  ICollection<GEN_Preferences> GEN_Preferences { get; set; }

        public  ICollection<PivotTiers> GEN_Tiers { get; set; }

        public ICollection<PivotTypePaiement> GEN_TypePaiement { get; set; }


        public  ICollection<PivotMotif> GES_Motif { get; set; }

        public ICollection<PivotMotifTicket> GES_MotifTicket { get; set; }
        public ICollection<PivotMouvementStock> GES_MouvementStock { get; set; }
        public  ICollection<PivotObjectif> GES_Objectif { get; set; }
        public ICollection<PivotOpportunite> GES_Opportunite { get; set; }

        public ICollection<PivotArticle> SocieteArticle { get; set; }
    
       public  ICollection<PivotAffaire> SocieteAffaire { get; set; }
      public  ICollection<PivotCategorie> SocieteCategorie { get; set; }
      
       public  ICollection<PivotDepot> SocieteDepot { get; set; }
      public  ICollection<PivotDevises> SocieteDevise { get; set; }
       public  ICollection<PivotDoclie> SocieteDoclie { get; set; }
       public  ICollection<PivotDoclieart> SocieteDoclieart { get; set; }
       public ICollection<PivotDocumentCommercial> SocieteDocumentCommercial { get; set; }
        public ICollection<GES_DocumentCommercialDetailSerie> SocieteDocumentCommercialDetailSerie { get; set; }
       public ICollection<PivotFamille> SocieteFamille { get; set; }
       public ICollection<PivotImpression> SocieteImpression { get; set; }
       public ICollection<PivotMarque> SocieteMarque { get; set; }
      public  ICollection<PivotTolerance> SocieteTolerance { get; set; }
 
      public  ICollection<PivotUnite> SocieteUnite { get; set; }


        public ICollection<PivotPeriode> GES_Periode { get; set; }
        public  ICollection<PivotReglement> GES_Reglement { get; set; }
        public ICollection<PivotRepresentant> GES_Representant { get; set; }
        public  ICollection<PivotTicket> GES_Ticket { get; set; }
        public  ICollection<PivotCodesTVA> SocieteTVA { get; set; }
    }
}
