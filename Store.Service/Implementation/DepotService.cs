using AutoMapper;
using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Model;
using Store.Service.Interface;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    class DepotService : IDepotService
    {
private readonly IDepotRepository depotRepository;
private readonly IUnitOfWork unitOfWork;

        public DepotService(IDepotRepository depotRepository, IUnitOfWork unitOfWork)
        {
            this.depotRepository = depotRepository;
            this.unitOfWork = unitOfWork;

        }




        void IDepotService.CreateDepotPivot(DepotPivot depotPivot)
        {
            GES_Depot depot = Mapper.Map<DepotPivot, GES_Depot>(depotPivot);
            depotRepository.Add(depot);
           
        }

        void IDepotService.DeleteDepotPivot(DepotPivot depot)
        {

            depotRepository.Delete(Mapper.Map<DepotPivot, GES_Depot>(depot));
        }

        IEnumerable<DepotPivot> IDepotService.GetALL()
        {
            IEnumerable<GES_Depot>  depots= depotRepository.GetAll().ToList();
            IEnumerable<DepotPivot> codesTVAPivot = Mapper.Map<IEnumerable<GES_Depot>, IEnumerable<DepotPivot>>(depots);
            return codesTVAPivot;
        }

        DepotPivot IDepotService.GetDepotPivot(long id)

        {
            var item = depotRepository.GetById((int)id);
           DepotPivot depotsPivot = Mapper.Map<GES_Depot, DepotPivot>(item);
            return depotsPivot;
    
        }

        IEnumerable<DepotPivot> IDepotService.GetDepotPivotByLibelleTaux(string Code)
        {
            throw new NotImplementedException();
        }

        void IDepotService.SaveDepotPivot()
        {
            unitOfWork.Commit();
        }

        void IDepotService.UpdateDepotPivot(DepotPivot depot)
        {

            depotRepository.Update(Mapper.Map<DepotPivot, GES_Depot>(depot));
        }
    }
}
