using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
   public  interface IArticlesKitService
    {
        IEnumerable<ArticlesKitPivot> GetALL();
        ArticlesKitPivot GetArticlesKit(long id);
        IEnumerable<ArticlesKitPivot> GetArticlesKitPivotByDescription(string Description);
        void DeleteArticlesKitPivot(ArticlesKitPivot articlesKit);
        void UpdateArticlesKitPivot(ArticlesKitPivot articlesKit);
        void CreateArticlesKitPivot(ArticlesKitPivot articlesKit);
        void SaveArticlesKitPivot();
    }
}
