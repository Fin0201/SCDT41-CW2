using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public class CosmeticService : IService
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsOpen { get; set; }
        public List<Purchase> PurchaseList { get; set; }
        public List<TimeLlog> TimeLogList { get; set; }

        public CosmeticService(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = DateTime.Now;
            IsOpen = true;
            PurchaseList = new List<Purchase>();
            TimeLogList = new List<TimeLlog>();
        }

        public override string ToString()
        {
            return $"Description: {Description}, Created On: {Timestamp}";
        }
    }
}
