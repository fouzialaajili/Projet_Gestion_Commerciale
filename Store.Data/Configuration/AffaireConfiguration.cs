﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class AffaireConfiguration : EntityTypeConfiguration<Affaire>
    {
        public AffaireConfiguration()
        {
            ToTable("Affaire");
            HasKey(a => a.AffaireId);
            HasOptional<Societe>(a => a.AffaireSociete)
            .WithMany(d => d.SocieteAffaire)
             .HasForeignKey<long?>(a => a.AffaireSocieteId);
        }
    }
}
