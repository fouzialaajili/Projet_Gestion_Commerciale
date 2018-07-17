using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ParametrageRepository : RepositoryBase<Parametrage>, IParametrageRepository
    {
        public ParametrageRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IParametrageRepository : IRepository<Parametrage>
    {

    }
}

