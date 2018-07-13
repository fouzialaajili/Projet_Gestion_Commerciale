using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class ProfilDetail
    {
        public int ProfilDetailId { get; set; }
        public int ProfilId { get; set; }
        public bool ProfilDetailToadd { get; set; }
        public bool ProfilDetailTodelete{ get; set; }
        public bool ProfilDetailToupdate { get; set; }
        public bool ProfilDetailToconsult{ get; set; }
        public string ProfilDetailNomentite { get; set; }
        public int ProfilDetailSysuser { get; set; }
        public DateTime? ProfilDetailSysDateCreation { get; set; }
        public DateTime? ProfilDetailSysDateUpdate { get; set; }

        public ProfilDetail()
        {
            ProfilDetailSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
        public Profil Profil { get; set; }


    }
}
