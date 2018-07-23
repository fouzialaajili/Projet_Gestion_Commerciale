using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class ReglementRepository : RepositoryBase<GES_Reglement>, IReglementRepository
    {
        public ReglementRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Reglement> GetALL()
        {
            return this.DbContext.Reglements.ToList();
        }

        public GES_Reglement GetById(long id)
        {

            var peroides = this.DbContext.Reglements.Where(c => c.ReglementId == id).SingleOrDefault();

            return peroides;
        }

        public IEnumerable<GES_Reglement> GetItemsByModelLibelle(string identifged)
        {
            var Periodes = this.DbContext.Reglements.Where(c => c.ReglementLibelle== identifged);

            return Periodes;
        }
    }

    public interface IReglementRepository : IRepository<GES_Reglement>
    {
        IEnumerable<GES_Reglement> GetALL();
        GES_Reglement GetById(long id);
        IEnumerable<GES_Reglement> GetItemsByModelLibelle(string identifged);

    }
}
