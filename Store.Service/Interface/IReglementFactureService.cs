using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IReglementFactureService
    {

        IEnumerable<ReglementFacturePivot> GetALL();
        ReglementFacturePivot GetReglementFacture(long id);
        IEnumerable<ReglementFacturePivot> ReglementFactures(string identifged);
        void DeleteReglementFacture(ReglementFacturePivot ReglementFacture);
        void UpdateReglementFacture(ReglementFacturePivot ReglementFacture);
        void CreateReglementFacture(ReglementFacturePivot ReglementFacture);
        void SaveReglementFacture();
    }
}
