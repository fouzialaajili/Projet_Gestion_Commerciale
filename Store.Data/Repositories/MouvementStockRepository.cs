using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class MouvementStockRepository : RepositoryBase<GES_MouvementStock>, IMouvementStockRepository
    {
        public MouvementStockRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_MouvementStock> GetALL()
        {
            return this.DbContext.MouvementStocks.ToList();
        }

        public GES_MouvementStock GetById(long id)
        {
            var mouvementstocks = this.DbContext.MouvementStocks.Where(c => c.MouvementStockId== id).SingleOrDefault();

            return mouvementstocks;
        }

        public IEnumerable<GES_MouvementStock> GetItemsByModelLibelle(string identifged)
        {
            var mouvementstocks = this.DbContext.MouvementStocks.Where(c => c.MouvementStockCode == identifged);

            return mouvementstocks;
        }
    }

    public interface IMouvementStockRepository : IRepository<GES_MouvementStock>
    {
        IEnumerable<GES_MouvementStock> GetALL();
        GES_MouvementStock GetById(long id);
        IEnumerable<GES_MouvementStock> GetItemsByModelLibelle(string identifged);

    }
}
