using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class MotifTicketConfiguration : EntityTypeConfiguration<MotifTicket>
    {
        public MotifTicketConfiguration()
        {
            ToTable("MotifTicket");
            HasKey(x => x.MotifTicketId);


            /***********************************/

        //     public Ticket MotifTicketTicket { get; set; }
        //virtual public Societe MotifTicketSociete { get; set; }


        HasOptional<Ticket>(a => a.MotifTicketTicket)
                    .WithMany(d => d.TicketMotifTicket)
                    .HasForeignKey<long?>(a => a.MotifIdticket);

            HasOptional<Societe>(a => a.MotifTicketSociete)
                    .WithMany(d => d.SocieteMotifTicket)
                    .HasForeignKey<long?>(a => a.MotifTicketSocieteId);

        }
    }
}
