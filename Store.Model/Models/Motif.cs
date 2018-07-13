using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Motif
    {
        public int MotifId { get; set; }
        public int OpportuniteId { get; set; }
        public string MotifEtat { get; set; }
        public string MotifMotif { get; set; }
        public string MotifDescription { get; set; }
        public DateTime? MotifSysDateCreation { get; set; }
        public DateTime? MotifSysDateUpdate { get; set; }

        public Motif()
        {
            MotifSysDateCreation = DateTime.Now;
        }
        public Opportunite Opportunite { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
