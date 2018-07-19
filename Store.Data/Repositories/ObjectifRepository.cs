using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ObjectifRepository : RepositoryBase<GES_Objectif>, IObjectifRepository
    {
        public ObjectifRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IObjectifRepository : IRepository<GES_Objectif>
    {

    }
}
