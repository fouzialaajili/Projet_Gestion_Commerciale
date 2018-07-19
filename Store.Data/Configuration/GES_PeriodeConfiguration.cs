﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GES_PeriodeConfiguration : EntityTypeConfiguration<GES_Periode>
    {
        public GES_PeriodeConfiguration()
        {
            ToTable("Periode");
            HasKey(x => x.PeriodeId);


            /***********************************/
            //        virtual public GEN_Dossiers PeriodeSociete { get; set; }


            HasOptional<GEN_Dossiers>(a => a.PeriodeSociete)
                            .WithMany(d => d.GES_Periode)
                            .HasForeignKey<long?>(a => a.PeriodeSocieteId);


        }
    }
}
