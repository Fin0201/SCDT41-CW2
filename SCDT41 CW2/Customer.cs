using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public class Customer : IPerson
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }

        public Customer(string fname, string lname)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
        }

        public override string ToString()
        {
            return $"Name: {Fname} {Lname}";
        }
    }
}
