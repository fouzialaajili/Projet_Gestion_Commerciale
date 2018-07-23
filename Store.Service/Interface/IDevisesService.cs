using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
   public interface IDevisesService
    {
        IEnumerable<DevisesPivot> GetALL();
        DevisesPivot GetDevisesPivot(long id);
        //IEnumerable<DevisesPivot> GetDevisesPivotByCode(string Code);
        void DeleteDevisesPivot(DevisesPivot devises);
        void UpdateDevisesPivot(DevisesPivot devises);
        void CreateDevisesPivot(DevisesPivot devises);
        void SaveDevisesPivot();
    }
}
