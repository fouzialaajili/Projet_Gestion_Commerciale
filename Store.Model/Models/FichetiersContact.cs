using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class FichetiersContact
    {
        public int FichetiersContactId { get; set; }
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
        public int FichetiersContactSysuser { get; set; }

        public DateTime? FichetiersContactSysDateCreation { get; set; }
        public DateTime? FichetiersContactSysDateUpdate { get; set; }
        public int FichetiersId { get; set; }
        public FichetiersContact()
        {
            FichetiersContactSysDateCreation = DateTime.Now;
        }

        public Fichetiers Fichetiers { get; set; }




    }
}
