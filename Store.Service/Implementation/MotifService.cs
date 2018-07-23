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
    class MotifService : IMotifService
    {
        private readonly IMotifRepository motifRepository;


        private readonly IUnitOfWork unitOfWork;

        public MotifService(IMotifRepository motifRepository, IUnitOfWork unitOfWork)
        {
            this.motifRepository = motifRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateMotif(MotifPivot Motifs)
        {
            GES_Motif item = Mapper.Map<MotifPivot, GES_Motif>(Motifs);
            motifRepository.Add(item);
        }

        public void DeleteMotif(MotifPivot Motifs)
        {
            motifRepository.Delete(Mapper.Map<MotifPivot, GES_Motif>(Motifs));
        }

        public IEnumerable<MotifPivot> GetALL()
        {
            IEnumerable<GES_Motif> motif = motifRepository.GetALL().ToList();
            IEnumerable<MotifPivot> motifPivots = Mapper.Map<IEnumerable<GES_Motif>, IEnumerable<MotifPivot>>(motif);
            return motifPivots;
        }

        public MotifPivot GetMotif(long id)
        {
            var item = motifRepository.GetById((int)id);
            MotifPivot motifPivot = Mapper.Map<GES_Motif, MotifPivot>(item);
            return motifPivot;
        }

      

        public IEnumerable<MotifPivot> Motifs(string identifged)
        {
            IEnumerable<GES_Motif> motif = motifRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<MotifPivot> motifsPivots = Mapper.Map<IEnumerable<GES_Motif>, IEnumerable<MotifPivot>>(motif);
            return motifsPivots;
        }

        public void SaveMotif()
        {
            unitOfWork.Commit();
        }

        public void UpdateMotif(MotifPivot Motifs)
        {
            motifRepository.Update(Mapper.Map<MotifPivot, GES_Motif>(Motifs));
        }
    }
}
