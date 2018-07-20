namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;

    public partial class PivotCodesTVA
    { 

        public long Id { get; set; }

      
        public string CodeTaux { get; set; }

        public string LibelleTaux { get; set; }


        public long? TypeTVA { get; set; }
   
        public int? Percue { get; set; }

 
        public int? Exonere { get; set; }
      
        public double? TauxTVA { get; set; }

     
        public long? IdCompteTVA { get; set; }

     
        public long? IdRubriqueDeclaration { get; set; }

        public bool Actif { get; set; }

        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        

        public  CPT_CompteG CPT_CompteG { get; set; }

        public  Pivot_Dossiers GEN_Dossiers { get; set; }

        public  GEN_Items GEN_Items_RebriqueDeclaration { get; set; }

        public  GEN_Items GEN_Items_TypeTVA { get; set; }


          public  ICollection<CPT_CompteG> CPT_CompteG_CodeTVADefault { get; set; }

        
        public  ICollection<CPT_CompteGDetailTVA> CPT_CompteGDetailTVA { get; set; }

        public long TvaSocieteId { get; set; }
        public PivotDossiers TvaSociete { get; set; }
        public  ICollection<PivotTiers> TvaFichetier { get; set; }
    }
}