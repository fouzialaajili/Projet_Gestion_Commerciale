﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_MotifTicketConfiguration : EntityTypeConfiguration<GES_MotifTicket>
    {
        public GES_MotifTicketConfiguration()
        {
            ToTable("MotifTicket");
            HasKey(x => x.MotifTicketId);


            /***********************************/

        // virtual public GES_Ticket MotifTicketTicket { get; set; }
        //virtual public GEN_Dossiers MotifTicketSociete { get; set; }


        HasOptional<GEN_TiersContact>(a => a.MotifTicketTicket)
                    .WithMany(d => d.TicketMotifTicket)
                    .HasForeignKey<long?>(a => a.MotifIdticket);

            HasOptional<GEN_Dossiers>(a => a.MotifTicketSociete)
                    .WithMany(d => d.GES_MotifTicket)
                    .HasForeignKey<long?>(a => a.MotifTicketId);

        }
    }
}
