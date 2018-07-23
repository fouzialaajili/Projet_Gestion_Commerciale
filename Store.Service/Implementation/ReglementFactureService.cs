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
namespace Store.Service.Implementations
{
    class ReglementFactureService : IReglementFactureService
    {
        private readonly IReglementFactureRepository reglementFactureRepository;


        private readonly IUnitOfWork unitOfWork;

        public ReglementFactureService(IReglementFactureRepository reglementFactureRepository, IUnitOfWork unitOfWork)
        {
            this.reglementFactureRepository = reglementFactureRepository;
            this.unitOfWork = unitOfWork;
        }


        public void CreateReglementFacture(ReglementFacturePivot ReglementFacture)
        {
            GES_ReglementFacture item = Mapper.Map<ReglementFacturePivot, GES_ReglementFacture>(ReglementFacture);
            reglementFactureRepository.Add(item);
        }

        public void DeleteReglementFacture(ReglementFacturePivot ReglementFacture)
        {
            reglementFactureRepository.Delete(Mapper.Map<ReglementFacturePivot, GES_ReglementFacture>(ReglementFacture));
        }

        public IEnumerable<ReglementFacturePivot> GetALL()
        {
            IEnumerable<GES_ReglementFacture> reglementFactur = reglementFactureRepository.GetALL().ToList();
            IEnumerable<ReglementFacturePivot> reglementFacturePivots = Mapper.Map<IEnumerable<GES_ReglementFacture>, IEnumerable<ReglementFacturePivot>>(reglementFactur);
            return reglementFacturePivots;
        }

        public ReglementFacturePivot GetReglementFacture(long id)
        {
            var item = reglementFactureRepository.GetById((int)id);
            ReglementFacturePivot reglementFacturePivots = Mapper.Map<GES_ReglementFacture, ReglementFacturePivot>(item);
            return reglementFacturePivots;
        }

        public IEnumerable<ReglementFacturePivot> ReglementFactures(string identifged)
        {
            IEnumerable<GES_ReglementFacture> motif = reglementFactureRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<ReglementFacturePivot> reglementFacturePivots = Mapper.Map<IEnumerable<GES_ReglementFacture>, IEnumerable<ReglementFacturePivot>>(motif);
            return reglementFacturePivots;
        }

        public void SaveReglementFacture()
        {
            unitOfWork.Commit();
        }

        public void UpdateReglementFacture(ReglementFacturePivot ReglementFacture)
        {

            reglementFactureRepository.Update(Mapper.Map<ReglementFacturePivot, GES_ReglementFacture>(ReglementFacture));
        }
    }
}
