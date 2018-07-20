using Store.Service.Interface;
using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service
{
    class DepotService : IDepotService
    {
        void IDepotService.CreateDepotPivot(DepotPivot depot)
        {
            throw new NotImplementedException();
        }

        void IDepotService.DeleteDepotPivot(DepotPivot depot)
        {
            throw new NotImplementedException();
        }

        IEnumerable<DepotPivot> IDepotService.GetALL()
        {
            throw new NotImplementedException();
        }

        DepotPivot IDepotService.GetDepotPivot(long id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<DepotPivot> IDepotService.GetDepotPivotByLibelleTaux(string Code)
        {
            throw new NotImplementedException();
        }

        void IDepotService.SaveDepotPivot()
        {
            throw new NotImplementedException();
        }

        void IDepotService.UpdateDepotPivot(DepotPivot depot)
        {
            throw new NotImplementedException();
        }
    }
}
