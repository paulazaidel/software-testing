using Xunit;

namespace Demo.Tests
{
    public class AssertCollectionTests
    {
        [Fact]
        public void Employee_Skills_MustNotHaveEmptySkills()
        {
            // Arrange & Act
            var employee = EmployeeFactory.Create("Paula", 10000);

            // Assert
            Assert.All(employee.Skills, skills => Assert.False(string.IsNullOrWhiteSpace(skills)));
        }

        [Fact]
        public void Employee_Skills_JuniorMustHaveBasicSkills()
        {
            // Arrange & Act
            var employee = EmployeeFactory.Create("Paula", 1000);

            // Assert
            Assert.Contains("OOP", employee.Skills);
        }

        [Fact]
        public void Employee_Skills_JuniorMustNotHaveAdvancedSkills()
        {
            // Arrange & Act
            var employee = EmployeeFactory.Create("Paula", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", employee.Skills);
        }

        [Fact]
        public void Employee_Skills_SeniorMustHaveAllSkills()
        {
            // Arrange & Act
            var employee = EmployeeFactory.Create("Paula", 15000);

            var basicSkills = new[]
            {
                "Programming logic",
                "OOP",
                "Tests",
                "Microservices"
            };

            // Assert
            Assert.Equal(basicSkills, employee.Skills);
        }
    }
}
