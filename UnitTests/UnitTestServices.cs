using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SCDT41_CW2;

namespace UnitTests
{
    public class UnitTestServices
    {
        [Fact]
        public void ProblemServiceToStringTest()
        {
            ProblemService problemService;

            problemService = new ProblemService("Fire Damage", Enums.SeverityPriority.HIGH);
            string? problemServiceString = problemService.ToString();

            Assert.IsType<ProblemService>(problemService);
            Assert.Equal(problemServiceString, $"Description: Fire Damage Priority: HIGH Created On: {DateTime.Now}");
        }

        [Fact]
        public void CosmeticServiceTest()
        {
            CosmeticService cosmeticService;

            cosmeticService = new CosmeticService("Vacuuming");
            string? cosmeticServiceString = cosmeticService.ToString();

            Assert.IsType<CosmeticService>(cosmeticService);
            Assert.Equal(cosmeticServiceString, $"Description: Vacuuming Created On: {DateTime.Now}");
        }
    }
}
