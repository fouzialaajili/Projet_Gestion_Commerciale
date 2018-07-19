using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   

    public interface IFamilleRepositoy : IRepository<GES_Famille>
    {

    }


    public class FamilleRepositoy : RepositoryBase<GES_Famille>, IFamilleRepositoy
    {
        public FamilleRepositoy(IDbFactory dbFactory) : base(dbFactory) { }


    }
}
