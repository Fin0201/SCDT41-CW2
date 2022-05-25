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
        public List<Timelog> TimeLogList { get; set; }

        public CosmeticService(string description, bool isOpen)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = DateTime.Now;
            IsOpen = isOpen;
            PurchaseList = new List<Purchase>();
            TimeLogList = new List<Timelog>();
        }

        public override string ToString()
        {
            return $"Description: {Description}, Is Open: {IsOpen}, Created On: {Timestamp}";
        }
    }
}
