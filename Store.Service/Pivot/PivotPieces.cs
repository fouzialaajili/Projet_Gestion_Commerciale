namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
  

    public partial class PivotPieces
    {
        

        public long Id { get; set; }
     
        public long? TypePiece { get; set; }
 
        public string OriginePiece { get; set; }
     
        public DateTime? DatePiece { get; set; }

        public DateTime? DateReference { get; set; }
   
        public DateTime? DateFacture { get; set; }
 
        public string RefPiece { get; set; }
  
        public long? IdTiers { get; set; }

        public long? IdJournal { get; set; }

   
        public string NumPiece { get; set; }

        public string Libelle { get; set; }

        public double? CourChange { get; set; }

        public long? IdDeviseTC { get; set; }

  
        public long? IdDeviseTR { get; set; }

     
        public long? IdDossier { get; set; }

        public long? IdDossierSite { get; set; }

  
        public int? Brouillon { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }
        public PivotJournaux CPT_Journaux { get; set; }

        public PivotDevises GEN_DevisesTC { get; set; }

        public PivotDevises GEN_DevisesTR { get; set; }

        public PivotDossiers GEN_Dossiers { get; set; }

        public PivotDossiersSites GEN_DossiersSites { get; set; }

        public PivotTiers GEN_Tiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotEcritures> CPT_Ecritures { get; set; }

      
    }
}
