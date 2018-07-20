namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;


    public partial class PivotComptesBancaires
    {
       

        public long Id { get; set; }
      
        public long? IdBanque { get; set; }
    
        public string NomAgence { get; set; }
  
        public string Adresse { get; set; }
       
        public string Contact { get; set; }

     
        public string Tel { get; set; }

        
        //[IsRIBUnique]      
        public string RIB { get; set; }

        public long? IdDevise { get; set; }
 
        public bool Actif { get; set; }
   
        public bool ParDefault { get; set; }

        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }
  
        public long? IdCompteG { get; set; }

        public PivotCompteG CPT_CompteG { get; set; }

        public PivotDevises GEN_Devises { get; set; }

        public PivoDossiers GEN_Dossiers { get; set; }

        public  PivotItems GEN_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<PivotRelevesBancaires> CPT_RelevesBancaires { get; set; }
    }
}
