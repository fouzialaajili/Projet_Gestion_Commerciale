using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class DocumentCommercialDetail
    {
      public long  DocumentCommercialDetailId { get; set; }
        public string DocumentCommercialDetailDesignation { get; set; }
        public string DocumentCommercialDetailDescription { get; set; }
    public int DocumentCommercialDetailQuantite { get; set; }
        public double DocumentCommercialDetailPrixUnitaireHTTC { get; set; }
        public double DocumentCommerciaDetailTVATC { get; set; }
        public double DocumentCommercialDetailTTCTC { get; set; }
        public int  DocumentCommercialDetailDevise { get; set; }
        public double DocumentCommercialDetailPrixUnitaireHTDevise { get; set; }
          public int  DocumentCommercialDetailTVADevise { get; set; }
         public string   DocumentCommercialDetailTTCDevise { get; set; }
           public int  DocumentCommercialDetailCoursDevise { get; set; }
         public int   DocumentCommercialDetailRemise { get; set; }
public int DocumentCommercialDetailCodeLiaison { get; set; }
          public int  DocumentCommercialDetailStatutLigne { get; set; }
        public int DocumentCommercialSysuser { get; set; }
        public DateTime DocumentCommercialSysDateCreation { get; set; }
        public DateTime DocumentCommercialSysDateUpdate { get; set; }
        public long DocumentCommercialDetailArticlesId { get; set; }
        public virtual Articles DocumentCommercialDetailArticles { get; set; }
        public  long DocumentCommercialIdDocumentCommercial { get; set; }
      public virtual DocumentCommercial DocumentCommercialDetailDocumentCommercial { get; set; }


    }
}
