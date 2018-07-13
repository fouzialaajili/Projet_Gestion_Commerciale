using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class MotifTicket
    {
        public int MotifTicketId { get; set; }
        public int TicketId { get; set; }
        public string MotifTicketEtat { get; set; }
        public string MotifTicketMotif { get; set; }
        public string MotifTicketDescription{ get; set; }
        public int MotifTicketSysuser { get; set; }
        public DateTime? MotifTicketSysDateCreation { get; set;}
        public DateTime? MotifTicketSysDateUpdate { get; set;}

        public MotifTicket()
        {
            MotifTicketSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Ticket Ticket { get; set; }
        public Societe Societe { get; set; }

    }

}
