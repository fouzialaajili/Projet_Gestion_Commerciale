﻿using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Pivot
{
    public class ImpressionPivot
    {
        public long ImpressionId { get; set; }
        public long ImpressionType { get; set; }
        public string ImpressionChemin { get; set; }
        public string ImpressionLogo { get; set; }
        /***/
        public long ImpressionSocieteId { get; set; }
        public  DossiersPivot ImpressionSociete { get; set; }
    }
}
