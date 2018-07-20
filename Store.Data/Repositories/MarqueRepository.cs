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
        IEnumerable<GES_Marque> GetALL();
        GES_Marque  GetById(long id);
        IEnumerable<GES_Marque> GetItemsByModelLibelle(string identifged);
    }


    public class MarqueRepositoy : RepositoryBase<GES_Marque>, IMarqueRepository
    {
        public MarqueRepositoy(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<GES_Marque> GetALL()
        {
            return this.DbContext.Marques.ToList();
        }

        public GES_Marque GetById(long id)
        {
            var marques = this.DbContext.Marques.Where(c => c.MarqueId == id).SingleOrDefault();

            return marques;
        }

        public IEnumerable<GES_Marque> GetItemsByModelLibelle(string identifged)
        {
            var marques = this.DbContext.Marques.Where(c => c.MarqueCode == identifged);

            return marques;
        }
    }
}
