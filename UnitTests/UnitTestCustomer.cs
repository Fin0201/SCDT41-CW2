using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCDT41_CW2;
using Xunit;

namespace UnitTests
{
    public class UnitTestCustomer
    {
        [Fact]
        public void CustomerTest()
        {
            //Arrane
            Customer customerTest;

            //Act
            customerTest = new Customer("Finley", "Edwards");
            var customerString = customerTest.ToString();

            //Assert
            Assert.IsType<Customer>(customerTest);
            Assert.Equal(customerString, $"Name: Finley Edwards");
        }
    }
}
