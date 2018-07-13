using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class DocumentCommercialDetailSerieConfiguration : EntityTypeConfiguration<DocumentCommercialDetailSerie>
    {
        public DocumentCommercialDetailSerieConfiguration()
        {
            ToTable("DocumentCommercialDetailSerie");
            HasKey(a => a.DocumentCommercialDetailSerieId);

        }
    }
}
