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
        IEnumerable<GES_Tolerance> GetALL();
        GES_Tolerance GetById(long id);
        IEnumerable<GES_Tolerance> GetItemsByModelLibelle(string identifged);

    }


    public class ToleranceRepositoy : RepositoryBase<GES_Tolerance>, IToleranceRepositoy
    {
        public ToleranceRepositoy(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<GES_Tolerance> GetALL()
        {
            throw new NotImplementedException();
        }

        public GES_Tolerance GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GES_Tolerance> GetItemsByModelLibelle(string identifged)
        {
            throw new NotImplementedException();
        }
    }
}
