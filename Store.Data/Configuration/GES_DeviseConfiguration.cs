﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
   public  class GES_DeviseConfiguration : EntityTypeConfiguration<GEN_Devises>
    {
        public GES_DeviseConfiguration()
        {
            ToTable("Devise");
            HasKey(a => a.DevisesId);


            HasOptional<GEN_Dossiers>(a => a.DeviseSociete)
.WithMany(d => d.SocieteDevise)
.HasForeignKey<long?>(a => a.DeviseSocieteId);
        }
    }
}
