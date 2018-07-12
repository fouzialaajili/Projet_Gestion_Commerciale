using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class CrmContact
    {
        public int  CrmContactId { get; set; }
        public Enum CrmContactType { get; set; }
        public DateTime CrmContactDate { get; set; }
        public string  CrmContactBesoin { get; set; }
        public string CrmContactDescbesoin { get; set; }
        public int CrmContactNote{ get; set; }
    public int CrmContactSysuser { get; set; }
        public DateTime CrmContactSysDateCreation { get; set; }
        public DateTime CrmContactSysDateUpdate { get; set; }

        public int SocieteId { get; set; }
        public Societe Societe { get; set; }

        public int OpportuniteId { get; set; }
        public Opportunite Opportunite { get; set; }

        public int FicheTiersId { get; set; }
        public FicheTiers FicheTiers { get; set; }
    }
}
