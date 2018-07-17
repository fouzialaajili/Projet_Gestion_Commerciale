using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class MotifRepository : RepositoryBase<Motif>, IMotifRepository
    {
        public MotifRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IMotifRepository : IRepository<Motif>
    {

    }
}

