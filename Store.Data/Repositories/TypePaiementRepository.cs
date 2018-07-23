using Store.Data.Infrastructure;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Repositories
{
    class TypePaiementRepository : RepositoryBase<GEN_TypePaiement>, ITypePaiementRepositoy
    {
        public TypePaiementRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<GEN_TypePaiement> GetALL()
        {
            throw new NotImplementedException();
        }

        public GEN_TypePaiement GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GEN_TypePaiement> GetItemsByModelLibelle(string identifged)
        {
            throw new NotImplementedException();
        }
    }



    public interface ITypePaiementRepositoy : IRepository<GEN_TypePaiement>
    {
        IEnumerable<GEN_TypePaiement> GetALL();
        GEN_TypePaiement GetById(long id);
        IEnumerable<GEN_TypePaiement> GetItemsByModelLibelle(string identifged);

    }


}