using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public  class Motif
    {
        public long MotifId { get; set; }
   /****/     public long OpportuniteId { get; set; }
        public string MotifEtat { get; set; }
        public string MotifMotif { get; set; }
        public string MotifDescription { get; set; }
        public DateTime? MotifSysDateCreation { get; set; }
        public DateTime? MotifSysDateUpdate { get; set; }

        public Motif()
        {
            MotifSysDateCreation = DateTime.Now;
        }
        virtual public Opportunite Opportunite { get; set; }
   /***/     public long MotifSocieteId { get; set; }
        virtual public Societe Societe { get; set; }
    }
}
