using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class DocumentCommercialConfiguration : EntityTypeConfiguration<DocumentCommercial>
    {
        public DocumentCommercialConfiguration()
        {
            ToTable("DocumentCommercial");
            HasKey(a => a.DocumentCommercialId);
        }
    }
}
