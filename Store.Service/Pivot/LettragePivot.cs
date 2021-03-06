namespace Store.Service.Pivot
{
    using System;
    using System.Collections.Generic;


    public partial class LettragePivot
    {
        public long Id { get; set; }

        public long? IdEcheance { get; set; }

        public double? MontantRegle { get; set; }

        public string CodeLettrage { get; set; }

        public DateTime? DateLettrage { get; set; }

     

        public string sys_user { get; set; }

        public DateTime? sys_dateUpdate { get; set; }

        public DateTime? sys_dateCreation { get; set; }

        public EcheancesPivot CPT_Echeances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        

        public  ICollection<TVALettragePivot> CPT_TVALettrage { get; set; }
    }
}
