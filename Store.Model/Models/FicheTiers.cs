using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Fichetiers
    {
        public int FichetiersId { get; set; }
        public string FichetiersNatureTiers { get; set; }
        public string FichetiersCode { get; set; }
        public string FichetiersRaisonSociale { get; set; }
        public string FichetiersActivite { get; set; }
        public string FichetiersAdresse { get; set; }

        public string FichetiersAdresseLivraison { get; set; }
        public string FichetiersTel { get; set; }
        public string FichetiersFax { get; set; }
        public string FichetiersEmail { get; set; }

        public string FichetiersVille { get; set; }
        public string FichetiersPays { get; set; }

        public int FichetiersIdentifiantFiscale { get; set; }
        public int TvaId { get; set; }
        public int FichetiersIce { get; set; }
        public int FichetiersPatente { get; set; }
        public int RepresentantId { get; set; }
        public int FichetiersDeviseFacturation { get; set; }
        public int FichetiersEncours { get; set; }
        public int PaiementId { get; set; }
        public string FichetiersRisque { get; set; }
        public bool FichetiersActif { get; set; }
        public int FichetiersSys_user { get; set; }
        public DateTime? FichetiersSysDateCreation { get; set; }
        public DateTime? FichetiersSysDateUpdate { get; set; }

        public Fichetiers()
        {
            FichetiersSysDateCreation = DateTime.Now;
        }

        public int SocieteId { get; set; }
        public Representant Representant { get; set; }

        public Societe Societe { get; set; }
        public Paiement Paiement { get; set; }
        public Tva Tva { get; set; }



    
}
}
