using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class TicketDetail
    {
        public int TicketDetailId { get; set; }
        public int TicketId { get; set; }
        public long? TicketDetailTypeaction { get; set; }
        public int FichetiersIdcommercial { get; set; }

        public DateTime? TicketDetailDateaction { get; set; }
        public DateTime? TicketDetailheureaction { get; set; }
        public string TicketDetailDescription { get; set; }
        public int TicketDetailSysuser { get; set; }
        public DateTime? TicketDetailSysDateCreation { get; set; }
        public DateTime? TicketDetailSysDateUpdate { get; set; }

        public TicketDetail()
        {
            TicketDetailSysDateCreation = DateTime.Now;
        }

        public Fichetiers Fichetiers { get; set; }
        public Ticket Ticket { get; set; }
    }
}
