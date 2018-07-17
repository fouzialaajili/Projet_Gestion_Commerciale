using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class FichetiersContact
    {
        public long FichetiersContactId { get; set; }
        public string FichetiersContactNom { get; set; }
        public string FichetiersContactPrenom { get; set; }
        public string FichetiersContactAdresse { get; set; }
        public string FichetiersContactTel { get; set; }
        public string FichetiersContactGSM { get; set; }
        public string FichetiersContactFonction { get; set; }
        public string FichetiersContactEmail { get; set; }
        public string FichetiersContactVille { get; set; }
        public string FichetiersContactPays { get; set; }
        public bool FichetiersContactActif { get; set; }
        public long FichetiersContactSysuser { get; set; }

        public DateTime? FichetiersContactSysDateCreation { get; set; }
        public DateTime? FichetiersContactSysDateUpdate { get; set; }
      /***/  public long FichetierContactIdFicheTiers { get; set; }
        public FichetiersContact()
        {
            FichetiersContactSysDateCreation = DateTime.Now;
        }

        virtual public Fichetier FichetiersContactFichetier { get; set; }


        public virtual ICollection<Ticket> FichetiersContactTicket { get; set; }

    }
}
