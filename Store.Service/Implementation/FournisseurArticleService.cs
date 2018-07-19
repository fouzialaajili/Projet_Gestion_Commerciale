using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Service.Interface;
using Store.Service.Pivot;

namespace Store.Service.Implementation
{
    class FournisseurArticleService : IFournisseurArticleService
    {

        /**    virtual public GEN_Tiers FournisseurArticleFichetier { get; set; }
        virtual public GES_Article FournisseurArticleArticle
        { get; set; }
    **/
        private readonly IFournisseurArticleRepository fournisseurArticleRepository;
        private readonly IFichetierRepository tiersRepository;
        private readonly IArticleRepository articleRepository;

        private readonly IUnitOfWork unitOfWork;

        public FournisseurArticleService(IFournisseurArticleRepository fournisseurArticleRepository, IFichetierRepository tiersRepository, IArticleRepository articleRepository, IUnitOfWork unitOfWork)
        {
            this.fournisseurArticleRepository = fournisseurArticleRepository;
            this.tiersRepository = tiersRepository;
            this.articleRepository = articleRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<GES_FournisseurArticle> GetALL()
        {
            IEnumerable<GES_FournisseurArticle> fournisseurArticles = fournisseurArticleRepository.GetAll().ToList();
            IEnumerable<GES_FournisseurArticle> fournisseurArticlePivots = Mapper.Map<IEnumerable<GES_FournisseurArticle>, IEnumerable<FournisseurArticlePivot>>(fournisseurArticles);
            return fournisseurArticlePivots;
        }

        public GES_FournisseurArticle GetFournisseurArticle(long id)
        {
            var item = fournisseurArticleRepository.GetById((int)id);
            FournisseurArticlePivot fournisseurArticlePivot = Mapper.Map<GES_FournisseurArticle, FournisseurArticlePivot>(item);
            return fournisseurArticlePivot;
        }

        public IEnumerable<GES_FournisseurArticle> GetTiersFournisseurArticle(string tiersArticle)
        {
            IEnumerable<GES_FournisseurArticle> fournisseurArticles = fournisseurArticleRepository.GetItemsByModelLibelle(tiersArticle).ToList();
            IEnumerable<FournisseurArticlePivot> fournisseurArticlePivots = Mapper.Map<IEnumerable<GES_FournisseurArticle>, IEnumerable<FournisseurArticlePivot>>(fournisseurArticles);
            return fournisseurArticlePivots;
        }
        public void CreateFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            GES_FournisseurArticle item = Mapper.Map<FournisseurArticlePivot, GES_FournisseurArticle>(fournisseurArticle);
            fournisseurArticleRepository.Add(item);
        }

        public void SaveFournisseurArticle()
        {
            unitOfWork.Commit();
        }

        public void DeleteFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            throw new NotImplementedException();
        }

        public void UpdateFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            fournisseurArticleRepository.Update(Mapper.Map<FournisseurArticlePivot, GES_FournisseurArticle>(fournisseurArticle));
        }



        /*

         public IEnumerable<GES_FournisseurArticle> GetGadgets()
         {
             var fournisseurArticles = fournisseurArticleRepository.GetAll();
             return fournisseurArticles;
         }

         public IEnumerable<GES_FournisseurArticle> GetTiersFournisseurArticle(string tiersName, string fornisseurArticleName = null)
         {
             var tiers = tiersRepository.GetTiersByName(tiersName);
             return tiers.GES_FournisseurArticle.Where(g => g.Name.ToLower().Contains(tiersName.ToLower().Trim()));
         }
         // return tiers.GES_F.Where(g => g.Name.ToLower().Contains(gadgetName.ToLower().Trim()));
     }

         public GES_FournisseurArticle GetFournisseurArticle(int id)
         {
             var FournisseurArticle = fournisseurArticleRepository.GetById(id);
             return FournisseurArticle;
         }

         public void CreateFournisseurArticle(GES_FournisseurArticle FournisseurArticle)
         {
             fournisseurArticleRepository.Add(FournisseurArticle);
         }

         public void SaveFournisseurArticle()
         {
             unitOfWork.Commit();
         }

         #endregion
         */


    }
}
