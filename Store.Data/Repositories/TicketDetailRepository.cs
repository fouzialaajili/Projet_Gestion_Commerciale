using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class TicketDetailRepository : RepositoryBase<GES_TicketDetail>, ITicketDetailRepository
    {
        public TicketDetailRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_TicketDetail> GetALL()
        {

            return this.DbContext.TicketDetails.ToList();
        }

        public GES_TicketDetail GetById(long id)
        {
            var objetifs = this.DbContext.TicketDetails.Where(c => c.TicketDetailId == id).SingleOrDefault();

            return objetifs;
        }

        public IEnumerable<GES_TicketDetail> GetItemsByModelLibelle(string identifged)
        {
            var objetifs = this.DbContext.TicketDetails.Where(c => c.TicketDetailDescription == identifged);

            return objetifs;
        }
    }

    public interface ITicketDetailRepository : IRepository<GES_TicketDetail>
    {
        IEnumerable<GES_TicketDetail> GetALL();
        GES_TicketDetail GetById(long id);
        IEnumerable<GES_TicketDetail> GetItemsByModelLibelle(string identifged);
    }
}
