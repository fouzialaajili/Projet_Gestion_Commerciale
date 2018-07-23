using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ReglementFactureRepository : RepositoryBase<GES_ReglementFacture>, IReglementFactureRepository
    {
        public ReglementFactureRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_ReglementFacture> GetALL()
        {
            return this.DbContext.ReglementFactures.ToList();
        }

        public GES_ReglementFacture GetById(long id)
        {
            var impressions = this.DbContext.ReglementFactures.Where(c => c.ReglementFactureId == id).SingleOrDefault();

            return impressions;
        }

        public IEnumerable<GES_ReglementFacture> GetItemsByModelLibelle(string identifged)
        {
            throw new NotImplementedException();
        }
    }

    public interface IReglementFactureRepository : IRepository<GES_ReglementFacture>
    {
        IEnumerable<GES_ReglementFacture> GetALL();
        GES_ReglementFacture GetById(long id);
        IEnumerable<GES_ReglementFacture> GetItemsByModelLibelle(string identifged);
    }
}
