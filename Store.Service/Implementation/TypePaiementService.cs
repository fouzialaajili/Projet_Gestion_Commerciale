using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Model;

namespace Store.Service
{
    class TypePaiementService : ITypePaiementService
    {
        private readonly ITypePaiementRepositoy tiersContactsRepository;


        private readonly IUnitOfWork unitOfWork;

        public TypePaiementService(ITypePaiementRepositoy tiersContactsRepository, IUnitOfWork unitOfWork)
        {
            this.tiersContactsRepository = tiersContactsRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateTypePaiement(TypePaiementPivot TypePaiement)
        {
            GEN_TypePaiement  item = Mapper.Map<TypePaiementPivot, GEN_TypePaiement>(TypePaiement);
            tiersContactsRepository.Add(item);
        }

        public void DeleteTypePaiement(TypePaiementPivot TypePaiement)
        {
            tiersContactsRepository.Delete(Mapper.Map<TypePaiementPivot, GEN_TypePaiement>(TypePaiement));
        }

        public IEnumerable<TypePaiementPivot> GetALL()
        {
            IEnumerable<GEN_TypePaiement> motif = tiersContactsRepository.GetALL().ToList();
            IEnumerable<TypePaiementPivot> motifPivots = Mapper.Map<IEnumerable<GEN_TypePaiement>, IEnumerable<TypePaiementPivot>>(motif);
            return motifPivots;
        }

        public TypePaiementPivot GetTypePaiement(long id)
        {
            var item = tiersContactsRepository.GetById((int)id);
            TypePaiementPivot  motifPivot = Mapper.Map<GEN_TypePaiement, TypePaiementPivot>(item);
            return motifPivot;
        }

        public void SaveTypePaiement()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<TypePaiementPivot> TypePaiements(string identifged)
        {
            IEnumerable<GEN_TypePaiement> motif = tiersContactsRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TypePaiementPivot> motifsPivots = Mapper.Map<IEnumerable<GEN_TypePaiement>, IEnumerable<TypePaiementPivot>>(motif);
            return motifsPivots;
        }

        public void UpdateTypePaiement(TypePaiementPivot TypePaiement)
        {
            tiersContactsRepository.Update(Mapper.Map<TypePaiementPivot, GEN_TypePaiement>(TypePaiement));
        }
    }
}
