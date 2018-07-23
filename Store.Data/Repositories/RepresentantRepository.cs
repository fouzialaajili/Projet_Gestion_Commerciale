using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class RepresentantRepository : RepositoryBase<GES_Representant>, IRepresentantRepository
    {
        public RepresentantRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Representant> GetALL()
        {
            return this.DbContext.Representants.ToList();
        }

        public GES_Representant GetById(long id)
        {
            var objetifs = this.DbContext.Representants.Where(c => c.RepresentantId== id).SingleOrDefault();

            return objetifs;
        }

        public IEnumerable<GES_Representant> GetItemsByModelLibelle(string identifged)
        {
            var numerotations = this.DbContext.Representants.Where(c => c.RepresentantNom == identifged);

            return numerotations;
        }
    }

    public interface IRepresentantRepository : IRepository<GES_Representant>
    {
        IEnumerable<GES_Representant> GetALL();
        GES_Representant GetById(long id);
      IEnumerable<GES_Representant> GetItemsByModelLibelle(string identifged);
    }
}
