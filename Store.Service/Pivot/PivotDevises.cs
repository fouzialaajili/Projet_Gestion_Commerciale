using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class PivotDevises
    {
        public long DevisesId { get; set; }
        public string DevisesCode { get; set; }

       
        public string DevisesCodeIso { get; set; }


      
        public string DevisesSymbole { get; set; }
     
        public string DevisesDescription { get; set; }
       
        public double? DevisesCoursDevise { get; set; }
      
        public int? DevisesTenueDeCompte { get; set; }

        public bool DevisesActif { get; set; }

        public long? DevisesIdDossier { get; set; }

        public string Devisessys_user { get; set; }

        public DateTime? Devisessys_dateUpdate { get; set; }

        public DateTime? Devisessys_dateCreation { get; set; }

       
            public long DeviseSocieteId { get; set; }
        public PivotDossiers DeviseSociete { get; set; }

        public ICollection<CPT_ComptesBancaires> CPT_ComptesBancaires { get; set; }

          public  ICollection<CPT_ComptesBancairesTiers> CPT_ComptesBancairesTiers { get; set; }

          public  ICollection<CPT_Ecritures> CPT_Ecritures_TC { get; set; }

        public ICollection<CPT_Ecritures> CPT_Ecritures_TR { get; set; }

          public ICollection<CPT_Journaux> CPT_Journaux { get; set; }

        public  ICollection<CPT_Pieces> CPT_Pieces_TC { get; set; }

       public ICollection<CPT_Pieces> CPT_Pieces_TR { get; set; }
  public ICollection<CPT_RelevesBancaires> CPT_RelevesBancaires { get; set; }

        public PivotDossiers GEN_Dossiers { get; set; }

        public  ICollection<PivotTiers> GEN_Tiers { get; set; }
        public  ICollection<PivotOpportunite> GES_Opportunite { get; set; }
    }
}
