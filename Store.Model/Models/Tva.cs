using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Tva
    {
      public long  TvaId { get; set; }
     public string TvaCode { get; set; }
  public int TvaTaux { get; set; }
     public string TvaLibelle
     { get; set; }
      public bool TvaPercu { get; set; }
  public int TvaSys_user { get; set; }
       public DateTime TvaSys_DateCreation { get; set; }
       public DateTime TvaSys_DateUpdate { get; set; }
<<<<<<< HEAD
       public int SocieteId { get; set; }
       public Societe Societe { get; set; }


        public virtual ICollection<Fichetiers> TvaFichetiers { get; set; }
        public virtual ICollection<Societe> TvaSociete { get; set; }
    }
=======
       public long  SocieteId { get; set; }
       public virtual Societe Societe { get; set; }
   }
>>>>>>> 2267e92627d70391d6d45f5590325e078926f7fb
}
