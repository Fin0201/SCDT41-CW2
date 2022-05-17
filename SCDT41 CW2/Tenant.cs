using System;
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

        public Tenant(Guid id, string fname, string lname)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
        }
    }
}
