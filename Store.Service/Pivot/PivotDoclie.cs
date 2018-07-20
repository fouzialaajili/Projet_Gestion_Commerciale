using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class PivotDoclie
    {
        public long  DoclieId { get; set; }
        public string DoclieNomdoc { get; set; }
        public string DoclieLien { get; set; }
        public int DoclieSysuser { get; set; }
        public DateTime DoclieSysDateCreation { get; set; }
        public DateTime DoclieSysDateUpdate { get; set; }
        public long  DoclieSocieteId { get; set; }
        public PivotDossiers DoclieSociete { get; set; }
    }
}
