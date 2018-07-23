﻿using AutoMapper;
using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using Store.Service.Interface;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Implementation
{
    class ArticlesPrixService : IArticlesPrixService
    {
        private readonly IArticlesPrixRepository articlesRepository;
        private readonly IUnitOfWork unitOfWork;
        public ArticlesPrixService(IArticlesPrixRepository articlesKitRepository, IUnitOfWork unitOfWork)
        {
            this.articlesRepository= articlesKitRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateArticlesPrixPivot(ArticlesPrixPivot articlesPrix)
        {
            GES_ArticlesPrix article= Mapper.Map<ArticlesPrixPivot, GES_ArticlesPrix>(articlesPrix);
            articlesRepository.Add(article);
        }

        public void DeleteArticlesPrixPivot(ArticlesPrixPivot articlesPrix)
        {
            articlesRepository.Delete(Mapper.Map<ArticlesPrixPivot, GES_ArticlesPrix>(articlesPrix));
        }

        public IEnumerable<ArticlesPrixPivot> GetALL()
        {
            IEnumerable<GES_ArticlesPrix> articlesPrixes= articlesRepository.GetAll().ToList();
            IEnumerable<ArticlesPrixPivot> articlesPrixesPivots = Mapper.Map<IEnumerable<GES_ArticlesPrix>, IEnumerable<ArticlesPrixPivot>>(articlesPrixes);
            return articlesPrixesPivots;
        }

        public ArticlesPrixPivot GetArticlesPrixPivot(long id)
        {
            var item = articlesRepository.GetById((int)id);
            ArticlesPrixPivot articlesPrixPivot = Mapper.Map<GES_ArticlesPrix, ArticlesPrixPivot>(item);
            return articlesPrixPivot;
        }

        public void SaveArticlesPrixPivot()
        {
            unitOfWork.Commit();
        }

        public void UpdateArticlesPrixPivot(ArticlesPrixPivot articlesPrix)
        {
            articlesRepository.Update(Mapper.Map<ArticlesPrixPivot, GES_ArticlesPrix>(articlesPrix));
        }
    }
}
