using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Affaire
    {
         public long AffaireId { get; set; }
         public string AffaireCode { get; set; }
      public string AffaireLibelle
        { get; set; }

   
        public int AffaireSysuser { get; set; }
        public DateTime AffaireSysDateCreation { get; set; }
        public DateTime AffaireSysDateUpdate { get; set; }
<<<<<<< HEAD
        public int SocieteId { get; set; }
        virtual public Societe Societe { get; set; }
=======
        public long AffaireSocieteId { get; set; }
        public virtual  Societe AffaireSociete { get; set; }
>>>>>>> 2267e92627d70391d6d45f5590325e078926f7fb
    }
}
