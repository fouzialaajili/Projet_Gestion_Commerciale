using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Profil
    {
        public int ProfilId { get; set; }
        public string ProfilCode { get; set; }
        public string ProfilDescription { get; set; }
        public int OpportuniteSysuser { get; set; }
        public DateTime? ProfilSysDateCreation { get; set; }
        public DateTime? ProfilSysDateUpdate { get; set; }

        public Profil()
        {
            ProfilSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
