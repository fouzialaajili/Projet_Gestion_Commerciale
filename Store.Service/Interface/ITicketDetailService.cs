using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface ITicketDetailService
    {
        IEnumerable<TicketDetailPivot> GetALL();
        TicketDetailPivot GetTicketDetail(long id);
        IEnumerable<TicketDetailPivot> TicketDetails(string identifged);
        void DeleteTicketDetail(TicketDetailPivot TicketDetail);
        void UpdateTicketDetail(TicketDetailPivot TicketDetail);
        void CreateTicketDetail(TicketDetailPivot TicketDetail);
        void SaveTicketDetail();


    }
}
