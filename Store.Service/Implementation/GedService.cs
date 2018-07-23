using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;
using Store.Service.Pivot;
using Store.Data.Repositories;
using Store.Data.Infrastructure;

namespace Store.Service.Implementation
{
      class GedService : IGedService
    {


     private readonly IGedRepository gedRepository;
      

        private readonly IUnitOfWork unitOfWork;

        public GedService(IGedRepository gedRepository,  IUnitOfWork unitOfWork)
        {
            this.gedRepository = gedRepository;
     
            this.unitOfWork = unitOfWork;
        }

        public void CreateGed(GedPivot ged)
        {
            GES_Ged item = Mapper.Map<GedPivot, GES_Ged>(ged);
            gedRepository.Add(item);
        }

        public void DeleteGed(GedPivot ged)
        {
            gedRepository.Delete(Mapper.Map<GedPivot, GES_Ged>(ged));
        }

        public IEnumerable<GES_Ged> GetALL()
        {
            IEnumerable<GES_Ged> ged = gedRepository.GetAll().ToList();
            IEnumerable<GES_Ged> geds = Mapper.Map<IEnumerable<GES_Ged>, IEnumerable<GedPivot>>(ged);
            return geds;
        }

        public IEnumerable<GES_Ged> GetGed(string identifged)
        {
            IEnumerable<GES_Ged> geds = gedRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<GES_Ged> gedPivots = Mapper.Map<IEnumerable<GES_Ged>, IEnumerable<GedPivot>>(geds);
            return gedPivots;
        }

        public GES_Ged GetGed(long id)
        {
            var item = gedRepository.GetById((int)id);
           GedPivot gedPivot = Mapper.Map<GES_Ged, GedPivot>(item);
            return gedPivot;
        }

        public void SaveGed()
        {

            unitOfWork.Commit();
        }

        public void UpdateGed(GedPivot ged)
        {
            gedRepository.Update(Mapper.Map<GedPivot, GES_Ged>(ged));
        }
    }

}
