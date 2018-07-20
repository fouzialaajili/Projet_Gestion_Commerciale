using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    public interface IDoclieService
    {
        IEnumerable<DocliePivot> GetALL();
        DocliePivot GetDocliePivot(long id);
        IEnumerable<DocliePivot> GetDocliePivotByCode(string DoclieartNomdoc);
        void DeleteDocliePivot(DocliePivot doclie);
        void UpdateDocliePivot(DocliePivot doclie);
        void CreateDocliePivot(DocliePivot doclie);
        void SaveDocliePivot();
    }
}
