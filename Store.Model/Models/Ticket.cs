using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Ticket
    {
        public int TicketId { get; set; }
        public int TicketNumero { get; set; }
        public DateTime? TicketDate_ouverture { get; set; }
        public long? TicketType { get; set; }
        public string TicketStatut { get; set; }
        public string TicketObjet { get; set; }
        public string TicketDescription { get; set; }
        public string TicketDegre { get; set; }
   
        public int FichetiersIdClient { get; set; }
        public int RepresentantId { get; set; }
  
        public int FichetiersContactIdcontact { get; set; }
        public long? TicketTypeaction { get; set; }
        public int TicketSysuser { get; set; }
        public DateTime? TicketSysDateCreation { get; set; }
        public DateTime? TicketSysDateUpdate { get; set; }
        public Fichetiers Fichetiers { get; set; }
        public Representant Representant { get; set; }
       public FichetiersContact FichetiersContact { get; set; }
        public Ticket()
        {
            TicketSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
