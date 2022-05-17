using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SCDT41_CW2.Enums;

namespace SCDT41_CW2
{
    public class Commercial
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string NameOfBusiness { get; set; }
        public CommercialProperty PropertyType { get; set; }
        public double SizeInMeters { get; set; }

        public Commercial(string address, string nameOfBusiness, CommercialProperty propertyType, double sizeInMeters)
        {
            Id = Guid.NewGuid();
            Address = address;
            NameOfBusiness = nameOfBusiness;
            PropertyType = propertyType;
            SizeInMeters = sizeInMeters;
        }

        public override string ToString()
        {
            return $"Address: {Address} Business Name: {NameOfBusiness} Type: {PropertyType} Size: {SizeInMeters}";
        }
    }
}
