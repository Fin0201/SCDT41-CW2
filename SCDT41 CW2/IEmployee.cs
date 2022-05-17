using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    public interface IEmployee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public EmployeeType StaffType { get; set; }
    }
}
