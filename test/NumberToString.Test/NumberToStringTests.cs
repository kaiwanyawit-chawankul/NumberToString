using Xunit;
using FluentAssertions;
namespace NumberToString.Test;

public class NumberToStringTests
{
    [Theory]
    [InlineData("Zero",0)]
    [InlineData("One",1)]
    [InlineData("Two",2)]
    [InlineData("Three",3)]
    [InlineData("Four",4)]
    [InlineData("Five",5)]
    public void ConvertOneDigitsShouldReturnsCorrectly(string expectedValue, int input)
    {
        var sut = new NumberToString();

        var result = sut.Convert(input);
        
        result.Should().Be(expectedValue);
    }
}