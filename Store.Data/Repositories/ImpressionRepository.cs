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
        IEnumerable<GES_Impression> GetALL();
        GES_Impression GetById(long id);
        IEnumerable<GES_Impression> GetItemsByModelLibelle(string identifged);
    }


    public class ImpressionRepositoy : RepositoryBase<GES_Impression>, IImpressionRepositoy
    {

        public ImpressionRepositoy(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Impression> GetALL()
        {
            return this.DbContext.Impressions.ToList();

        }

        public GES_Impression GetById(long id)
        {
            var impressions = this.DbContext.Impressions.Where(c => c.ImpressionId == id).SingleOrDefault();

            return impressions;
        }

        public IEnumerable<GES_Impression> GetItemsByModelLibelle(string identifged)
        {
            var impressions = this.DbContext.Impressions.Where(c => c.ImpressionChemin == identifged);

            return impressions;
        }
    }
}
