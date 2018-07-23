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
    class ParametrageComptableService : IParametrageComptableService
    {
        private readonly ICPT_ParametrageComptableRepository parametrageComptableRepository;


        private readonly IUnitOfWork unitOfWork;

        public ParametrageComptableService(ICPT_ParametrageComptableRepository parametrageComptableRepository, IUnitOfWork unitOfWork)
        {
            this.parametrageComptableRepository = parametrageComptableRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateParametrageComptable(ParametrageComptablePivot ParametrageComptable)
        {

            CPT_ParametrageComptable item = Mapper.Map<ParametrageComptablePivot, CPT_ParametrageComptable>(ParametrageComptable);
            parametrageComptableRepository.Add(item);
        }

        public void DeleteParametrageComptable(ParametrageComptablePivot ParametrageComptable)
        {
            parametrageComptableRepository.Delete(Mapper.Map<ParametrageComptablePivot, CPT_ParametrageComptable>(ParametrageComptable));
        }

        public IEnumerable<ParametrageComptablePivot> GetALL()
        {
            IEnumerable<CPT_ParametrageComptable> ParametrageComptable = parametrageComptableRepository.GetALL().ToList();
            IEnumerable<ParametrageComptablePivot> ParametrageComptablePivots = Mapper.Map<IEnumerable<CPT_ParametrageComptable>, IEnumerable<ParametrageComptablePivot>>(ParametrageComptable);
            return ParametrageComptablePivots;
        }

        public ParametrageComptablePivot GetParametrageComptable(long id)
        {
            var item = parametrageComptableRepository.GetById((int)id);
          ParametrageComptablePivot ParametrageComptablePivot = Mapper.Map<CPT_ParametrageComptable, ParametrageComptablePivot>(item);
            return ParametrageComptablePivot;
        }

        public IEnumerable<ParametrageComptablePivot> ParametrageComptables(string identifged)
        {

            IEnumerable<CPT_ParametrageComptable> ParametrageComptable = parametrageComptableRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<ParametrageComptablePivot> ParametrageComptablePivots = Mapper.Map<IEnumerable<CPT_ParametrageComptable>, IEnumerable<ParametrageComptablePivot>>(ParametrageComptable);
            return ParametrageComptablePivots;
        }

        public void SaveParametrageComptable()
        {
            unitOfWork.Commit();
        }

        public void UpdateParametrageComptable(ParametrageComptablePivot ParametrageComptable)
        {
            parametrageComptableRepository.Update(Mapper.Map<ParametrageComptablePivot, CPT_ParametrageComptable>(ParametrageComptable));
        }
    }
}
