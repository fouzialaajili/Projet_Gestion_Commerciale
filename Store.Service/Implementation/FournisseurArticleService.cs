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
using AutoMapper;

namespace Store.Service.Implementation
{
    class FournisseurArticleService : IFournisseurArticleService
    {

        /**    virtual public GEN_Tiers FournisseurArticleFichetier { get; set; }
        virtual public GES_Article FournisseurArticleArticle
        { get; set; }
    
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
            IEnumerable<GES_FournisseurArticle> fournisseurArticles = fournisseurArticleRepository.GetALL().ToList();
            IEnumerable<FournisseurArticlePivot> fournisseurArticlePivots = Mapper.Map<IEnumerable<GES_FournisseurArticle>, IEnumerable<FournisseurArticlePivot>>(fournisseurArticles);
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
            fournisseurArticleRepository.Delete(Mapper.Map<FournisseurArticlePivot, GES_FournisseurArticle>(fournisseurArticle));
        }

        public void UpdateFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            fournisseurArticleRepository.Update(Mapper.Map<FournisseurArticlePivot, GES_FournisseurArticle>(fournisseurArticle));
        }
    **/
        public void CreateFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            throw new NotImplementedException();
        }

        public void DeleteFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GES_FournisseurArticle> GetALL()
        {
            throw new NotImplementedException();
        }

        public GES_FournisseurArticle GetFournisseurArticle(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GES_FournisseurArticle> GetTiersFournisseurArticle(string tiersArticle)
        {
            throw new NotImplementedException();
        }

        public void SaveFournisseurArticle()
        {
            throw new NotImplementedException();
        }

        public void UpdateFournisseurArticle(FournisseurArticlePivot fournisseurArticle)
        {
            throw new NotImplementedException();
        }
    }
}
