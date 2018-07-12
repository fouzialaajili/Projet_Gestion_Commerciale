using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Unite
    {
        public int UniteId { get; set; }
       public string UniteCode { get; set; }

       public string UniteLibelle
     { get; set; }
     public bool UniteActif { get; set; }
       public int UniteSys_user { get; set; }
        public DateTime UniteSys_DateCreation { get; set; }
       public DateTime UniteSys_DateUpdate { get; set; }
        public int SocieteId { get; set; }
       public Societe Societe { get; set; }
}
}
