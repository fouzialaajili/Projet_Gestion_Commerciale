using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   
    public interface IToleranceRepositoy : IRepository<GES_Tolerance>
    {

    }


    public class ToleranceRepositoy : RepositoryBase<GES_Tolerance>, IToleranceRepositoy
    {
        public ToleranceRepositoy(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
