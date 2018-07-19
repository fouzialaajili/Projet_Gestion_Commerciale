using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class NomenclatureRepository : RepositoryBase<GES_Nomenclature>, INomenclatureRepository
    {
        public NomenclatureRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface INomenclatureRepository : IRepository<GES_Nomenclature>
    {

    }
}
