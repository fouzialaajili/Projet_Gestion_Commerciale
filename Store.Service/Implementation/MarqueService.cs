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
    class MarqueService : IMarqueService
    {

        private readonly IMarqueRepository marqueRepository;


        private readonly IUnitOfWork unitOfWork;

        public MarqueService(IMarqueRepository marqueRepository, IUnitOfWork unitOfWork)
        {
            this.marqueRepository = marqueRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateMarque(MarquePivot Marque)
        {
            MarquePivot item = Mapper.Map<MarquePivot, GES_Marque>(Marque);
            marqueRepository.Add(item);

        }

        public void DeleteMarque(MarquePivot Marque)
        {
            marqueRepository.Delete(Mapper.Map<MarquePivot, GES_Marque>(Marque));
        }

        public IEnumerable<MarquePivot> GetALL()
        {
            IEnumerable<GES_Marque> marques = marqueRepository.GetALL().ToList();
            IEnumerable<MarquePivot> marquePivots = Mapper.Map<IEnumerable<GES_Marque>, IEnumerable<MarquePivot>>(marques);
            return marquePivots;
        }

        public MarquePivot GetMarque(long id)
        {
            var item = marqueRepository.GetById((int)id);
            MarquePivot marquePivot = Mapper.Map<GES_Marque, MarquePivot>(item);
            return marquePivot;
        }

        public IEnumerable<MarquePivot> Marques(string identifged)
        {
            IEnumerable<GES_Marque> marques = marqueRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<MarquePivot> marquesPivots = Mapper.Map<IEnumerable<GES_Marque>, IEnumerable<MarquePivot>>(marques);
            return marquesPivots;
        }

        public void SaveMarque()
        {
            unitOfWork.Commit();
        }

        public void UpdateMarque(MarquePivot Marque)
        {
            marqueRepository.Update(Mapper.Map<MarquePivot, GES_Marque>(Marque));
        }
    }
}
