using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   
    public interface IUniteRepository : IRepository<GES_Unite>
    {

    }


    public class UniteRepository : RepositoryBase<GES_Unite>, IUniteRepository
    {
        public UniteRepository(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
