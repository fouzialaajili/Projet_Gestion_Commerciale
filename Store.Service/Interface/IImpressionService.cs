using Store.Model;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IImpressionService
    {
        IEnumerable<GES_Impression> GetALL();
        GES_Impression GetImpression(long id);
        IEnumerable<GES_Impression> Impressions(string identifged);
        void DeleteImpression(ImpressionPivot ged);
        void UpdateImpression(ImpressionPivot ged);
        void CreateImpression(ImpressionPivot ged);
        void SaveImpression();
    }
}
