using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IMotifService
    {
        IEnumerable<MotifPivot> GetALL();
        MotifPivot GetMotif(long id);
        IEnumerable<MotifPivot> Motifs(string identifged);
        void DeleteMotif(MotifPivot Motif);
        void UpdateMotif(MotifPivot Motif);
        void CreateMotif(MotifPivot Motif);
        void SaveMotif();
    }
}
