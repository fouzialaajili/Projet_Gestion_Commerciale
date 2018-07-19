using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class CPT_ParametrageComptableRepository : RepositoryBase<CPT_ParametrageComptable>, ICPT_ParametrageComptableRepository
    {
        public CPT_ParametrageComptableRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ICPT_ParametrageComptableRepository : IRepository<CPT_ParametrageComptable>
    {

    }
}
