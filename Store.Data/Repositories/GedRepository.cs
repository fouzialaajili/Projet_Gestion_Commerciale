using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class GedRepository : RepositoryBase<Ged>, IGedRepository
    {
        public GedRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IGedRepository : IRepository<Ged>
    {

    }
}
