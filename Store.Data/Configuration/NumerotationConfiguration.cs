using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class NumerotationConfiguration : EntityTypeConfiguration<Numerotation>
    {
        public NumerotationConfiguration()
        {
            ToTable("Numerotation");
            HasKey(x => x.NumerotationId);


            /***********************************/
            // virtual public Societe NumerotationSociete { get; set; }




            HasOptional<Societe>(a => a.NumerotationSociete)
                      .WithMany(d => d.SocieteNumerotation)
                      .HasForeignKey<long?>(a => a.NumerotationSocieteId);
        }
    }
}
