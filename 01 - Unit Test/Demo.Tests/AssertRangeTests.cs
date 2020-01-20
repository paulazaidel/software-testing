﻿using Xunit;

namespace Demo.Tests
{
    public class AssertRangeTests
    {
        [Theory]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8000)]
        [InlineData(15000)]
        public void Employee_Salary_SalaryRangesMustRespectProfessionalLevel(double salary)
        {
            // Arrange & Act
            var employee = new Employee("Paula", salary);

            // Assert
            if (employee.ProfessionalLevel == ProfessionalLevel.Junior)
                Assert.InRange(employee.Salary, 500, 1999);

            if (employee.ProfessionalLevel == ProfessionalLevel.Pleno)
                Assert.InRange(employee.Salary, 2000, 7999);

            if (employee.ProfessionalLevel == ProfessionalLevel.Senior)
                Assert.InRange(employee.Salary, 8000, double.MaxValue);

            Assert.NotInRange(employee.Salary, 0, 499);
        }
    }
}