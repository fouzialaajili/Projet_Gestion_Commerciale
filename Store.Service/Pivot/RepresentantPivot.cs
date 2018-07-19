using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class RepresentantPivot
    {
        public long RepresentantId { get; set; }
        public string RepresentantCode { get; set; }
        public string RepresentantCivilite { get; set; }
        public string RepresentantNom { get; set; }
        public string RepresentantAdresse { get; set; }
        public string RepresentantTelephone { get; set; }
        public string RepresentantGsm { get; set; }
        public string RepresentantVille { get; set; }
        public string RepresentantPays { get; set; }
        public string RepresentantEmail { get; set; }
        public string RepresentantFonction { get; set; }
        public bool RepresentantActif { get; set; }
        public bool RepresentantAcheteur { get; set; }
        public bool RepresentantVenseur { get; set; }
        public string RepresentantLogin { get; set; }
        public string RepresentantPasswoord { get; set; }

        public long RepresentantProfil { get; set; }

        public bool RepresentantBc { get; set; }

        public long RepresentantSysuser { get; set; }
        public DateTime? RepresentantSysDateCreation { get; set; }
        public DateTime? ZenRepresentantSysDateUpdate { get; set; }

       
        /***/
        public long RepresentantDossierId { get; set; }
     public GEN_Dossiers RepresentantDossier { get; set; }
        public ICollection<GES_Objectif> RepresentantObject { get; set; }
        public ICollection<GEN_Tiers> RepresentantFichetier { get; set; }
        public  ICollection<GES_Ticket> RepresentantTicket { get; set; }
    }
}
