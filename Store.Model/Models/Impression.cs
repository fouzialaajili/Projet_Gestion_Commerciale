using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   
 public class Impression
  {
      public int ImpressionId { get; set; }
      public long ImpressionType { get; set; }
     public string ImpressionChemin { get; set; }
      public string ImpressionLogo { get; set; }
      public int SocieteId { get; set; }
       public Societe Societe { get; set; }


    }
}
