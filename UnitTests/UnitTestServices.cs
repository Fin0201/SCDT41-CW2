﻿using System;
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
        public void ProblemServiceTest()
        {
            //Arrange
            ProblemService problemServiceTest;

            //Act
            problemServiceTest = new ProblemService("Fire Damage", Enums.SeverityPriority.HIGH);
            string? problemServiceString = problemServiceTest.ToString();

            //Assert
            Assert.IsType<ProblemService>(problemServiceTest);
            Assert.Equal(problemServiceString, $"Description: Fire Damage, Priority: HIGH, Created On: {DateTime.Now}");
        }

        [Fact]
        public void CosmeticServiceTest()
        {
            //Arrange
            CosmeticService cosmeticServiceTest;

            //Act
            cosmeticServiceTest = new CosmeticService("Vacuuming");
            string? cosmeticServiceString = cosmeticServiceTest.ToString();

            //Assert
            Assert.IsType<CosmeticService>(cosmeticServiceTest);
            Assert.Equal(cosmeticServiceString, $"Description: Vacuuming, Created On: {DateTime.Now}");
        }
    }
}
