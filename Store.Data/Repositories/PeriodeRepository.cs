using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositoriess
{
    class PeriodeRepository : RepositoryBase<Periode>, IPeriodeRepository
    {
        public PeriodeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IPeriodeRepository : IRepository<Periode>
    {

    }
}
