using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ReglementFactureConfiguration : EntityTypeConfiguration<ReglementFacture>
    {
        public ReglementFactureConfiguration()
        {
            ToTable("ReglementFacture");
            HasKey(x => x.ReglementFactureId);


            /***********************************/
            //    virtual public Societe ReglementSociete { get; set; }
            //virtual public Fichetiers ReglementFichetier { get; set; }
            
        }
        }
}
