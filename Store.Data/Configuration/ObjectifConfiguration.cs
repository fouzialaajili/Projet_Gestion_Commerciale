using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ObjectifConfiguration : EntityTypeConfiguration<Objectif>
    {
        public ObjectifConfiguration()
        {
            ToTable("Objectif");
            HasKey(x => x.ObjectifId);


            /***********************************/
        //      virtual public Societe ObjectifSociete { get; set; }
        //virtual public Representant ObjectifRepresentant { get; set; }




        HasOptional<Societe>(a => a.ObjectifSociete)
                      .WithMany(d => d.SocieteObject)
                      .HasForeignKey<long?>(a => a.ObjectifSocieteId);

            HasOptional<Representant>(a => a.ObjectifRepresentant)
                          .WithMany(d => d.RepresentantObject)
                          .HasForeignKey<long?>(a => a.ObjectifRepresentantId);
        }
    }
}
