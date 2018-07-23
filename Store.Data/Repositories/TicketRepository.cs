using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class TicketRepository : RepositoryBase<GEN_TiersContact>, ITicketRepository
    {
        public TicketRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GEN_TiersContact> GetALL()
        {
            return this.DbContext.Tickets.ToList();
        }

        public GEN_TiersContact GetById(long id)
        {
            var objetifs = this.DbContext.Tickets.Where(c => c.TicketId== id).SingleOrDefault();

            return objetifs;
        }

        public IEnumerable<GEN_TiersContact> GetItemsByModelLibelle(string identifged)
        {
            var objetifs = this.DbContext.Tickets.Where(c => c.TicketStatut == identifged);

            return objetifs;
        }
    }

    public interface ITicketRepository : IRepository<GEN_TiersContact>
    {
        IEnumerable<GEN_TiersContact> GetALL();
        GEN_TiersContact GetById(long id);
        IEnumerable<GEN_TiersContact> GetItemsByModelLibelle(string identifged);
    }
}
