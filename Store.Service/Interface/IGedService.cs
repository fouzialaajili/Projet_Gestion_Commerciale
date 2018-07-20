using Store.Model;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IGedService
    {
        IEnumerable<GES_Ged> GetALL();
        GES_Ged GetGed(long id);
        IEnumerable<GES_Ged> GetGed(string identifged);
        void DeleteGed(GedPivot ged);
        void UpdateGed(GedPivot ged);
        void CreateGed(GedPivot ged);
        void SaveGed();
    }
}
