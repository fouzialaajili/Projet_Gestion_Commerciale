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
        IEnumerable<GedPivot> GetALL();
        GedPivot  GetGed(long id);
        IEnumerable<GedPivot> GetGed(string identifged);
        void DeleteGed(GedPivot ged);
        void UpdateGed(GedPivot ged);
        void CreateGed(GedPivot ged);
        void SaveGed();
    }
}
