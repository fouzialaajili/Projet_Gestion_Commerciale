using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   public  class DevisesRepository: RepositoryBase<GEN_Devises>, IDevisesRepository
    {
        public DevisesRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }
    public interface IDevisesRepository : IRepository<GEN_Devises>
    {

    }


    
    
}
