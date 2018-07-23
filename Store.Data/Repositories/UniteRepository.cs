using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
   
    public interface IUniteRepository : IRepository<GES_Unite>
    {
        IEnumerable<GES_Unite> GetALL();
        GES_Unite GetById(long id);
        IEnumerable<GES_Unite> GetItemsByModelLibelle(string identifged);

    }


    public class UniteRepository : RepositoryBase<GES_Unite>, IUniteRepository
    {
        public UniteRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<GES_Unite> GetALL()
        {
            throw new NotImplementedException();
        }

        public GES_Unite GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GES_Unite> GetItemsByModelLibelle(string identifged)
        {
            throw new NotImplementedException();
        }
    }
}
