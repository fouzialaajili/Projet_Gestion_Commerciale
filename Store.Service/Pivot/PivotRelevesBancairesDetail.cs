namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;


    public partial class PivotRelevesBancairesDetail
    {
        public long Id { get; set; }
      
        public long? IdReleveBancaire { get; set; }
     
        public DateTime? DateOperation { get; set; }
     
        public DateTime? DateValeur { get; set; }
    
        public string Reference { get; set; }
      
        public string CIB { get; set; }
       
        public string CPB { get; set; }
   
        public string Designation { get; set; }
       
        public double? Debit { get; set; }
     
        public double? Credit { get; set; }
     
        public long? Rappro { get; set; }
   
        public DateTime? DateRapprochement { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }
      
        public long? TypeOperation { get; set; }
    
        public long? IdTier { get; set; }
       
        public long? IdTypePaiement { get; set; }
     
        public string NumFacture { get; set; }
       
        public long? IdNatureOperation1 { get; set; }
       
        public long? IdCodeTVA1 { get; set; }
     
        public DateTime? DatePaiement { get; set; }
     
        public long? IdPieceReglement { get; set; }
       
        public long? IdPieceFacture { get; set; }
   
        public long? IdJournalReglement { get; set; }
      
        public long? IdQua { get; set; }

        public PivotCompteG CPT_CompteG { get; set; }

        public PivotRelevesBancaires CPT_RelevesBancaires { get; set; }

        public PivotItems GEN_Items { get; set; }

        public PivotTiers GEN_Tiers { get; set; }

        public PivotTypePaiement GEN_TypePaiement { get; set; }
    }
}
