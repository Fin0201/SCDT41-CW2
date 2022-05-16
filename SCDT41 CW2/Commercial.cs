using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    internal class Commercial
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public CommercialProperty PropertyType { get; set; }
        public string NameOfBusiness { get; set; }
        public double SizeInMeters { get; set; }

        public Commercial(string address, CommercialProperty propertyType, string nameOfBusiness, double sizeInMeters)
        {
            Id = Guid.NewGuid();
            Address = address;
            PropertyType = propertyType;
            NameOfBusiness = nameOfBusiness;
            SizeInMeters = sizeInMeters;
        }

        public override string ToString()
        {
            return $"Address: {Address} Business name: {NameOfBusiness} Type: {PropertyType} Size: {SizeInMeters}";
        }
    }
}
