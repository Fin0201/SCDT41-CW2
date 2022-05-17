using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public interface IService
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Open { get; set; }
        public TeamMember Employee { get; set; }
        public List<TimeLog> TimeLogList { get; set; }
    }
}
