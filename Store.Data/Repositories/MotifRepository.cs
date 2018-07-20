using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class MotifRepository : RepositoryBase<GES_Motif>, IMotifRepository
    {
        public MotifRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Motif> GetALL()
        {
            return this.DbContext.Motifs.ToList();
        }

        public GES_Motif GetById(long id)
        {
            var motifs = this.DbContext.Motifs.Where(c => c.MotifId == id).SingleOrDefault();

            return motifs;
        }

        public IEnumerable<GES_Motif> GetItemsByModelLibelle(string identifged)
        {
            var motifs = this.DbContext.Motifs.Where(c => c.MotifDescription == identifged);

            return motifs;
        }
    }

    public interface IMotifRepository : IRepository<GES_Motif>
    {
        IEnumerable<GES_Motif> GetALL();
        GES_Motif GetById(long id);
        IEnumerable<GES_Motif> GetItemsByModelLibelle(string identifged);

    }
}

