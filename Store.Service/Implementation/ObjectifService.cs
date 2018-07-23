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
using AutoMapper;

namespace Store.Service.Implementation
{
    class ObjectifService : IObjectifService
    {
        private readonly IObjectifRepository objectifSRepository;


        private readonly IUnitOfWork unitOfWork;

        public ObjectifService(IObjectifRepository objectifSRepository, IUnitOfWork unitOfWork)
        {
            this.objectifSRepository = objectifSRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateObjectif(ObjectifPivot objectif)
        {
            GES_Objectif item = Mapper.Map<ObjectifPivot, GES_Objectif>(objectif);
            objectifSRepository.Add(item);
        }

        public void DeleteObjectif(ObjectifPivot objectif)
        {
            objectifSRepository.Delete(Mapper.Map<ObjectifPivot, GES_Objectif>(objectif));
        }

        public IEnumerable<ObjectifPivot> GetALL()
        {
            IEnumerable<GES_Objectif> objectif = objectifSRepository.GetALL().ToList();
            IEnumerable<ObjectifPivot> objectifPivots = Mapper.Map<IEnumerable<GES_Objectif>, IEnumerable<ObjectifPivot>>(objectif);
            return objectifPivots;
        }

        public ObjectifPivot GetObjectif(long id)
        {
            var item = objectifSRepository.GetById((int)id);
            ObjectifPivot objectifPivot = Mapper.Map<GES_Objectif,ObjectifPivot>(item);
            return objectifPivot;
        }

        /*public IEnumerable<ObjectifPivot> Objectifs(string identifged)
        {
            IEnumerable<GES_Objectif> objectif = objectifSRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<ObjectifPivot> objectifPivots = Mapper.Map<IEnumerable<GES_Objectif>, IEnumerable<ObjectifPivot>>(objectif);
            return objectifPivots;
        }
        */
        public void SaveObjectif()
        {
            unitOfWork.Commit();
        }

        public void UpdateObjectif(ObjectifPivot objectif)
        {
            objectifSRepository.Update(Mapper.Map<ObjectifPivot, GES_Objectif>(objectif));
        }
    }
}
