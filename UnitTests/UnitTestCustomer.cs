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
            Customer customerTest;

            customerTest = new Customer("Finley", "Edwards");
            var customerString = customerTest.ToString();

            Assert.IsType<Customer>(customerTest);
            Assert.Equal(customerString, $"Name: Finley Edwards");
        }
    }
}
