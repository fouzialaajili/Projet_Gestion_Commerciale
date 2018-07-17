using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class MotifTicketRepository : RepositoryBase<MotifTicket>, IMotifTicketRepository
    {
        public MotifTicketRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IMotifTicketRepository : IRepository<MotifTicket>
    {

    }
}

