using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class ArticlesKit
    {
        public long  ArticlesKitId { get; set;
        }
        public int ArticlesKitQantite { get; set; }
        public string ArticlesKitDescription { get; set; }
        public int ArticlesKitSysuser { get; set; }
        public DateTime ArticlesKitSysDateCreation { get; set; }
        public DateTime ArticlesKitSysDateUpdate { get; set; }
        public long ArticlesKitArticlesId { get; set; }
        public virtual Article ArticlesKitArticle { get; set; }
        public long ArticlesKitArticleId1 { get; set; }
        public virtual Article ArticlesKitArticle1 { get; set; }

    }
}
