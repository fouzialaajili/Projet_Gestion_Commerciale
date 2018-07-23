using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class NumerotationRepository : RepositoryBase<GES_Numerotation>, INumerotationRepository
    {
        public NumerotationRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Numerotation> GetALL()
        {
            return this.DbContext.Numeratations.ToList();
        }

        public GES_Numerotation GetById(long id)
        {
            var numerotations = this.DbContext.Numeratations.Where(c => c.NumerotationId == id).SingleOrDefault();

            return numerotations;
        }

        public IEnumerable<GES_Numerotation> GetItemsByModelLibelle(string identifged)
        {
            var numerotations = this.DbContext.Numeratations.Where(c => c.NumerotationValeur== identifged);

            return numerotations;
        }
    }

    public interface INumerotationRepository : IRepository<GES_Numerotation>
    {

        IEnumerable<GES_Numerotation> GetALL();
        GES_Numerotation GetById(long id);
        IEnumerable<GES_Numerotation> GetItemsByModelLibelle(string identifged);
    }
}
