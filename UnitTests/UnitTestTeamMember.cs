using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCDT41_CW2;
using Xunit;

namespace UnitTests
{
    public class UnitTestTeamMember
    {
        [Fact]
        public void TeamMemberTest()
        {
            //Arrange
            TeamMember teamMemberTest;

            //Act
            teamMemberTest = new TeamMember("Bob", "Bobbington", "Username123", "Password123", Enums.EmployeeType.ADMIN);
            string? teamMemberString = teamMemberTest.ToString();

            //Assert
            Assert.IsType<TeamMember>(teamMemberTest);
            Assert.Equal(teamMemberString, $"Name: Bob Bobbington, Type: ADMIN");
        }
    }
}
