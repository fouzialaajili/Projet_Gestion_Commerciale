namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
   

    public partial class PivotJournaux
    {
        

        public long Id { get; set; }

     
        public string CodeJournal { get; set; }

    
        public string Libelle { get; set; }

        public long? TypeJournal { get; set; }

  
        public long? IdCompteContrepartie { get; set; }

        public long? IdDossier { get; set; }

        
        public long? IdDevise { get; set; }

        public bool Actif { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_DateUpdate { get; set; }

        public DateTime? sys_DateCreation { get; set; }

        public PivotCompteG CPT_CompteG { get; set; }

        public  PivotDevises GEN_Devises { get; set; }

        public  PivotDossiers GEN_Dossiers { get; set; }

        public  PivotItems GEN_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotParametrageComptable> CPT_ParametrageComptable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotPieces> CPT_Pieces { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotRegelement> GEN_Regelement { get; set; }
    }
}
