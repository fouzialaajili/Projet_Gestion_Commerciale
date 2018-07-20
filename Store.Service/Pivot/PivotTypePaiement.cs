namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
  

    public partial class PivotTypePaiement
    {
       
        public long TypePaiementId { get; set; }
      
        public string Libelle { get; set; }

        public bool Actif { get; set; }
        public long? IdDossier { get; set; }




        public  PivotDossiers GEN_Dossiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<CPT_RelevesBancairesDetail> CPT_RelevesBancairesDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<GEN_Regelement> GEN_Regelement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotTiers> GEN_Tiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotTypePaiementDetail> GEN_TypePaiementDetail { get; set; }
    }
}
