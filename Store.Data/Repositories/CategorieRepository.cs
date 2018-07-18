using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public interface ICategorieRepository : IRepository<GES_Categorie>
    {

    }


    public class CategorieRepository : RepositoryBase<GES_Categorie>, ICategorieRepository
    {
        public CategorieRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
