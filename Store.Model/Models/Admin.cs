﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminLogin { get; set; }
        public string AdminPassword { get; set; }
        public bool AdminActif { get; set; }
    }
}