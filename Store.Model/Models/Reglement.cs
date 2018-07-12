using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Reglement
    {
        public int ReglementId {get;set;}
        public long? ReglementType { get; set; }
        public string ReglementReference { get; set; }
        public string ReglementLibelle { get; set; }
        public DateTime? ReglementDatereglement { get; set; }
        public DateTime? ReglementDateecheance { get; set; }
        public int FichetiersIdtiers { get; set; }
/****/      public int ReglementIdmoyenpaiement { get; set; }
        public int DevisesId { get; set; }
        public int ReglementMontant { get; set; }
 /***/    public int ReglementBanqueId { get; set; }
        public string ReglementStatut { get; set; }
        public string ReglementEtat { get; set; }
        public DateTime? ReglementDatePaiement { get; set; }
        public bool ReglementPaye { get; set; }
        public int ReglementNumreleve { get; set; }
        public int ReglementSysuser { get; set; }
        public DateTime? ReglementSysDateCreation { get; set; }
        public DateTime? ReglementSysDateUpdate { get; set; }

        public Reglement()
        {
            ReglementSysDateCreation = DateTime.Now;
        }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }





    }
}
