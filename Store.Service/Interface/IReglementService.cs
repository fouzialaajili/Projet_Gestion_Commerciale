using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IReglementService
    {

        IEnumerable<ReglementPivot> GetALL();
        ReglementPivot GetReglement(long id);
        IEnumerable<ReglementPivot> Reglements(string identifged);
        void DeleteReglement(ReglementPivot Reglement);
        void UpdateReglement(ReglementPivot Reglement);
        void CreateReglement(ReglementPivot Reglement);
        void SaveReglement();
    }
}