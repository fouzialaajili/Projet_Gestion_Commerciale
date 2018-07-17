﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class GedConfiguration : EntityTypeConfiguration<Ged>
    {
        public GedConfiguration()
        {
            ToTable("Ged");
            HasKey(x => x.GedId);
           
        }
    }
}
