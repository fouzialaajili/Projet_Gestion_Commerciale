﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class CPT_CodesTVAConfiguration : EntityTypeConfiguration<CPT_CodesTVA>
    {

        public CPT_CodesTVAConfiguration()
        {
            ToTable("Dossier");
            HasKey(x => x.Id);
            HasOptional<GEN_Dossiers>(a => a.TvaSociete)
         .WithMany(d => d.SocieteTVA)
          .HasForeignKey<long?>(a => a.TvaSocieteId);
        }
    }
   
        }
 
