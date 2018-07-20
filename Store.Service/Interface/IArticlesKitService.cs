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
        void DeleteArticlesKitPivot(AffairePivot affaire);
        void UpdateArticlesKitPivot(AffairePivot affaire);
        void CreateArticlesKitPivot(AffairePivot affaire);
        void SaveArticlesKitPivot();
    }
}
