using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class SocieteRepository : RepositoryBase<Societe>, ISocieteRepository
    {
        public SocieteRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ISocieteRepository : IRepository<Societe>
    {

    }
}
