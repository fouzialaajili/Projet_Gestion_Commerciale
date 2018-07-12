using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Doclie
    {
        public int DoclieId { get; set; }
        public string DoclieNomdoc { get; set; }
        public string DoclieLien { get; set; }
        public int DoclieSysuser { get; set; }
        public DateTime DoclieSysDateCreation { get; set; }
        public DateTime DoclieSysDateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
