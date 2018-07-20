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
    class MouvementStockService : IMouvementStockService
    {

        private readonly IMouvementStockRepository mouvementStockRepository;


        private readonly IUnitOfWork unitOfWork;

        public MouvementStockService(IMouvementStockRepository mouvementStockRepository, IUnitOfWork unitOfWork)
        {
            this.mouvementStockRepository = mouvementStockRepository;
            this.unitOfWork = unitOfWork;
        }
        public void CreateMouvementStock(MouvementStockPivot mouvementStock)
        {
            MouvementStockPivot item = Mapper.Map<MouvementStockPivot, GES_MouvementStock>(mouvementStock);
            mouvementStockRepository.Add(item);
        }

        public void DeleteMouvementStock(MouvementStockPivot mouvementStock)
        {
            mouvementStockRepository.Delete(Mapper.Map<MouvementStockPivot, GES_MouvementStock>(mouvementStock));
        }

        public IEnumerable<MouvementStockPivot> GetALL()
        {
            IEnumerable<GES_MouvementStock> motif = mouvementStockRepository.GetALL().ToList();
            IEnumerable<MouvementStockPivot> motifPivots = Mapper.Map<IEnumerable<GES_MouvementStock>, IEnumerable<MouvementStockPivot>>(motif);
            return motifPivot
        }

        public MouvementStockPivot GetMouvementStocks(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MouvementStockPivot> MouvementStocks(string identifged)
        {
            throw new NotImplementedException();
        }

        public void SaveMotif()
        {
            throw new NotImplementedException();
        }

        public void UpdateMouvementStock(MouvementStockPivot mouvementStock)
        {
            throw new NotImplementedException();
        }
    }
}
