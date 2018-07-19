using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    public interface IAdminRepository: IRepository<GES_Admin>
    {

    }



   public class AdminRepository : RepositoryBase<GES_Admin>, IAdminRepository
    {
        public AdminRepository(IDbFactory dbFactory):base(dbFactory) { }

        
    }

  
   
}
