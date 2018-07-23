using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IToleranceService
    {
        IEnumerable<TolerancePivot> GetALL();
        TolerancePivot GetTolerances(long id);
        IEnumerable<TolerancePivot> Tolerances(string identifged);
        void DeleteTolerances(TolerancePivot Tolerances);
        void UpdateTolerances(TolerancePivot Tolerances);
        void CreateTolerances(TolerancePivot Tolerances);
        void SaveTolerances();
    }
}
