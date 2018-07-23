using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class OpportuniteRepository : RepositoryBase<GES_Opportunite>, IOpportuniteRepository
    {
        public OpportuniteRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Opportunite> GetALL()
        {
            return this.DbContext.Opportunites.ToList();
        }

        public GES_Opportunite GetById(long id)
        {
            var opportunites = this.DbContext.Opportunites.Where(c => c.OpportuniteId == id).SingleOrDefault();

            return opportunites;
        }

        public IEnumerable<GES_Opportunite> GetItemsByModelLibelle(string identifged)
        {
            var numerotations = this.DbContext.Opportunites.Where(c => c.OpportuniteLibelle == identifged);

            return numerotations;
        }
    }

    public interface IOpportuniteRepository : IRepository<GES_Opportunite>
    {

        IEnumerable<GES_Opportunite> GetALL();
        GES_Opportunite GetById(long id);
       IEnumerable<GES_Opportunite> GetItemsByModelLibelle(string identifged);
    }
}
