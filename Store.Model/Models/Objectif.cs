using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Objectif
    {
        public long ObjectifId { get; set; }
     /***/   public long ObjectifRepresentantId { get; set; }
        public DateTime? ObjectifAnnee { get; set;}
        public int ObjectifPeriode { get; set; }
        public DateTime? ObjectifDatedebut { get; set; }
        public DateTime? ObjectifDatefin { get; set; }
        public int ObjectifObjectif { get; set; }
        public decimal ObjectifCommission { get; set; }
        public long ObjectifSysuser { get; set; }
        public DateTime? ObjectifSysDateCreation { get; set; }
        public DateTime? ObjectifSysDateUpdate { get; set; }

        public Objectif()
        {
            ObjectifSysDateCreation = DateTime.Now;
        }
     /***/   public long ObjectifSocieteId { get; set; }
        virtual public Societe ObjectifSociete { get; set; }
        virtual public Representant ObjectifRepresentant { get; set; }

    }
}
