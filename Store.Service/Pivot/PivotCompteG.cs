namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
 

    public partial class PivotCompteG
    {
       

        public long Id { get; set; }

        public string Code { get; set; }

      
        public string Libelle { get; set; }
      
        public long? IdClasse { get; set; }

        public long? IdTypeCompte { get; set; }
    
        public long? IdNatureCompte { get; set; }
     
        public long? IdCodeTvaDefault { get; set; }
 
        public bool Ana { get; set; }
   
        public bool Rappro { get; set; }
    
        public bool Lettrage { get; set; }

        public bool Pointage { get; set; }
       
        public long? Sens { get; set; }
   
        public bool Actif { get; set; }
      
        public long? SuiviCompteTVA { get; set; }
      
        public long? ReportANouveau { get; set; }

        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        public PivotClasse CPT_Classe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<PivotCodesTVA> CPT_CodesTVA { get; set; }

        public PivotCodesTVA CPT_CodesTVA_CodeTVADefault { get; set; }

        public PivotDossiers GEN_Dossiers { get; set; }

        public  PivotItems GEN_Items_NatureCompte { get; set; }

        public PivotItems GEN_Items_ReportANouveau { get; set; }

        public PivotItems GEN_Items_Sens { get; set; }

        public PivotItems GEN_Items_SuiviCompteTVA { get; set; }

        public PivotItems GEN_Items_TypeCompte { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotComptesBancaires> CPT_ComptesBancaires { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotEcritures> CPT_Ecritures { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotJournaux> CPT_Journaux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotParametrageComptable> CPT_ParametrageComptable_CompteBenfice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotParametrageComptable> CPT_ParametrageComptable_CompteDeficit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotTiers> GEN_Tiers_CompteCollectifClient { get; set; }


       /* [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GEN_Tiers> GEN_Tiers{ get; set; }
        */
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotTiers> GEN_Tiers_CompteCollectifFournisseur { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PivotRelevesBancairesDetail> CPT_RelevesBancairesDetail { get; set; }
    }
}
