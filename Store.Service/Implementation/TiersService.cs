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
    class TiersService : ITiersService
    { 
        private readonly IFichetierRepository fichetierRepository;


        private readonly IUnitOfWork unitOfWork;

        public TiersService(IFichetierRepository fichetierRepository, IUnitOfWork unitOfWork)
        {
            this.fichetierRepository = fichetierRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateTiers(TiersPivot Tiers)
        {
            GEN_Tiers item = Mapper.Map<TiersPivot, GEN_Tiers>(Tiers);
            fichetierRepository.Add(item);
        }

        public void DeleteTiers(TiersPivot Tiers)
        {

            fichetierRepository.Delete(Mapper.Map<TiersPivot, GEN_Tiers>(Tiers));
        }

        public IEnumerable<TiersPivot> GetALL()
        {
            IEnumerable<GEN_Tiers> motif = fichetierRepository.GetALL().ToList();
            IEnumerable<TiersPivot> motifPivots = Mapper.Map<IEnumerable<GEN_Tiers>, IEnumerable<TiersPivot>>(motif);
            return motifPivots;
        }

        public TiersPivot GetTiers(long id)
        {
            var item = fichetierRepository.GetById((int)id);
            TiersPivot motifPivot = Mapper.Map<GEN_Tiers, TiersPivot>(item);
            return motifPivot;
        }

        public void SaveTiers()
        {
            unitOfWork.Commit();
        }

        public IEnumerable<TiersPivot> Tiers(string identifged)
        {
            IEnumerable<GEN_Tiers> motif = fichetierRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<TiersPivot> motifsPivots = Mapper.Map<IEnumerable<GEN_Tiers>, IEnumerable<TiersPivot>>(motif);
            return motifsPivots;
        }

        public void UpdateTiers(TiersPivot Tiers)
        {
            fichetierRepository.Update(Mapper.Map<TiersPivot, GEN_Tiers>(Tiers));
        }
    }
}
