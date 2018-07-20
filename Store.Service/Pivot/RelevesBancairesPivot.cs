namespace Store.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
 

    public partial class RelevesBancairesPivot
    {
     

        public long Id { get; set; }
      
        public DateTime? DateIntegration { get; set; }
       
        public long? IdCompteBancaire { get; set; }
   

        public string Description { get; set; }
  

        public long? IdDevise { get; set; }
       
        public double? SoldeDebut { get; set; }
     
        public double? SoldeFin { get; set; }
   
        [DefaultValue(true)]
        public bool Valide { get; set; }
      
        public long? IdDossier { get; set; }

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        public byte[] Fichier { get; set; }

        public virtual ComptesBancairesPivot  CPT_ComptesBancaires { get; set; }

        public virtual DevisesPivot GEN_Devises { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RelevesBancairesDetailPivot> CPT_RelevesBancairesDetail { get; set; }
    }
}
