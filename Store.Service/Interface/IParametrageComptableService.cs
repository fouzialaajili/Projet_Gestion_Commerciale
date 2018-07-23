using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    interface IParametrageComptableService
    {
        IEnumerable<ParametrageComptablePivot> GetALL();
        ParametrageComptablePivot GetParametrageComptable (long id);
        IEnumerable<ParametrageComptablePivot> ParametrageComptables(string identifged);
        void DeleteParametrageComptable(ParametrageComptablePivot ParametrageComptable);
        void UpdateParametrageComptable(ParametrageComptablePivot ParametrageComptable);
        void CreateParametrageComptable(ParametrageComptablePivot ParametrageComptable);
        void SaveParametrageComptable();
    }
}
