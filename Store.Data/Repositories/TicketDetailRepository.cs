using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class TicketDetailRepository : RepositoryBase<TicketDetail>, ITicketDetailRepository
    {
        public TicketDetailRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface ITicketDetailRepository : IRepository<TicketDetail>
    {

    }
}
