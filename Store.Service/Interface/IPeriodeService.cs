using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IPeriodeService
    {
        IEnumerable<PeriodePivot> GetALL();
        PeriodePivot GetPeriodes(long id);
        IEnumerable<PeriodePivot> Periodes(string identifged);
        void DeletePeriode(PeriodePivot Periodes);
        void UpdatePeriode(PeriodePivot Periodes);
        void CreatePeriodes(PeriodePivot Periodes);
        void SavePeriode();
    }
}
