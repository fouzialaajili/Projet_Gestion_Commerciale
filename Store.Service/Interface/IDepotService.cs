using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    public interface IDepotService
    {
        IEnumerable<DepotPivot> GetALL();
        DepotPivot GetDepotPivot(long id);
        IEnumerable<DepotPivot> GetDepotPivotByLibelleTaux(string Code);
        
        void DeleteDepotPivot(DepotPivot depot);
        void UpdateDepotPivot(DepotPivot depot);
        void CreateDepotPivot(DepotPivot depot);
        void SaveDepotPivot();
    }
}

