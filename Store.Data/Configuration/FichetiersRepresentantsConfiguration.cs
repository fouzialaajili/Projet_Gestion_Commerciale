using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class FichetiersRepresentantsConfiguration : EntityTypeConfiguration<FichetiersRepresentant>
    {
        public FichetiersRepresentantsConfiguration()
        {
            ToTable("FichetiersRepresentant");
            HasKey(x => x.FichetierRepresentantId);


            /***********************************/
       
            //virtual public Societe FichetierRepresentantSociete { get; set; }

            HasOptional<Societe>(a => a.FichetierRepresentantSociete)
                .WithMany(d => d.SocieteFichetierRepresentant)
                .HasForeignKey<long?>(a => a.FichetierRepresentantSocieteId);

        }
    }
}