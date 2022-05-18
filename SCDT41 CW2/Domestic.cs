using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    public class Domestic : IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public DomesticProperty PropertyType { get; set; }
        public int NumberOfBedrooms { get; set; }
        public Customer CurrentOwner { get; set; }
        public List<IService> NeededServices { get; set; }

        public Domestic(string address, DomesticProperty propertyType, int numberOfBedrooms, Customer currentOwner)
        {
            Id = Guid.NewGuid();
            Address = address;
            PropertyType = propertyType;
            NumberOfBedrooms = numberOfBedrooms;
            CurrentOwner = currentOwner;
            NeededServices = new List<IService>();
        }

        public override string ToString()
        {
            return $"Address: {Address}, Type: {PropertyType}, Number of Bedrooms: {NumberOfBedrooms}";
        }
    }
}
