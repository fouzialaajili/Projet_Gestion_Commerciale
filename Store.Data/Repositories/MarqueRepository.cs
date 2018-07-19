using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   
    public interface IMarqueRepository : IRepository<GES_Marque>
    {

    }


    public class MarqueRepositoy : RepositoryBase<GES_Marque>, IMarqueRepository
    {
        public MarqueRepositoy(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
