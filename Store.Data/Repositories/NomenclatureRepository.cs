using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class NomenclatureRepository : RepositoryBase<GES_Nomenclature>, INomenclatureRepository
    {
        public NomenclatureRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<GES_Nomenclature> GetALL()
        {
            return this.DbContext.Nomenclatures.ToList();
        }

        public GES_Nomenclature GetById(long id)
        {
            var nomenclatures = this.DbContext.Nomenclatures.Where(c => c.NomenclatureId== id).SingleOrDefault();

            return nomenclatures;
        }

        public IEnumerable<GES_Nomenclature> GetItemsByModelLibelle(string identifged)
        {
            var nomenclatures = this.DbContext.Nomenclatures.Where(c => c.NomenclatureLib == identifged);

            return nomenclatures;
        }
    }

    public interface INomenclatureRepository : IRepository<GES_Nomenclature>
    {
        IEnumerable<GES_Nomenclature> GetALL();
        GES_Nomenclature GetById(long id);
        IEnumerable<GES_Nomenclature> GetItemsByModelLibelle(string identifged);

    }
}
