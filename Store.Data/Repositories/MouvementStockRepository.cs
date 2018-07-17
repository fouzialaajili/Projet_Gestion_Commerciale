using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class MouvementStockRepository : RepositoryBase<MouvementStock>, IMouvementStockRepository
    {
        public MouvementStockRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IMouvementStockRepository : IRepository<MouvementStock>
    {

    }
}
