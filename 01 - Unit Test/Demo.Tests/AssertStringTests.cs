using Xunit;

namespace Demo.Tests
{
    public class AssertStringTests
    {
        [Fact]
        public void StringsTools_JoinNames_ReturnFullName()
        {
            //Arrange
            var stringsTools = new StringsTools();

            //Act
            var fullName = stringsTools.Join("Paula", "Zaidel");

            //Assert
            Assert.Equal("Paula Zaidel", fullName);
        }

        [Fact]
        public void StringsTools_JoinNames_ReturnIgnoringCase()
        {
            //Arrange
            var stringsTools = new StringsTools();

            //Act
            var fullName = stringsTools.Join("Paula", "Zaidel");

            //Assert
            Assert.Equal("PAULA ZAIDEL", fullName, true);
        }

        [Fact]
        public void StringsTools_JoinNames_MustContainThisPart()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var fullName = stringsTools.Join("Paula", "Zaidel");

            // Assert
            Assert.Contains("Zaid", fullName);
        }


        [Fact]
        public void StringsTools_JoinNames_MustStartWith()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var fullName = stringsTools.Join("Paula", "Zaidel");

            // Assert
            Assert.StartsWith("Pa", fullName);
        }


        [Fact]
        public void StringsTools_JoinNames_MustFinishWith()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var fullName = stringsTools.Join("Paula", "Zaidel");

            // Assert
            Assert.EndsWith("del", fullName);
        }


        [Fact]
        public void StringsTools_JoinNames_ValidateRegularExpression()
        {
            // Arrange
            var stringsTools = new StringsTools();

            // Act
            var fullName = stringsTools.Join("Paula", "Zaidel");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);
        }
    }
}
