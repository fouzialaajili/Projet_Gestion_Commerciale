﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class MarquePivot
    {
        public long MarqueId { get; set; }
        public string MarqueCode { get; set; }
        public string MarqueLibelle { get; set; }
        public bool MarqueActif { get; set; }
        public int MarqueSys_user { get; set; }
        public DateTime MarqueSys_DateCreation { get; set; }
        public DateTime MarqueSys_DateUpdate { get; set; }
        public long MarqueSocieteId { get; set; }

        public ICollection<ArticlePivot> MarqueArticle { get; set; }
        public  DossiersPivot MarqueSociete { get; set; }


    }
}
