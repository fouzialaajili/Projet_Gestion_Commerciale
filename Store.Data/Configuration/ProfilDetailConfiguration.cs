using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ProfilDetailConfiguration : EntityTypeConfiguration<ProfilDetail>
    {
        public ProfilDetailConfiguration()
        {
            ToTable("ProfilDetail");
            HasKey(x => x.ProfilDetailId);


            /***********************************/
            // virtual public Societe ProfilDetailSociete  { get; set; }


            HasOptional<Societe>(a => a.ProfilDetailSociete)
                            .WithMany(d => d.SocieteProfilDetail)
                            .HasForeignKey<long?>(a => a.ProfilDetailSocieteId);


        }
    }
}
