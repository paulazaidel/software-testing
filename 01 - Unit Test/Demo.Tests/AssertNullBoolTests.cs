using Xunit;

namespace Demo.Tests
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Person_Name_MustNotBeNullOrEmpty()
        {
            // Arrange & Act
            var person = new Person() { Name = "Paula", Surname = "Zaidel" };

            // Assert
            Assert.False(string.IsNullOrEmpty(person.Name));
        }

        [Fact]
        public void Person_Surname_MustNotHaveSurname()
        {
            // Arrange & Act
            var person = new Person() { Name = "Paula" };

            // Assert
            Assert.Null(person.Surname);

            // Assert Bool
            Assert.True(string.IsNullOrEmpty(person.Surname));
            Assert.False(person.Surname?.Length > 0);
        }
    }
}
