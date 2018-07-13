using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Profil
    {
        public long ProfilId { get; set; }
        public string ProfilCode { get; set; }
        public string ProfilDescription { get; set; }
        public long OpportuniteSysuser { get; set; }
        public DateTime? ProfilSysDateCreation { get; set; }
        public DateTime? ProfilSysDateUpdate { get; set; }

        public Profil()
        {
            ProfilSysDateCreation = DateTime.Now;
        }
    /***/    public long SocieteId { get; set; }
        virtual public Societe Societe { get; set; }
    }
}
