using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class DossiersContactsRepository : RepositoryBase<GEN_DossiersContacts>, IDossiersContactsRepository
    {
        public DossiersContactsRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IDossiersContactsRepository : IRepository<GEN_DossiersContacts>
    {

    }
}
