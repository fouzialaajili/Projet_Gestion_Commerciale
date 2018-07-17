using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class TicketDetailConfiguration : EntityTypeConfiguration<TicketDetail>
    {
        public TicketDetailConfiguration()
        {
            ToTable("TicketDetail");
            HasKey(x => x.TicketDetailId);


            /***********************************/

        //virtual public Fichetiers TicketDetailFichetier { get; set; }
        //virtual public Ticket TicketDetailTicket { get; set; }

        HasOptional<Fichetier>(a => a.TicketDetailFichetier)
                              .WithMany(d => d.FichetiersTicketDetail)
                              .HasForeignKey<long?>(a => a.TicketDetailIdcommercial);

            HasOptional<Ticket>(a => a.TicketDetailTicket)
                                  .WithMany(d => d.TicketTicketDetail)
                                  .HasForeignKey<long?>(a => a.TicketDetailIdTicket);

        }
    }
}
