using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class ProfilDetail
    {
        public long ProfilDetailId { get; set; }
        public long ProfilId { get; set; }
        public bool ProfilDetailToadd { get; set; }
        public bool ProfilDetailTodelete{ get; set; }
        public bool ProfilDetailToupdate { get; set; }
        public bool ProfilDetailToconsult{ get; set; }
        public string ProfilDetailNomentite { get; set; }
        public long ProfilDetailSysuser { get; set; }
        public DateTime? ProfilDetailSysDateCreation { get; set; }
        public DateTime? ProfilDetailSysDateUpdate { get; set; }

        public ProfilDetail()
        {
            ProfilDetailSysDateCreation = DateTime.Now;
        }
     /****/   public long SocieteId { get; set; }
        virtual public Societe Societe { get; set; }
        virtual public Profil Profil { get; set; }


    }
}
