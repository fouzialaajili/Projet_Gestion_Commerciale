using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public interface IArticlesPrixRepository : IRepository<GES_ArticlesPrix>
    {

    }


    public class ArticlesPrixRepository : RepositoryBase<GES_ArticlesPrix>, IArticlesPrixRepository
    {
        public ArticlesPrixRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }
    
}
