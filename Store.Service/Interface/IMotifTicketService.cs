using Store.Service.Pivot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Interface
{
    interface IMotifTicketService
    {
        IEnumerable<MotifTicketPivot> GetALL();
        MotifTicketPivot GetMotifTickes(long id);
        IEnumerable<MotifTicketPivot> MotifTickets(string identifged);
        void DeleteMotifTicket(MotifTicketPivot Motif);
        void UpdateMotifTicket(MotifTicketPivot Motif);
        void CreateMotifTicket(MotifTicketPivot Motif);
        void SaveMotif();
    }
}
