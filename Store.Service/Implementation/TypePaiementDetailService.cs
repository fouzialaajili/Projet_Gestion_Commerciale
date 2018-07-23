using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Model;
using AutoMapper;

namespace Store.Service
{
    class TypePaiementDetailService : ITypePaiementDetailService
    {
        private readonly ITypePaiementDetailRepositoy tiersContactsRepository;


        private readonly IUnitOfWork unitOfWork;

        public TypePaiementDetailService(ITypePaiementDetailRepositoy tiersContactsRepository, IUnitOfWork unitOfWork)
        {
            this.tiersContactsRepository = tiersContactsRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateTypePaiementDetail(TypePaiementDetailPivot TypePaiementDetail)
        {
            GEN_TypePaiementDetail item = Mapper.Map<TypePaiementDetailPivot, GEN_TypePaiementDetail>(TypePaiementDetail);
            tiersContactsRepository.Add(item);
        }

        public void DeleteTypePaiementDetail(TypePaiementDetailPivot TypePaiementDetail)
        {

            tiersContactsRepository.Delete(Mapper.Map<TypePaiementDetailPivot, GEN_TypePaiementDetail>(TypePaiementDetail));
        }

        public IEnumerable<TypePaiementDetailPivot> GetALL()
        {
            IEnumerable<GEN_TypePaiementDetail> motif = tiersContactsRepository.GetALL().ToList();
            IEnumerable<TypePaiementDetailPivot> motifPivots = Mapper.Map<IEnumerable<GEN_TypePaiementDetail>, IEnumerable<TypePaiementDetailPivot>>(motif);
            return motifPivots;
        }

        public TypePaiementDetailPivot GetTypePaiementDetails(long id)
        {
            var item = tiersContactsRepository.GetById((int)id);
            TypePaiementDetailPivot  motifPivot = Mapper.Map<GEN_TypePaiementDetail, TypePaiementDetailPivot>(item);
            return motifPivot;
        }

        public void SaveTypePaiementDetail()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<TypePaiementDetailPivot> TypePaiementDetails(string identifged)
        {
          

            IEnumerable<GEN_TypePaiementDetail> motif = tiersContactsRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TypePaiementDetailPivot> motifsPivots = Mapper.Map<IEnumerable<GEN_TypePaiementDetail>, IEnumerable<TypePaiementDetailPivot>>(motif);
            return motifsPivots;
        }

        public void UpdateTypePaiementDetail(TypePaiementDetailPivot TypePaiementDetail)
        {
            tiersContactsRepository.Update(Mapper.Map<TypePaiementDetailPivot, GEN_TypePaiementDetail>(TypePaiementDetail));
        }
    }
}
