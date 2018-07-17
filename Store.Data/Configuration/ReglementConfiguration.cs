using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    class ReglementConfiguration : EntityTypeConfiguration<Reglement>
    {
        public ReglementConfiguration()
        {
            ToTable("Reglement");
            HasKey(x => x.ReglementId);


            /***********************************/
        //    virtual public Societe ReglementSociete { get; set; }
        //virtual public Fichetiers ReglementFichetier { get; set; }


        HasOptional<Societe>(a => a.ReglementSociete)
                            .WithMany(d => d.SocieteReglement)
                            .HasForeignKey<long?>(a => a.ReglementSocieteId);

            HasOptional<Fichetier>(a => a.ReglementFichetier)
                                .WithMany(d => d.FichetiersReglement)
                                .HasForeignKey<long?>(a => a.ReglementIdtiers);
            HasOptional<Fichetier>(a => a.ReglementFichetier)
                                .WithMany(d => d.FichetiersReglement)
                                .HasForeignKey<long?>(a => a.ReglementIdmoyenpaiement);

            HasOptional<Fichetier>(a => a.ReglementFichetier)
                          .WithMany(d => d.FichetiersReglement)
                          .HasForeignKey<long?>(a => a.ReglementBanqueId);
        }
    }
}
