using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    
    public interface IImpressionRepositoy : IRepository<GES_Impression>
    {

    }


    public class ImpressionRepositoy : RepositoryBase<GES_Impression>, IImpressionRepositoy
    {
        public ImpressionRepositoy(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
