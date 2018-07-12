using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Famille
    {
        public int FamilleId { get; set; }
        public int FamilleCode { get; set; }
        public int FamilleLibelle { get; set; }
public int FamilleSys_user { get; set; }
        public DateTime FamilleSys_DateCreation { get; set; }
        public DateTime FamilleSys_DateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
