using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCDT41_CW2;
using Xunit;

namespace UnitTests
{
    public class UnitTestTimelog
    {
        [Fact]
        public void timelogTest()
        {
            Timelog timelogTest;

            timelogTest = new Timelog(10, new TeamMember("Jeff", "Jefferson", "Username123", "Password123", Enums.EmployeeType.CLEANER));
            string? timelogString = timelogTest.ToString();

            Assert.IsType<Timelog>(timelogTest);
            Assert.Equal(timelogString, $"ID: {timelogTest.Id}, Time in Minutes: 10, Name: Jeff Jefferson, Type: ADMIN, Logged On: {DateTime.Now}");
        }
    }
}
