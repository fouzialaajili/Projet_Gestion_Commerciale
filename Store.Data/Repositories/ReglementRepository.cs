using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ReglementRepository : RepositoryBase<Reglement>, IReglementRepository
    {
        public ReglementRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IReglementRepository : IRepository<Reglement>
    {

    }
}
