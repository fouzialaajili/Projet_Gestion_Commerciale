using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class ArticlesKits
    {
        public long  ArticlesKitsId { get; set;
        }
        public int ArticlesKitsQantite { get; set; }
        public string ArticlesKitsDescription { get; set; }
        public int ArticlesKitsSysuser { get; set; }
        public DateTime ArticleeKitsSysDateCreation { get; set; }
        public DateTime ArticlesKitsSysDateUpdate { get; set; }
        public long ArticlesKitsArticlesId { get; set; }
        public virtual Articles ArticlesKitsArticles { get; set; }
        public long ArticlesKitsArticlesId1 { get; set; }
        public virtual Articles ArticlesKitsArticles1 { get; set; }

    }
}
