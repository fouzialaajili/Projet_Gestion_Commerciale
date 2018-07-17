using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class CrmContact
    {
        public long  CrmContactId { get; set; }
        public long  CrmContactType { get; set; }
        public DateTime CrmContactDate { get; set; }
        public string  CrmContactBesoin { get; set; }
        public string CrmContactDescbesoin { get; set; }
        public int CrmContactNote{ get; set; }
    public int CrmContactSysuser { get; set; }
        public DateTime CrmContactSysDateCreation { get; set; }
        public DateTime CrmContactSysDateUpdate { get; set; }

        public long  CrmContactSocieteId { get; set; }
        public virtual Societe CrmContactSociete { get; set; }

        public long  CrmContactOpportuniteId { get; set; }
        public virtual Opportunite CrmContactOpportunite { get; set; }

        public long  CrmContactFichetiersId { get; set; }
        public virtual Fichetier CrmContactFichetiers { get; set; }
    }
}
