using Xunit;
namespace MathService.Tests;
public class FibonacciTests

{
    [Fact]
    public void Factorial_PositiveInteger_ReturnsCorrectValue()
    {
        // Arrange
        int input = 5;
        int expected = 120;

        // Act
        int actual = FactorialService.GetFactorial(input);

        // Assert
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Factorial_Zero_ReturnsOne()
    {
        // Arrange
        int input = 0;
        int expected = 1;

        // Act
        int actual = FactorialService.GetFactorial(input);

        // Assert
        Assert.Equal(expected, actual);
    }
[Fact]
public void Factorial_NegativeNumber_ThrowsArgumentException()
{
    // Arrange
    int input = -5;

    // Act & Assert
    Assert.Throws<ArgumentException>(() => FactorialService.GetFactorial(input));
}



}
