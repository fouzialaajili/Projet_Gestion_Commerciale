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
    class TiersContactRepository:RepositoryBase<GEN_TiersContacts>, IFichierContactRepository
    {
        public TiersContactRepository(IDbFactory dbFactory)
            : base(dbFactory) { }


    }
 
    public interface IFichierContactRepository : IRepository<GEN_TiersContacts>
    {
       
    }
}
