﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    internal class Tenant
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public Tenant(string fname, string lname)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
        }
    }
}
