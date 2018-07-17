using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class PaiementConfiguration : EntityTypeConfiguration<Paiement>
    {
        public PaiementConfiguration()
        {
            ToTable("Paiement");
            HasKey(x => x.PaiementId);


            /***********************************/
  //virtual public Societe PaiementSociete { get; set; }


        HasOptional<Societe>(a => a.PaiementSociete)
                    .WithMany(d => d.SocietePaiement)
                    .HasForeignKey<long?>(a => a.PaiementSocieteId);


        }
    }
}
