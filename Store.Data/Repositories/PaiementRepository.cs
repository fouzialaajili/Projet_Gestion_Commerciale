using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class PaiementRepository : RepositoryBase<GEN_TypePaiement>, IPaiementRepository
    {
        public PaiementRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IPaiementRepository : IRepository<GEN_TypePaiement>
    {

    }
}
