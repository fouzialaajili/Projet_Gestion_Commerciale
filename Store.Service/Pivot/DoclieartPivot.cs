﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
   public  class DoclieartPivot
    {
        public long  DoclieartId { get; set; }
        public string DoclieartNomdoc { get; set; }
        public string DoclieartLien { get; set; }
        public int  DoclieSysuser { get; set; }
        public DateTime DoclieSysDateCreation { get; set; }
        public DateTime DoclieSysDateUpdate { get; set; }
        public long  DoclieartSocieteId { get; set; }
        public DossiersPivot DoclieartSociete { get; set; }
    }
}
