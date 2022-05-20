using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    public class ProblemService : IService
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public SeverityPriority Severity { get; set; }
        public bool IsOpen { get; set; }
        public List<Purchase> PurchaseList { get; set; }
        public List<Timelog> TimeLogList { get; set; }

        public ProblemService(string description, SeverityPriority severity)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = DateTime.Now;
            Severity = severity;
            IsOpen = true;
            PurchaseList = new List<Purchase>();
            TimeLogList = new List<Timelog>();
        }

        public override string? ToString()
        {
            return $"Description: {Description}, Priority: {Severity}, Created On: {Timestamp}";
        }
    }
}
