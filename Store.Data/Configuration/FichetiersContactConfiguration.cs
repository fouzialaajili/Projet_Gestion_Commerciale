using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class FichetiersContactConfiguration: EntityTypeConfiguration<FichetiersContact>
    {
        public FichetiersContactConfiguration()
        {
            ToTable("FichetiersContact");
            HasKey(x => x.FichetiersContactId);


            /***********************************/
            
            //   virtual public Fichetiers FichetiersContactFichetier { get; set; }


            HasOptional<Fichetier>(a => a.FichetiersContactFichetier)
                    .WithMany(d => d.FichetiersFichetiersContact)
                    .HasForeignKey<long?>(a => a.FichetierContactIdFicheTiers);
        }
           

        }
    }
