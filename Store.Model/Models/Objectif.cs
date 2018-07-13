using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Objectif
    {
        public int ObjectifId { get; set; }
        public int RepresentantId { get; set; }
        public DateTime? ObjectifAnnee { get; set;}
        public int ObjectifPeriode { get; set; }
        public DateTime? ObjectifDatedebut { get; set; }
        public DateTime? ObjectifDatefin { get; set; }
        public int ObjectifObjectif { get; set; }
        public decimal ObjectifCommission { get; set; }
        public int ObjectifSysuser { get; set; }
        public DateTime? ObjectifSysDateCreation { get; set; }
        public DateTime? ObjectifSysDateUpdate { get; set; }

        public Objectif()
        {
            ObjectifSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
        public Representant Representant { get; set; }

    }
}
