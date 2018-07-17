using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class RepresentantConfiguration : EntityTypeConfiguration<Representant>
    {
        public RepresentantConfiguration()
        {
            ToTable("Representant");
            HasKey(x => x.RepresentantId);


            /***********************************/
            //        virtual public Societe RepresentantSociete { get; set; }



            HasOptional<Societe>(a => a.RepresentantSociete)
                    .WithMany(d => d.SocieteRepresentant)
                    .HasForeignKey<long?>(a => a.RepresentantSocieteId);



        }
    }
}
