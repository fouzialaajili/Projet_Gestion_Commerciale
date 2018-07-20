using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    public interface IDocumentCommercialService
    {
        IEnumerable<DocumentCommercialPivot> GetALL();
        DocumentCommercialPivot GetDocumentCommercialPivot(long id);

        void DeleteDocumentCommercialPivot(DocumentCommercialPivot documentCommercial);
        void UpdateDocumentCommercialPivot(DocumentCommercialPivot documentCommercial);
        void CreateDocumentCommercialPivot(DocumentCommercialPivot documentCommercial);
        void SaveDocumentCommercial();
    }
}
