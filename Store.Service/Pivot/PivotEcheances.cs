namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
   

    public partial class PivotEcheances
    {
       
        public long Id { get; set; }

        public long? IdEcriture { get; set; }

        public long? IdTypePaiement { get; set; }

        public long? IdModePaiement { get; set; }

        public DateTime? DateEcheance { get; set; }

        public double? Pourcentage { get; set; }

        public double? MontantTC { get; set; }

        public long? IdDeviseTC { get; set; }

        public double? MontantTR { get; set; }

        public long? IdDeviseTR { get; set; }

        public int? Statut { get; set; }

        public long? IdDossier { get; set; }

        public long? IdDossierSite { get; set; }

        public string sys_user { get; set; }

   
        public DateTime? sys_dateUpdate { get; set; }

     
        public DateTime? sys_dateCreation { get; set; }

        public PivotEcritures CPT_Ecritures { get; set; }

        public  PivotItems GEN_Items_ModePaiement { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotLettrage> CPT_Lettrage { get; set; }
    }
}
