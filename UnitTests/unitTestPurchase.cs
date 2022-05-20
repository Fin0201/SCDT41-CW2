using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCDT41_CW2;
using Xunit;

namespace UnitTests
{
    public class unitTestPurchase
    {
        [Fact]
        public void PurchaseTest()
        {
            Purchase purchaseTest;

            purchaseTest = new Purchase("Vacuum", 9.99, new TeamMember("Jeff", "Jefferson", "Username123", "Password123", Enums.EmployeeType.CLEANER));
            string? purchaseString = purchaseTest.ToString();

            Assert.IsType<Purchase>(purchaseTest);
            Assert.Equal(purchaseString, $"ID: {purchaseTest.Id}, Desc: Vacuum, Cost: £9.99, Created On: {DateTime.Now}");
        }
    }
}
