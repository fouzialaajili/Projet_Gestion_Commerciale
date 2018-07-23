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
    class OpportuniteService : IOpportuniteService
    {
        private readonly IOpportuniteRepository opportuniteRepository;


        private readonly IUnitOfWork unitOfWork;

        public OpportuniteService(IOpportuniteRepository opportuniteRepository, IUnitOfWork unitOfWork)
        {
            this.opportuniteRepository = opportuniteRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateOpportunite(OpportunitePivot opportunite)
        {
            GES_Opportunite item = Mapper.Map<OpportunitePivot, GES_Opportunite>(opportunite);
            opportuniteRepository.Add(item);
        }
        public void DeleteOpportunite(OpportunitePivot opportunite)
        {
            opportuniteRepository.Delete(Mapper.Map<OpportunitePivot, GES_Opportunite>(opportunite));
        }

        public IEnumerable<OpportunitePivot> GetALL()
        {
            IEnumerable<GES_Opportunite> opportunite = opportuniteRepository.GetALL().ToList();
            IEnumerable<OpportunitePivot> opportunitePivots = Mapper.Map<IEnumerable<GES_Opportunite>, IEnumerable<OpportunitePivot>>(opportunite);
            return opportunitePivots;
        }

        public OpportunitePivot Getopportunite(long id)
        {
            var item = opportuniteRepository.GetById((int)id);
            OpportunitePivot opportunitePivot = Mapper.Map<GES_Opportunite, OpportunitePivot>(item);
            return opportunitePivot;
        }

        public IEnumerable<OpportunitePivot> opportunites(string identifged)
        {
            IEnumerable<GES_Opportunite> opportunite = opportuniteRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<OpportunitePivot> opportunitePivots = Mapper.Map<IEnumerable<GES_Opportunite>, IEnumerable<OpportunitePivot>>(opportunite);
            return opportunitePivots;
        }

        public void SaveOpportunite()
        {
            unitOfWork.Commit();
        }

        public void UpdateOpportunite(OpportunitePivot opportunite)
        {
            opportuniteRepository.Update(Mapper.Map<OpportunitePivot, GES_Opportunite>(opportunite));
        }
    }
}
