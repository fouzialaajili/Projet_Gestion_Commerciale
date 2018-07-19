﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class GES_FamilleConfiguration : EntityTypeConfiguration<GES_Famille>
    {
        public  GES_FamilleConfiguration(){
            ToTable("Famille");
            HasKey(a => a.FamilleId);
            HasOptional<GEN_Dossiers>(a => a.FamilleSociete)
            .WithMany(d => d.SocieteFamille)
            .HasForeignKey<long?>(a => a.FamilleSocieteId);

        }

    }
}
