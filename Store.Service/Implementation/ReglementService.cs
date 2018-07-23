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
    class ReglementService : IReglementService
    {

        private readonly IReglementRepository reglementRepository;


        private readonly IUnitOfWork unitOfWork;

        public ReglementService(IReglementRepository reglementRepository, IUnitOfWork unitOfWork)
        {
            this.reglementRepository = reglementRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateReglement(ReglementPivot Reglement)
        {

            GES_Reglement item = Mapper.Map<ReglementPivot, GES_Reglement>(Reglement);
            reglementRepository.Add(item);
        }

        public void DeleteReglement(ReglementPivot Reglement)
        {
            reglementRepository.Delete(Mapper.Map<ReglementPivot, GES_Reglement>(Reglement));
        }

        public IEnumerable<ReglementPivot> GetALL()
        {
            IEnumerable<GES_Reglement> reglement= reglementRepository.GetALL().ToList();
            IEnumerable<ReglementPivot> reglementPivots = Mapper.Map<IEnumerable<GES_Reglement>, IEnumerable<ReglementPivot>>(reglement);
            return reglementPivots;
        }

        public ReglementPivot GetReglement(long id)
        {
            var item = reglementRepository.GetById((int)id);
            ReglementPivot reglementFacturePivots = Mapper.Map<GES_Reglement, ReglementPivot>(item);
            return reglementFacturePivots;
        }

        public IEnumerable<ReglementPivot> Reglements(string identifged)
        {
            IEnumerable<GES_Reglement> motif = reglementRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<ReglementPivot> reglementFacturePivots = Mapper.Map<IEnumerable<GES_Reglement>, IEnumerable<ReglementPivot>>(motif);
            return reglementFacturePivots;
        }

        public void SaveReglement()
        {
            unitOfWork.Commit();
        }

        public void UpdateReglement(ReglementPivot Reglement)
        {
            reglementRepository.Update(Mapper.Map<ReglementPivot, GES_Reglement>(Reglement));
        }
    }
}
