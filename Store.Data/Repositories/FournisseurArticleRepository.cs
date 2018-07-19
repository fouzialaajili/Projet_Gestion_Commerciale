using Store.Data.Infrastructure;
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
    }

    public interface IFournisseurArticleRepository : IRepository<GES_FournisseurArticle>
    {

    }
}
