using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Societe
    {
        public int SocieteId { get; set; }
        public string SocieteRaisonSociale { get; set; }
        public string SocieteAdresse { get; set; }
        public string SocieteAdrlivraison { get; set; }
        public string SocieteTel { get; set; }
        public string SocieteFax { get; set; }
        public string SocieteEmail { get; set; }
        public string SocieteVille { get; set; }
        public string SocietePays { get; set; }
        public int SocieteCapital { get; set; }
        public string SocieteForme { get; set; }
        public string SocieteActivite { get; set; }
       public int SocieteIdentifiantFiscale { get; set; }
       public int TvaId{ get; set; }
       public decimal SocieteIce{ get; set; }
        public int SocietePatente { get; set; }
        public int SocieteRc{ get; set; }
        public string SocieteConditions { get; set; }

      public bool SocieteActif { get; set; }
        public int SocieteSysuser { get; set; }
        public DateTime? SocieteSysDateCreation { get; set; }
      //  public Tva Tva { get; set; }
        public DateTime? SocieteSysDateUpdate { get; set; }

        public Societe()
        {
            SocieteSysDateCreation = DateTime.Now;
        }


    }
}
