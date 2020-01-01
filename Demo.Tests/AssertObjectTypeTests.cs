using Xunit;

namespace Demo.Tests
{
    public class AssertObjectTypeTests
    {
        [Fact]
        public void EmployeeFactory_Create_MustReturnEmployeeType()
        {
            // Arrange & Act
            var employee = EmployeeFactory.Create("Paula", 10000);

            // Assert
            Assert.IsType<Employee>(employee);
        }

        [Fact]
        public void EmployeeFactory_Create_MustReturnPersonType()
        {
            // Arrange & Act
            var employee = EmployeeFactory.Create("Paula", 10000);

            // Assert
            Assert.IsAssignableFrom<Person>(employee);
        }
    }
}
