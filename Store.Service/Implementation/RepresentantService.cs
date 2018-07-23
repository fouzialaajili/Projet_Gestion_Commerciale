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
    class RepresentantService : IRepresentantService
    {

        private readonly IRepresentantRepository representantRepository;


        private readonly IUnitOfWork unitOfWork;

        public RepresentantService(IRepresentantRepository representantRepository, IUnitOfWork unitOfWork)
        {
            this.representantRepository = representantRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateRepresentant(RepresentantPivot Representant)
        {

            GES_Representant item = Mapper.Map<RepresentantPivot, GES_Representant>(Representant);
            representantRepository.Add(item);
        }

        public void DeleteRepresentant(RepresentantPivot Representant)
        {
            representantRepository.Delete(Mapper.Map<RepresentantPivot, GES_Representant>(Representant));
        }

        public IEnumerable<RepresentantPivot> GetALL()
        {
            IEnumerable<GES_Representant> reglement = representantRepository.GetALL().ToList();
            IEnumerable<RepresentantPivot> reglementPivots = Mapper.Map<IEnumerable<GES_Representant>, IEnumerable<RepresentantPivot>>(reglement);
            return reglementPivots;
        }

        public RepresentantPivot GetRepresentant(long id)
        {
            var item = representantRepository.GetById((int)id);
            RepresentantPivot reglementFacturePivots = Mapper.Map<GES_Representant, RepresentantPivot>(item);
            return reglementFacturePivots;
        }

        public IEnumerable<RepresentantPivot> Representants(string identifged)
        {
            IEnumerable<GES_Representant> motif = representantRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<RepresentantPivot> reglementFacturePivots = Mapper.Map<IEnumerable<GES_Representant>, IEnumerable<RepresentantPivot>>(motif);
            return reglementFacturePivots;
        }

        public void SaveRepresentant()
        {
            unitOfWork.Commit();
        }

        public void UpdateRepresentant(RepresentantPivot Representant)
        {
            representantRepository.Update(Mapper.Map<RepresentantPivot, GES_Representant>(Representant));
        }
    }
}
