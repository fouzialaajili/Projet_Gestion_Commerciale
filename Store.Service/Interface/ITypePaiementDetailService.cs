using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    interface ITypePaiementDetailService
    {
        IEnumerable<TypePaiementDetailPivot> GetALL();
        TypePaiementDetailPivot GetTypePaiementDetails(long id);
        IEnumerable<TypePaiementDetailPivot> TypePaiementDetails(string identifged);
        void DeleteTypePaiementDetail(TypePaiementDetailPivot TypePaiementDetail);
        void UpdateTypePaiementDetail(TypePaiementDetailPivot TypePaiementDetail);
        void CreateTypePaiementDetail(TypePaiementDetailPivot TypePaiementDetail);
        void SaveTypePaiementDetail();
    }
}
