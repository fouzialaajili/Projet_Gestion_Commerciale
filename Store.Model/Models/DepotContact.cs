using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public  class DepotContact
    {
public long  DepotContactID { get; set; }
public string DepotContactCivilite
        { get; set; }
public string DepotContactNom { get; set; }
public string DepotContactfonction { get; set; }
   public string DepotContactTelephone { get; set; }
        public string DepotContactGsm
        { get; set; }
        public int DepotContactSysuser { get; set; }
        public DateTime DepotContactSysDateCreation { get; set; }
        public DateTime DepotContactSysDateUpdate { get; set; }
        public string DepotContactEmail { get; set; }
    public int DepotContactActif
        { get; set; }
        public long  DepotContactDepotId { get; set; }
        public virtual Depot DepotContactDepot { get; set; }
    }
}
