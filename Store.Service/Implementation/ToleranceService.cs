using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;
using Store.Model;

namespace Store.Service.Implementations
{
    class ToleranceService : IToleranceService
    {
        private readonly IToleranceRepositoy toleranceRepository;


        private readonly IUnitOfWork unitOfWork;

        public ToleranceService(IToleranceRepositoy toleranceRepository, IUnitOfWork unitOfWork)
        {
            this.toleranceRepository = toleranceRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateTolerances(TolerancePivot Tolerances)
        {
            GES_Tolerance item = Mapper.Map<TolerancePivot, GES_Tolerance>(Tolerances);
            toleranceRepository.Add(item);
        }

        public void DeleteTolerances(TolerancePivot Tolerances)
        {
            toleranceRepository.Delete(Mapper.Map<TolerancePivot, GES_Tolerance>(Tolerances));
        }

        public IEnumerable<TolerancePivot> GetALL()
        {
            IEnumerable<GES_Tolerance> motif = toleranceRepository.GetALL().ToList();
            IEnumerable<TolerancePivot> motifPivots = Mapper.Map<IEnumerable<GES_Tolerance>, IEnumerable<TolerancePivot>>(motif);
            return motifPivots;
        }

        public TolerancePivot GetTolerances(long id)
        {
            var item =toleranceRepository.GetById((int)id);
            TolerancePivot motifPivot = Mapper.Map<GES_Tolerance, TolerancePivot>(item);
            return motifPivot;
        }

        public void SaveTolerances()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<TolerancePivot> Tolerances(string identifged)
        {
            IEnumerable<GES_Tolerance> motif = toleranceRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TolerancePivot> motifsPivots = Mapper.Map<IEnumerable<GES_Tolerance>, IEnumerable<TolerancePivot>>(motif);
            return motifsPivots;
        }

        public void UpdateTolerances(TolerancePivot Tolerances)
        {
            toleranceRepository.Update(Mapper.Map<TolerancePivot, GES_Tolerance>(Tolerances));
        }
    }
}
