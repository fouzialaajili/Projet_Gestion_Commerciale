﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class PivotArticlesKit
    {
        public long  ArticlesKitId { get; set;
        }
        public int ArticlesKitQantite { get; set; }
        public string ArticlesKitDescription { get; set; }
        public int ArticlesKitSysuser { get; set; }
        public DateTime ArticlesKitSysDateCreation { get; set; }
        public DateTime ArticlesKitSysDateUpdate { get; set; }
        public long ArticlesKitArticlesId { get; set; }
        public  PivotArticle ArticlesKitArticle { get; set; }
        public long ArticlesKitArticleId1 { get; set; }
        public  PivotArticle ArticlesKitArticle1 { get; set; }

    }
}
