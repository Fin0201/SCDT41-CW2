using Xunit;
using SCDT41_CW2;

namespace UnitTests
{
    public class UnitTestProperties
    {
        [Fact]
        public void CommercialPropertyTest()
        {
            Commercial propertyToTest;

            propertyToTest = new Commercial("21 Street Rd", "Fin's Furniture", Enums.CommercialProperty.WAREHOUSE, 1000);
            var testString = propertyToTest.ToString();

            Assert.Equal("Address: 21 Street Rd, Business Name: Fin's Furniture, Type: WAREHOUSE, Size: 1000", testString);
        }

        [Fact]
        public void DomesticPropertyTest()
        {
            Domestic propertyToTest;

            propertyToTest = new Domestic("89 Big Road", Enums.DomesticProperty.COTTAGE, 2);
            var testString = propertyToTest.ToString();

            Assert.Equal("Address: 89 Big Road, Type: COTTAGE, Number of Bedrooms: 2", testString);
        }
    }
}
