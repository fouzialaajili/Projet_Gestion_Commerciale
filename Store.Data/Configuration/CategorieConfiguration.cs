using Store.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Configuration
{
    public class CategorieConfiguration : EntityTypeConfiguration<Categorie>
    {
        public CategorieConfiguration()
        {
            ToTable("Categorie");
            HasKey(a => a.CategorieId);
            HasOptional<Societe>(a => a.CategorieSociete)
.WithMany(d => d.SocieteCategorie)
.HasForeignKey<long?>(a => a.CategorieSocieteId);
             
    }
    }
}
