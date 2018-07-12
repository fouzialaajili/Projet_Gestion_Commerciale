using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Marque
    {
        public int MarqueId { get; set; }
        public string MarqueCode { get; set; }
        public string  MarqueLibelle { get; set; }
         public bool MarqueActif{ get; set; }
        public int MarqueSys_user { get; set; }
        public DateTime MarqueSys_DateCreation { get; set; }
        public DateTime MarqueSys_DateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
