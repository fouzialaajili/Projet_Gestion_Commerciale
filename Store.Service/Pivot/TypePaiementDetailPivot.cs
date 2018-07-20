namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
 
    public partial class TypePaiementDetailPivot
    {
        public long TypePaiementDetailId { get; set; }
      
        public long? IdTypePaiement { get; set; }
    
        public long? IdModePaiement { get; set; }
    
        public long? DateCalcul { get; set; }
      
        public double? Pourcentage { get; set; }
    
        public int? NombreJour { get; set; }
      
        public long? Delai { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        public ItemsPivot GEN_Items_ModePaiement { get; set; }

        public ItemsPivot GEN_Items_DateCalcul { get; set; }

        public ItemsPivot GEN_Items_Delai { get; set; }

        public  TypePaiementPivot GEN_TypePaiement { get; set; }
    }
}
