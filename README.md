# Software Testing

 Testing is a process of running a program or system with the intention of finding defects.

## Unit Test

Essentially, a basic unit test is the test of the small portion of your application, ensuring that keeps working after any changes to your codebase.

### Writing your tests

#### The AAA standard (Arrange, Act, Assert)

It is  a structure of developing a 3-step test facilitates reading and understanding of the code.

- Arrange: The first step is to perform test preparation, can be initializing objects, declaring variables that will be passed as parameters to the method or function tested.

- Act: The second step is when the tested method / function is called and executed with the objects or parameters from the previous step.

- Assert: In the last step, it is verified if the results match the expected results.

### Working with xUnit.Net framework
[xUnit.Net](https://github.com/xunit/xunit "xUnit.Net") is an open source framework compatible with Visual Studio and used by the .Net Core and ASP.NET development team.

[xUnit.Net](https://github.com/xunit/xunit "xUnit.Net") includes support for two different major types of unit tests:** facts and theories**.

- **Facts** are tests which are always true. They test invariant conditions.
```csharp
[Fact]
public void Calculator_Sum_ReturnSumValue()
{
	// Arrange
	var calculator = new Calculator();

	// Act
	var result = calculator.Sum(2, 2);

	// Assert
	Assert.Equal(4, result);
}
```
- **Theories** are tests which are only true for a particular set of data.
```csharp
[Theory]
[InlineData(1, 1, 2)]
[InlineData(2, 2, 4)]
[InlineData(4, 2, 6)]
[InlineData(7, 3, 10)]
[InlineData(6, 6, 12)]
[InlineData(9, 9, 18)]
public void Calculator_Sum_ReturnSumCorrectValues(double v1, double v2, double total)
{
	// Arrange
	var calculator = new Calculator();

	// Act
	var result = calculator.Sum(v1, v2);

	// Assert
	Assert.Equal(total, result);
}
```