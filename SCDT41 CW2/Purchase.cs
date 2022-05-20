using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCDT41_CW2
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public double Cost { get; set; }
        public DateTime CreatedOn { get; set; }
        public TeamMember? CreatedBy { get; set; }
        public Purchase(string? description, double cost, TeamMember? createdBy)
        {
            Id = Guid.NewGuid();
            Description = description;
            Cost = cost;
            CreatedOn = DateTime.Now;
            CreatedBy = createdBy;
        }

        public override string? ToString()
        {
            return $"ID: {Id}, Desc: {Description}, Cost: £{Cost}, Created On: {CreatedOn}";
        }
    }
}
