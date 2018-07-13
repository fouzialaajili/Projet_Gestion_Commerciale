using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class DoclieartConfiguration : EntityTypeConfiguration<Doclieart>
    {
        public DoclieartConfiguration()
        {
            ToTable("Doclieart");
            HasKey(a => a.DoclieartId);

        }
    }
}
