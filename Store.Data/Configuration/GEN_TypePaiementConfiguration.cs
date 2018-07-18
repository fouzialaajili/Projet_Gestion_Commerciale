﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GEN_TypePaiementConfiguration : EntityTypeConfiguration<GEN_TypePaiement>
    {
        public GEN_TypePaiementConfiguration()
        {
            ToTable("TypePaiement");
            HasKey(x => x.TypePaiementId);


            /***********************************/
            // public virtual GEN_Dossiers GEN_Dossiers { get; set; }


            HasOptional<GEN_Dossiers>(a => a.GEN_Dossiers)
                    .WithMany(d => d.GEN_TypePaiement)
                    .HasForeignKey<long?>(a => a.IdDossier);


        }
    }
}
