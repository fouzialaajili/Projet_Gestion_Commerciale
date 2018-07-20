using Store.Data.Infrastructure;
using Store.Data.Repositories;
using Store.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Model;
using Store.Service.Pivot;

namespace Store.Service.Implementation
{  /*
    class ImpressionService: IImpressionService
    {

      private readonly IImpressionRepositoy impressionRepository;


        private readonly IUnitOfWork unitOfWork;

        public ImpressionService(IImpressionRepositoy impressionRepository, IUnitOfWork unitOfWork)
        {
            this.impressionRepository = impressionRepository;

            this.unitOfWork = unitOfWork;
        }

        public void CreateImpression(ImpressionPivot impression)
        {
            GES_Impression item = Mapper.Map<ImpressionPivot, GES_Impression>(impression);
            impressionRepository.Add(item);
        }

        public void DeleteImpression(ImpressionPivot impression)
        {
            impressionRepository.Delete(Mapper.Map<ImpressionPivot, GES_Impression>(impression));
        }

        public IEnumerable<GES_Impression> GetALL()
        {
            IEnumerable<GES_Impression> impression = impressionRepository.GetALL().ToList();
            IEnumerable<GES_Impression> impressions = Mapper.Map<IEnumerable<GES_Impression>, IEnumerable<ImpressionPivot>>(impression);
            return impressions;
        }

        public GES_Impression GetImpression(long id)
        {
            var item = impressionRepository.GetById((int)id);
            ImpressionPivot impressionPivot = Mapper.Map<GES_Ged, GedPivot>(item);
            return impressionPivot;
        }

        public IEnumerable<GES_Impression> Impressions(string identifged)
        {
            IEnumerable<GES_Impression> impression = impressionRepository.GetItemsByModelLibelle(identifged).ToList();
            IEnumerable<GES_Impression> impressions = Mapper.Map<IEnumerable<GES_Impression>, IEnumerable<ImpressionPivot>>(impression);
            return impressions;
        }

        public void SaveImpression()
        {
            throw new NotImplementedException();
        }

        public void UpdateImpression(ImpressionPivot impression)
        {
            impressionRepository.Update(Mapper.Map<GES_Impression, GES_Impression>(impression));
        }
    }*/
}
