using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ObjectifRepository : RepositoryBase<GES_Objectif>, IObjectifRepository
    {
        public ObjectifRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Objectif> GetALL()
        {
            return this.DbContext.Objectifs.ToList();
        }

        public GES_Objectif GetById(long id)
        {
            var objetifs = this.DbContext.Objectifs.Where(c => c.ObjectifId== id).SingleOrDefault();

            return objetifs;
        }

    /*  public IEnumerable<GES_Objectif> GetItemsByModelLibelle(string identifged)
        {

            var numerotations = this.DbContext.Objectifs.Where(c => c.ObjectifRepresentant == identifged);

            return numerotations;
        }*/
    }

    public interface IObjectifRepository : IRepository<GES_Objectif>
    {
        IEnumerable<GES_Objectif> GetALL();
        GES_Objectif GetById(long id);
  //IEnumerable<GES_Objectif> GetItemsByModelLibelle(string identifged);

    }
}
