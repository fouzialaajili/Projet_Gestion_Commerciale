﻿using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class FournisseurArticleRepository : RepositoryBase<GES_FournisseurArticle>, IFournisseurArticleRepository
    {
        public FournisseurArticleRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_FournisseurArticle> GetALL()
        {
            return this.DbContext.FournisseurArticles.ToList();
        }

        public IEnumerable<GES_FournisseurArticle> GetItemsByModelLibelle(string categoryName)
        {
            var fournisseurArticles = this.DbContext.FournisseurArticles.Where(c => c.FournisseurArticleReference == ReferenceName);

            return fournisseurArticles;
        }
     
    }

    public interface IFournisseurArticleRepository : IRepository<GES_FournisseurArticle>
    {
        IEnumerable<GES_FournisseurArticle> GetItemsByModelLibelle(string categoryName);
        IEnumerable<GES_FournisseurArticle> GetALL();

    }
}
