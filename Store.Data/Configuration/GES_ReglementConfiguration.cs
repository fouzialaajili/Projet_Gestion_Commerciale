﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_ReglementConfiguration : EntityTypeConfiguration<GES_Reglement>
    {
        public GES_ReglementConfiguration()
        {
            ToTable("Reglement");
            HasKey(x => x.ReglementId);


            /***********************************/
            //      virtual public GEN_Dossiers ReglementDossier { get; set; }
            //virtual public GEN_Tiers ReglementFichetier { get; set; }


            HasOptional<GEN_Dossiers>(a => a.ReglementDossier)
                            .WithMany(d => d.GES_Reglement)
                            .HasForeignKey<long?>(a => a.ReglementDossierId);

            HasOptional<GEN_Tiers>(a => a.ReglementFichetier)
                                .WithMany(d => d.GES_Reglement)
                                .HasForeignKey<long?>(a => a.ReglementIdtiers);
            HasOptional<GEN_Tiers>(a => a.ReglementFichetier)
                                .WithMany(d => d.GES_Reglement)
                                .HasForeignKey<long?>(a => a.ReglementIdmoyenpaiement);

            HasOptional<GEN_Tiers>(a => a.ReglementFichetier)
                          .WithMany(d => d.GES_Reglement)
                          .HasForeignKey<long?>(a => a.ReglementBanqueId);
        }
    }
}
