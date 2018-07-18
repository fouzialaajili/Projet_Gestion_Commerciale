using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public interface IArticleRepository: IRepository<GES_Article>
    {

    }


    public class ArticleRepository: RepositoryBase<GES_Article>, IArticleRepository
    {
        public ArticleRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }


   

    


    
}
