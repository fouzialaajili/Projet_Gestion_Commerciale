using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class DossiersRepository : RepositoryBase<GEN_Dossiers>, IDossiersRepository
    {
        public DossiersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IDossiersRepository : IRepository<GEN_Dossiers>
    {

    }
}
