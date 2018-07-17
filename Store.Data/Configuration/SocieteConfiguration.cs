using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class SocieteConfiguration : EntityTypeConfiguration<Societe>
    {
        public SocieteConfiguration()
        {
            ToTable("Societe");
            HasKey(x => x.SocieteId);


            /***********************************/
         // virtual public Tva SocieteTva { get; set; }




       

        }
    }
}
