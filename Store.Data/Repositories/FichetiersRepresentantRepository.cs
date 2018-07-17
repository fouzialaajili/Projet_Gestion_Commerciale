using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class FichetiersRepresentantRepository:RepositoryBase<FichetiersRepresentant>, IFichetiersRepresentantRepository
    {
        public FichetiersRepresentantRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IFichetiersRepresentantRepository : IRepository<FichetiersRepresentant>
    {

    }
}
