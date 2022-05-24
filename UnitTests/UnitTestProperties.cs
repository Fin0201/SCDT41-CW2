using Xunit;
using SCDT41_CW2;

namespace UnitTests
{
    public class UnitTestProperties
    {
        [Fact]
        public void CommercialPropertyTest()
        {
            //Arrange
            Commercial propertyTest;

            //Act
            propertyTest = new Commercial("21 Street Rd", "Fin's Furniture", Enums.CommercialProperty.WAREHOUSE, 1000, new Customer("Finley", "Edwards"));
            var commercialString = propertyTest.ToString();

            //Assert
            Assert.IsType<Commercial>(propertyTest);
            Assert.Equal("Address: 21 Street Rd, Business Name: Fin's Furniture, Type: WAREHOUSE, Size: 1000", commercialString);
        }

        [Fact]
        public void DomesticPropertyTest()
        {
            //Arrange
            Domestic propertyTest;

            //Act
            propertyTest = new Domestic("89 Big Road", Enums.DomesticProperty.COTTAGE, 2, new Customer("Finley", "Edwards"));
            var domesticString = propertyTest.ToString();

            //Assert
            Assert.IsType<Domestic>(propertyTest);
            Assert.Equal("Address: 89 Big Road, Type: COTTAGE, Number of Bedrooms: 2", domesticString);
        }
    }
}
