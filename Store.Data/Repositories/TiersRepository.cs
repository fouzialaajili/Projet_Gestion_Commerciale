using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class TiersRepository:RepositoryBase<GEN_Tiers>, IFichetierRepository
    {
        public TiersRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GEN_Tiers> GetALL()
        {
            throw new NotImplementedException();
        }

        public GEN_Tiers GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GEN_Tiers> GetItemsByModelLibelle(string identifged)
        {
            throw new NotImplementedException();
        }
    }
    public interface IFichetierRepository : IRepository<GEN_Tiers>
    {
        IEnumerable<GEN_Tiers> GetALL();
        GEN_Tiers GetById(long id);
        IEnumerable<GEN_Tiers> GetItemsByModelLibelle(string identifged);

    }
}
