using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Paiement
    {
        public long PaiementId { get; set; }
        public string PaiementCode { get; set; }
        public string PaiementIntitule { get; set; }
        public int PaiementType { get; set; }
        public int PaiementEcheance { get; set; }

        public long PaiementSysuser { get; set; }

        public DateTime? PaiementSysDateCreation { get; set; }
        public DateTime? PaiementSysDateUpdate { get; set; }

        public Paiement()
        {
            PaiementSysDateCreation = DateTime.Now;
        }

        /**/
        public long PaiementSocieteId { get; set; }
    

        virtual public Societe PaiementSociete { get; set; }


        public virtual ICollection<Fichetier> PaiementFichetier { get; set; }
    }
}
