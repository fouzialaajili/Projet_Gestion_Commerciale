using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    class PreferencesPivot
    {
        public long Id { get; set; }


        public string IdUsers { get; set; }

        public long IdDossier { get; set; }

        public long IdExercices { get; set; }

        public virtual GEN_Dossiers GEN_Dossiers { get; set; }

        public virtual GEN_Exercices GEN_Exercices { get; set; }
    }
}
