using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositoriess
{
    class PeriodeRepository : RepositoryBase<GES_Periode>, IPeriodeRepository
    {
        public PeriodeRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Periode> GetALL()
        {
            return this.DbContext.Periodes.ToList();
        }

        public GES_Periode GetById(long id)
        {
            var peroides = this.DbContext.Periodes.Where(c => c.PeriodeId == id).SingleOrDefault();

            return peroides;
        }

        public IEnumerable<GES_Periode> GetItemsByModelLibelle(string identifged)
        {
            var Periodes = this.DbContext.Periodes.Where(c => c.PeriodeLibelle == identifged);

            return Periodes;
        }
    }

    public interface IPeriodeRepository : IRepository<GES_Periode>
    {
        IEnumerable<GES_Periode> GetALL();
        GES_Periode GetById(long id);
      IEnumerable<GES_Periode> GetItemsByModelLibelle(string identifged);
    }
}
