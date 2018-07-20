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
            throw new NotImplementedException();
        }

        public void DeleteGed(GedPivot ged)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GES_Ged> GetALL()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GES_Ged> GetGed(string identifged)
        {
            throw new NotImplementedException();
        }

        public GES_Ged GetGed(long id)
        {
            throw new NotImplementedException();
        }

        public void SaveGed()
        {
            throw new NotImplementedException();
        }

        public void UpdateGed(GedPivot ged)
        {
            throw new NotImplementedException();
        }
    }
}
