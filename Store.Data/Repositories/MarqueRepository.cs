using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   
    public interface IMarqueRepository : IRepository<Marque>
    {

    }


    public class MarqueRepositoy : RepositoryBase<Marque>, IMarqueRepository
    {
        public MarqueRepositoy(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
