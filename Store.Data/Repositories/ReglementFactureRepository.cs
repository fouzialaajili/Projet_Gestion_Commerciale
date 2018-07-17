using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ReglementFactureRepository : RepositoryBase<ReglementFacture>, IReglementFactureRepository
    {
        public ReglementFactureRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IReglementFactureRepository : IRepository<ReglementFacture>
    {

    }
}
