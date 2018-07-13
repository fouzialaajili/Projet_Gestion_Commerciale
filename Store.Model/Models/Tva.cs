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
       public long  SocieteId { get; set; }
       public virtual Societe Societe { get; set; }
   }
}
