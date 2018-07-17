using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class TicketConfiguration : EntityTypeConfiguration<Ticket>
    {
        public TicketConfiguration()
        {
            ToTable("Ticket");
            HasKey(x => x.TicketId);


            /***********************************/
            // virtual  public Societe TicketSociete { get; set; }
        // virtual public Fichetiers TicketFichetier { get; set; }
        //virtual public Representant TicketRepresentant { get; set; }
        //virtual public FichetiersContact TicketFichetiersContact { get; set; }




        HasOptional<Societe>(a => a.TicketSociete)
                              .WithMany(d => d.SocieteTicket)
                              .HasForeignKey<long?>(a => a.TicketSocieteId);

            HasOptional<Fichetier>(a => a.TicketFichetier)
                      .WithMany(d => d.FichetierTicket)
                      .HasForeignKey<long?>(a => a.TicketIdClient);

            HasOptional<Representant>(a => a.TicketRepresentant)
                      .WithMany(d => d.RepresentantTicket)
                      .HasForeignKey<long?>(a => a.TicketIdRepresentant);

            HasOptional<FichetiersContact>(a => a.TicketFichetiersContact)
                      .WithMany(d => d.FichetiersContactTicket)
                      .HasForeignKey<long?>(a => a.TicketIdcontact);

        }
    }
}
