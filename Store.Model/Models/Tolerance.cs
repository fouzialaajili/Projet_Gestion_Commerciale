﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
   public  class Tolerance
    {
        public int ToleranceId { get; set; }
        public int ToleranceEntier { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}
