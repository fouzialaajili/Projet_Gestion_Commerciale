using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class MotifTicket
    {
        public long MotifTicketId { get; set; }
   /**/     public long MotifIdticket { get; set; }
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
    /***/    public long SocieteId { get; set; }
           public Ticket Ticket { get; set; }
          virtual public Societe Societe { get; set; }

    }

}
