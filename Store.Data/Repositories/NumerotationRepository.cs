using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class NumerotationRepository : RepositoryBase<Numerotation>, INumerotationRepository
    {
        public NumerotationRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface INumerotationRepository : IRepository<Numerotation>
    {

    }
}
