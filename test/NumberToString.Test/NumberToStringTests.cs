using Xunit;
using FluentAssertions;
namespace NumberToString.Test;

public class NumberToStringTests
{
    [Fact]
    public void ConvertZeroShouldReturnsZero()
    {
        var sut = new NumberToString();

        var result = sut.Convert(0);
        
        result.Should().Be("Zero");
    }

    [Fact]
    public void ConvertOneShouldReturnsOne()
    {
        var sut = new NumberToString();

        var result = sut.Convert(0);
        
        result.Should().Be("Zero");
    }

    [Fact]
    public void ConvertTwoShouldReturnsTwo()
    {
        var sut = new NumberToString();

        var result = sut.Convert(0);
        
        result.Should().Be("Zero");
    }
}