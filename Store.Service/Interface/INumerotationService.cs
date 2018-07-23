using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface INumerotationService
    {
        IEnumerable<NumerotationPivot> GetALL();
        NumerotationPivot GetNumerotation(long id);
        IEnumerable<NumerotationPivot> Numerotations(string identifged);
        void DeleteNumerotation(NumerotationPivot numerotation);
        void UpdateNumerotation(NumerotationPivot numerotation);
        void CreateNumerotation(NumerotationPivot numerotation);
        void SaveMotif();
    }
}
