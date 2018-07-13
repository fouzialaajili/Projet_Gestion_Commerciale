using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Ticket
    {
        public long TicketId { get; set; }
        public long TicketNumero { get; set; }
        public DateTime? TicketDate_ouverture { get; set; }
        public long? TicketType { get; set; }
        public string TicketStatut { get; set; }
        public string TicketObjet { get; set; }
        public string TicketDescription { get; set; }
        public string TicketDegre { get; set; }
   
     /***/   public long TicketIdClient { get; set; }
     /***/   public long TicketIdRepresentant { get; set; }
  
    /***/    public long TicketIdcontact { get; set; }
        public long? TicketTypeaction { get; set; }
        public long TicketSysuser { get; set; }
        public DateTime? TicketSysDateCreation { get; set; }
        public DateTime? TicketSysDateUpdate { get; set; }
        virtual public Fichetiers Fichetiers { get; set; }
        virtual public Representant Representant { get; set; }
        virtual public FichetiersContact FichetiersContact { get; set; }
        public Ticket()
        {
            TicketSysDateCreation = DateTime.Now;
        }
  /***/      public long TicketSocieteId { get; set; }
        virtual  public Societe Societe { get; set; }

        public virtual ICollection<MotifTicket> TicketMotifTicket { get; set; }
        public virtual ICollection<TicketDetail> TicketMotifTicketDetail { get; set; }
    }
}
