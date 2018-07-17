using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public class Fichetier
    {

        public long FichetiersId { get; set; }
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
        /***/
        public long FichetierIdentifiantTVA { get; set; }
        public int FichetiersIce { get; set; }
        public int FichetiersPatente { get; set; }
        /***/
        public long FichetierIdrepresentant { get; set; }
        public int FichetiersDeviseFacturation { get; set; }
        public int FichetiersEncours { get; set; }
        /****/
        public long FichetierIdmodepaie { get; set; }
        public string FichetiersRisque { get; set; }
        public bool FichetiersActif { get; set; }
        public long FichetiersSysuser { get; set; }
        public DateTime? FichetiersSysDateCreation { get; set; }
        public DateTime? FichetiersSysDateUpdate { get; set; }

        public Fichetier()
        {
            FichetiersSysDateCreation = DateTime.Now;
        }

        /**/
        public long FichetierSocieteId { get; set; }
        virtual public Representant FichetierRepresentant { get; set; }

        virtual public Societe FichetierSociete { get; set; }
        virtual public Paiement FichetierPaiement { get; set; }
        virtual public Tva FichetierTva { get; set; }


        public virtual ICollection<FichetiersContact> FichetiersFichetiersContact { get; set; }
        public virtual ICollection<FournisseurArticle> FournisseurArticleFichetier { get; set; }
        public virtual ICollection<Ticket> FichetierTicket { get; set; }
        public virtual ICollection<TicketDetail> FichetiersTicketDetail { get; set; }

        public virtual ICollection<Opportunite> FichetiersOpportunite { get; set; }
        public virtual ICollection<OpportuniteDetail> FichetiersOpportuniteDetail { get; set; }
        public virtual ICollection<Reglement> FichetiersReglement { get; set; }
        public virtual ICollection<CrmContact> FichetiersCrmContact { get; set; }

    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Fichetiers
    {
        public long FichetiersId { get; set; }
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
 
public long FichetierIdentifiantTVA { get; set; }
public int FichetiersIce { get; set; }
public int FichetiersPatente { get; set; }

public long FichetierIdrepresentant { get; set; }
public int FichetiersDeviseFacturation { get; set; }
public int FichetiersEncours { get; set; }

public long FichetierIdmodepaie { get; set; }
public string FichetiersRisque { get; set; }
public bool FichetiersActif { get; set; }
public long FichetiersSys_user { get; set; }
public DateTime? FichetiersSysDateCreation { get; set; }
public DateTime? FichetiersSysDateUpdate { get; set; }

public Fichetiers()
{
    FichetiersSysDateCreation = DateTime.Now;
}


public long FichetierSocieteId { get; set; }
virtual public Representant FichetierRepresentant { get; set; }

virtual public Societe FichetierSociete { get; set; }
virtual public Paiement FichetierPaiement { get; set; }
virtual public Tva FichetierTva { get; set; }


public virtual ICollection<FichetiersContact> FichetiersFichetiersContact { get; set; }
public virtual ICollection<FournisseurArticle> FournisseurArticleFichetier { get; set; }
public virtual ICollection<Ticket> FichetierTicket { get; set; }
public virtual ICollection<TicketDetail> FichetiersTicketDetail { get; set; }

public virtual ICollection<Opportunite> FichetiersOpportunite { get; set; }
public virtual ICollection<OpportuniteDetail> FichetiersOpportuniteDetail { get; set; }
public virtual ICollection<Reglement> FichetiersReglement { get; set; }

    }
}
*/