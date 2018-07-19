using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
  
    public interface ILicenceRepository : IRepository<GES_Licence>
    {

    }


    public class LicenceRepositoy : RepositoryBase<GES_Licence>, ILicenceRepository
    {
        public LicenceRepositoy(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
