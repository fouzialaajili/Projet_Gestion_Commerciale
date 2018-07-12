using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Models
{
    public class Licence
 {
     public int LicenceId { get; set; }
      public int LicenceNumeroSerieid
      { get; set; }
     public string LicenceRaisonSociale
        { get; set; }
      public int LicenceNombreSociete { get; set; }
      public int LicenceNombreUser { get; set; }
       public bool LicenceActif { get; set; }
        public string LicenceCHash { get; set; }
       public DateTime LicenceDateFinContrat { get; set; }
       public string LicenceRenouvellable { get; set; }
       public DateTime LicenceSys_DateCreation { get; set; }
      public DateTime LicenceSys_DateUpdate { get; set; }

}
}
