using Store.Model;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    public interface ICodesTVAService
    {
        IEnumerable<CodesTVAPivot> GetALL();
        CodesTVAPivot GetCodesTVAPivot(long id);
        IEnumerable<CodesTVAPivot> GetCodesTVAPivotByLibelleTaux(string LibelleTaux);

        void DeleteCodesTVAPivot(CodesTVAPivot codesTVAPivot);
        void UpdateCodesTVAPivot(CodesTVAPivot codesTVAPivot);
        void CreateCodesTVAPivot(CodesTVAPivot codesTVAPivot);
        void SaveCodesTVAPivot();
    }
}
