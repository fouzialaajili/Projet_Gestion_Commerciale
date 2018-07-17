using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ProfilConfiguration : EntityTypeConfiguration<Profil>
    {
        public ProfilConfiguration()
        {
            ToTable("Profil");
            HasKey(x => x.ProfilId);


            /***********************************/
            // virtual public Societe ProfilSociete { get; set; }


            HasOptional<Societe>(a => a.ProfilSociete)
                            .WithMany(d => d.SocieteProfil)
                            .HasForeignKey<long?>(a => a.ProfilSocieteId);


        }
    }
}
