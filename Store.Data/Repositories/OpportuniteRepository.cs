using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class OpportuniteRepository : RepositoryBase<GES_Opportunite>, IOpportuniteRepository
    {
        public OpportuniteRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IOpportuniteRepository : IRepository<GES_Opportunite>
    {

    }
}
