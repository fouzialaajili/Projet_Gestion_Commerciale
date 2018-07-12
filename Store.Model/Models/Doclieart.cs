using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public  class Doclieart
    {
        public int DoclieartId { get; set; }
        public string DoclieartNomdoc { get; set; }
        public string DoclieartLien { get; set; }
        public int  DoclieSysuser { get; set; }
        public DateTime DoclieSysDateCreation { get; set; }
        public DateTime DoclieSysDateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
