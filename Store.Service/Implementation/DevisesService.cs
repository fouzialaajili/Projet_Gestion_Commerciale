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

namespace Store.Service.Implementation
{
   public class DevisesService : IDevisesService
    {
        private readonly IDevisesRepository devisesRepository;

        private readonly IUnitOfWork unitOfWork;

public DevisesService(IDevisesRepository devisesRepository, IUnitOfWork unitOfWork)
        {
            this.devisesRepository = devisesRepository;
            this.unitOfWork = unitOfWork;

        }
        public void CreateDevisesPivot(DevisesPivot devises)
        {
            GEN_Devises _Devises= Mapper.Map<DevisesPivot, GEN_Devises>(devises);
            devisesRepository.Add(_Devises);
        }

        public void DeleteDevisesPivot(DevisesPivot devises)
        {
            devisesRepository.Delete(Mapper.Map<DevisesPivot, GEN_Devises>(devises));
        }public DevisesPivot GetDevisesPivot(long id)
        {
            var item = devisesRepository.GetById((int)id);
            DevisesPivot devisesPivot= Mapper.Map<GEN_Devises, DevisesPivot>(item);
            return devisesPivot;
        }

        //public IEnumerable<DevisesPivot> GetDevisesPivotByCode(string Code)
        //{
        //    throw new NotImplementedException();
        //}

       

        public void SaveDevisesPivot()
        {
            unitOfWork.Commit();
        }


        public void UpdateDevisesPivot(DevisesPivot devises)
        {
            devisesRepository.Update(Mapper.Map<DevisesPivot, GEN_Devises>(devises));
        }

        IEnumerable<DevisesPivot> IDevisesService.GetALL()
        {
            IEnumerable<GEN_Devises> devises= devisesRepository.GetAll().ToList();
            IEnumerable<DevisesPivot> devisesPivot = Mapper.Map<IEnumerable<GEN_Devises>, IEnumerable<DevisesPivot>>(devises);
            return devisesPivot;
        }
    }
}
