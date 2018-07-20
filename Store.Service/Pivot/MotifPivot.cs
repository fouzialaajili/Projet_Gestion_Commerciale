using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class MotifPivot
    {
        public long MotifId { get; set; }
        /****/
        public long OpportuniteId { get; set; }
        public string MotifEtat { get; set; }
        public string MotifMotif { get; set; }
        public string MotifDescription { get; set; }
        public DateTime? MotifSysDateCreation { get; set; }
        public DateTime? MotifSysDateUpdate { get; set; }
        
         public GES_Opportunite MotifOpportunite { get; set; }
        /***/
        public long MotifdossierId { get; set; }
         public GEN_Dossiers MotifSociete { get; set; }
    }
}
