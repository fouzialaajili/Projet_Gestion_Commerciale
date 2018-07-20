using Store.Model;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Store.Service.Interface
{
   public interface IFournisseurArticleService
    {
        IEnumerable<GES_FournisseurArticle> GetALL();
        GES_FournisseurArticle GetFournisseurArticle(long id);
        IEnumerable<GES_FournisseurArticle> GetTiersFournisseurArticle(string tiersArticle);
        void DeleteFournisseurArticle(FournisseurArticlePivot fournisseurArticle);
        void UpdateFournisseurArticle(FournisseurArticlePivot fournisseurArticle);
        void CreateFournisseurArticle(FournisseurArticlePivot fournisseurArticle);
        void SaveFournisseurArticle();
    }
}
