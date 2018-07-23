using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface ITicketService
    {
        IEnumerable<TicketPivot> GetALL();
        TicketPivot GetTickets(long id);
        IEnumerable<TicketPivot> Tickets(string identifged);
        void DeleteTicket(TicketPivot Tickets);
        void UpdateTicket(TicketPivot Tickets);
        void CreateTicket(TicketPivot Tickets);
        void SaveTicket();
    }
}
