using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    interface ITypePaiementService
    {
        IEnumerable<TypePaiementPivot> GetALL();
        TypePaiementPivot GetTypePaiement(long id);
        IEnumerable<TypePaiementPivot> TypePaiements(string identifged);
        void DeleteTypePaiement(TypePaiementPivot TypePaiement);
        void UpdateTypePaiement(TypePaiementPivot TypePaiement);
        void CreateTypePaiement(TypePaiementPivot TypePaiement);
        void SaveTypePaiement();
    }
}
