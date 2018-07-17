using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ProfilRepository : RepositoryBase<Profil>, IProfilRepository
    {
        public ProfilRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IProfilRepository : IRepository<Profil>
    {

    }
}

