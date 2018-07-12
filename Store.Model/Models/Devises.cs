﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model.Models
{
    public class Devises
    {
        public int DevisesId { get; set; }
        public string DevisesCode { get; set; }
        public string DevisesCodeIso { get; set; }
        public string  DevisesDescription { get; set; }
        public Double DevisesCoursDevise { get; set; }
        public bool DevisesTenuedecompte { get; set; }
        public bool DevisesTenuedeActif { get; set; }
        public int DevisesSysuser { get; set; }
        public DateTime DevisesSysDateCreation { get; set; }
        public DateTime DevisesSysDateUpdate { get; set; }
        public int SocieteId { get; set; }
        public Societe Societe { get; set; }
    }
}