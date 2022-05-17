using Xunit;
using SCDT41_CW2;

namespace UnitTests
{
    public class UnitTestProperties
    {
        [Fact]
        public void ComercialPropertyTest()
        {
            Commercial propertyToTest;

            
            propertyToTest = new Commercial("21 Street Rd", "Fin's Furniture", Enums.CommercialProperty.WAREHOUSE, 1000);
            var testString = propertyToTest.ToString();

            
            Assert.Equal("Address: 21 Street Rd Business Name: Fin's Furniture Type: WAREHOUSE Size: 1000", testString);
        }
    }
}
