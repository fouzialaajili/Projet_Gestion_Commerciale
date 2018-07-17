﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ArticlesKitConfiguration : EntityTypeConfiguration<ArticlesKit>
    {
        public ArticlesKitConfiguration(){
            ToTable("ArticlesKit");
            HasKey(a => a.ArticlesKitId);
        }
    }
}