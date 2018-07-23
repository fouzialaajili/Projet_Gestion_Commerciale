using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Model;
using AutoMapper;

namespace Store.Service.Implementation
{
    class NomenclatureService : INomenclatureService
    {
        private readonly INomenclatureRepository nomenclatureRepository;


        private readonly IUnitOfWork unitOfWork;

        public NomenclatureService(INomenclatureRepository nomenclatureRepository, IUnitOfWork unitOfWork)
        {
            this.nomenclatureRepository = nomenclatureRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateNomenclature(NomenclaturePivot nomenclature)
        {
             GES_Nomenclature  item = Mapper.Map<NomenclaturePivot, GES_Nomenclature>(nomenclature);
            nomenclatureRepository.Add(item);
        }

        public void DeleteNomenclature(NomenclaturePivot nomenclature)
        {
            nomenclatureRepository.Delete(Mapper.Map<NomenclaturePivot, GES_Nomenclature>(nomenclature));
        }

        public IEnumerable<NomenclaturePivot> GetALL()
        {
            IEnumerable<GES_Nomenclature> nomenclature = nomenclatureRepository.GetALL().ToList();
            IEnumerable<NomenclaturePivot> nomenclaturePivots = Mapper.Map<IEnumerable<GES_Nomenclature>, IEnumerable<NomenclaturePivot>>(nomenclature);
            return nomenclaturePivots;
        }

        public NomenclaturePivot GetNomenclatures(long id)
        {
            var item = nomenclatureRepository.GetById((int)id);
            NomenclaturePivot nomenclaturePivot = Mapper.Map<GES_Nomenclature, NomenclaturePivot>(item);
            return nomenclaturePivot;
        }

        public IEnumerable<NomenclaturePivot> Nomenclatures(string identifged)
        {
            IEnumerable<GES_Nomenclature> motif = nomenclatureRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<NomenclaturePivot> motifsPivots = Mapper.Map<IEnumerable<GES_Nomenclature>, IEnumerable<NomenclaturePivot>>(motif);
            return motifsPivots;
        }

        public void SaveMotif()
        {
            unitOfWork.Commit();
        }

        public void UpdateNomenclature(NomenclaturePivot nomenclature)
        {
            nomenclatureRepository.Update(Mapper.Map<NomenclaturePivot, GES_Nomenclature>(nomenclature));
        }
    }
}
