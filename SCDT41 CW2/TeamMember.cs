using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    public class TeamMember : IPerson, IEmployee
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public EmployeeType StaffType { get; set; }

        public TeamMember(string fname, string lname, string username, string password, EmployeeType StaffType)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Lname = lname;
            Username = username;
            Password = password;
            StaffType = EmployeeType.CLEANER;
        }

        public override string? ToString()
        {
            return $"Name: {Fname} {Lname}, Type: {StaffType}";
        }
    }
}
