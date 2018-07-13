﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class DepotConfiguration : EntityTypeConfiguration<Depot>
    {
        public DepotConfiguration()
        {
            ToTable("Depot");
            HasKey(a => a.DepotId);

        }
    }
}