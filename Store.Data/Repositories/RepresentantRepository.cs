using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class RepresentantRepository : RepositoryBase<GES_Representant>, IRepresentantRepository
    {
        public RepresentantRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IRepresentantRepository : IRepository<GES_Representant>
    {

    }
}
