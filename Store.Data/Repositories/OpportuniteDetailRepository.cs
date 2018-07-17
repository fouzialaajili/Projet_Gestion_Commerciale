using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class OpportuniteDetailRepository : RepositoryBase<OpportuniteDetail>, IOpportuniteDetailRepository
    {
        public OpportuniteDetailRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IOpportuniteDetailRepository : IRepository<OpportuniteDetail>
    {

    }
}
