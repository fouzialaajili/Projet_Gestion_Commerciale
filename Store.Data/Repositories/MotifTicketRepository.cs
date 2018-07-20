using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class MotifTicketRepository : RepositoryBase<GES_MotifTicket>, IMotifTicketRepository
    {
        public MotifTicketRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_MotifTicket> GetALL()
        {

            return this.DbContext.MotifTickets.ToList();
        }

        public GES_MotifTicket GetById(long id)
        {
            var motifs = this.DbContext.MotifTickets.Where(c => c.MotifTicketId == id).SingleOrDefault();

            return motifs;
        }

        public IEnumerable<GES_MotifTicket> GetItemsByModelLibelle(string identifged)
        {
            var motifs = this.DbContext.MotifTickets.Where(c => c.MotifTicketDescription == identifged);

            return motifs;
        }
    }

    public interface IMotifTicketRepository : IRepository<GES_MotifTicket>
    {
        IEnumerable<GES_MotifTicket> GetALL();
        GES_MotifTicket GetById(long id);
        IEnumerable<GES_MotifTicket> GetItemsByModelLibelle(string identifged);

    }
}

