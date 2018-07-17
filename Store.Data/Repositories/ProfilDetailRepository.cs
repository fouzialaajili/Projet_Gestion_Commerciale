using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ProfilDetailRepository : RepositoryBase<ProfilDetail>, IProfilDetailRepository
    {
        public ProfilDetailRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IProfilDetailRepository : IRepository<ProfilDetail>
    {

    }
}
