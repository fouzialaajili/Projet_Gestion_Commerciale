using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Store.Data.Repositories
{
    class TiersContactRepository:RepositoryBase<GEN_TiersContacts>, ITiersContactRepository
    {
        public TiersContactRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GEN_TiersContacts> GetALL()
        {
            return this.DbContext.TiersContacts.ToList();
        }

        public GEN_TiersContacts GetById(long id)
        {
            var objetifs = this.DbContext.TiersContacts.Where(c => c.GEN_TiersContactsId == id).SingleOrDefault();

            return objetifs;
        }

       

        IEnumerable<GEN_TiersContacts> ITiersContactRepository.GetItemsByModelLibelle(string identifged)
        {
            var objetifs = this.DbContext.TiersContacts.Where(c => c.Nom == identifged);

            return objetifs;
        }
    }
 
    public interface ITiersContactRepository : IRepository<GEN_TiersContacts>
    {
        IEnumerable<GEN_TiersContacts> GetALL();
        GEN_TiersContacts GetById(long id);
        IEnumerable<GEN_TiersContacts> GetItemsByModelLibelle(string identifged);
    }
}
