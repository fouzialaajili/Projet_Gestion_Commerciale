using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IMarqueService
    {

        IEnumerable<MarquePivot> GetALL();
        MarquePivot GetMarque(long id);
        IEnumerable<MarquePivot> Marques(string identifged);
        void DeleteMarque(MarquePivot Marque);
        void UpdateMarque(MarquePivot Marque);
        void CreateMarque(MarquePivot Marque);
        void SaveMarque();
    }
}
