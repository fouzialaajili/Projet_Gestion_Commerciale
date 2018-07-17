using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class FichetierRepository:RepositoryBase<Fichetier>, IFichetierRepository
    {
        public FichetierRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
}
    public interface IFichetierRepository : IRepository<Fichetier>
    {

    }
}
