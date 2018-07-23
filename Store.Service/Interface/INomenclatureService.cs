using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface INomenclatureService
    {

        IEnumerable<NomenclaturePivot> GetALL();
        NomenclaturePivot GetNomenclatures(long id);
        IEnumerable<NomenclaturePivot> Nomenclatures(string identifged);
        void DeleteNomenclature(NomenclaturePivot nomenclature);
        void UpdateNomenclature(NomenclaturePivot nomenclature);
        void CreateNomenclature(NomenclaturePivot nomenclature);
        void SaveMotif();
    }
}
