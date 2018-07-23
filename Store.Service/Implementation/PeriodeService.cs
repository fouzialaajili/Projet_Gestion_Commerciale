using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Service.Pivot;
using Store.Data.Repositoriess;
using Store.Data.Infrastructure;
using Store.Model;
using AutoMapper;

namespace Store.Service.Implementation
{
    class PeriodeService : IPeriodeService
    {
        private readonly IPeriodeRepository periodeRepository;


        private readonly IUnitOfWork unitOfWork;

        public PeriodeService(IPeriodeRepository periodeRepository, IUnitOfWork unitOfWork)
        {
            this.periodeRepository = periodeRepository;
            this.unitOfWork = unitOfWork;
        }



        public void CreatePeriodes(PeriodePivot Periodes)
        {
            GES_Periode item = Mapper.Map<PeriodePivot, GES_Periode>(Periodes);
            periodeRepository.Add(item);
        }

        public void DeletePeriode(PeriodePivot Periodes)
        {
           periodeRepository.Delete(Mapper.Map<PeriodePivot, GES_Periode>(Periodes));
        }

        public IEnumerable<PeriodePivot> GetALL()
        {
            IEnumerable<GES_Periode> periode = periodeRepository.GetALL().ToList();
            IEnumerable<PeriodePivot> periodePivots = Mapper.Map<IEnumerable<GES_Periode>, IEnumerable<PeriodePivot>>(periode);
            return periodePivots;
        }

        public PeriodePivot GetPeriodes(long id)
        {
            var item = periodeRepository.GetById((int)id);
            PeriodePivot periodePivot = Mapper.Map<GES_Periode, PeriodePivot>(item);
            return periodePivot;
        }

        public IEnumerable<PeriodePivot> Periodes(string identifged)
        {
            IEnumerable<GES_Periode> periode = periodeRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<PeriodePivot> periodePivots = Mapper.Map<IEnumerable<GES_Periode>, IEnumerable<PeriodePivot>>(periode);
            return periodePivots;
        }

        public void SavePeriode()
        {
            unitOfWork.Commit();
        }

        public void UpdatePeriode(PeriodePivot Periodes)
        {
            periodeRepository.Update(Mapper.Map<PeriodePivot, GES_Periode>(Periodes));
        }
    }
}
