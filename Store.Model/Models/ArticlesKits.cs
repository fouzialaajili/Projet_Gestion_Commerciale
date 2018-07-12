using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class ArticlesKits
    {
        public int ArticlesKitsId { get; set;
        }
        public int ArticlesKitsQantite { get; set; }
        public string ArticlesKitsDescription { get; set; }
        public int ArticlesKitsSysuser { get; set; }
        public DateTime ArticleeKitsSysDateCreation { get; set; }
        public DateTime ArticlesKitsSysDateUpdate { get; set; }
        public int ArticlesId { get; set; }
        public Articles Articles { get; set; }
        public int ArticlesId1 { get; set; }
        public Articles Articles1 { get; set; }

    }
}
