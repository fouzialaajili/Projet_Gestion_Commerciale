using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    class Ged
    {
        public int GedId { get; set; }
        public long? GedTypeFichier { get; set; }
        public string GedLibelleFichier { get; set; }
        public string GedDescriptionFichier{ get; set; }
        public string GedFichierSource { get; set; }
        public string GedEntiteName { get; set; }
        public int GedIdEntite { get; set; }
        public int GedSysuser { get; set; }

        public DateTime? GedSysDateCreation { get; set; }
        public DateTime? GedSysDateUpdate { get; set; }

        public Ged()
        {
            GedSysDateCreation = DateTime.Now;
        }

    }
}
