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

namespace Store.Service.Implementation
{
    class UniteService : IUniteService
    {


        private readonly IUniteRepository tiersContactsRepository;


        private readonly IUnitOfWork unitOfWork;

        public UniteService(IUniteRepository tiersContactsRepository, IUnitOfWork unitOfWork)
        {
            this.tiersContactsRepository = tiersContactsRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateUnitePivot(UnitePivot doclieart)
        {
            GES_Unite  item = Mapper.Map<UnitePivot, GES_Unite>(doclieart);
            tiersContactsRepository.Add(item);
        }

        public void DeleteUnitePivot(UnitePivot doclieart)
        {
            tiersContactsRepository.Delete(Mapper.Map<UnitePivot, GES_Unite>(doclieart));
        }

        public IEnumerable<UnitePivot> GetALL()
        {
            IEnumerable<GES_Unite> motif = tiersContactsRepository.GetALL().ToList();
            IEnumerable<UnitePivot> motifPivots = Mapper.Map<IEnumerable<GES_Unite>, IEnumerable<UnitePivot>>(motif);
            return motifPivots;
        }

        public UnitePivot GetUnitePivot(long id)
        {
            var item = tiersContactsRepository.GetById((int)id);
            UnitePivot motifPivot = Mapper.Map<GES_Unite, UnitePivot>(item);
            return motifPivot;
        }

        public IEnumerable<UnitePivot> GetUnitePivots(string UniteName)
        {
            IEnumerable<GES_Unite> motif = tiersContactsRepository.GetItemsByModelLibelle(UniteName).ToList();
            IEnumerable<UnitePivot> motifsPivots = Mapper.Map<IEnumerable<GES_Unite>, IEnumerable<UnitePivot>>(motif);
            return motifsPivots;
        }

        public void SaveUnitePivot()
        {
            unitOfWork.Commit();
        }

        public void UpdateUnitePivot(UnitePivot doclieart)
        {
            tiersContactsRepository.Update(Mapper.Map<UnitePivot, GES_Unite>(doclieart));
        }
    }
}
