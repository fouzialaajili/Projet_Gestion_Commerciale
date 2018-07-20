namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;
    public partial class PivotClasse
    {
       

        public long Id { get; set; }

        
        public string CodeClasse { get; set; }

        public string Libelle { get; set; }

        public long? IdClasse { get; set; }

        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotClasse> CPT_Classe_Childs { get; set; }

        public PivotClasse CPT_Classe_Parent { get; set; }

        public  PivotDossiers GEN_Dossiers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotCompteG> CPT_CompteG { get; set; }
    }
}
