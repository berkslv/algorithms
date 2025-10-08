using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S13RomanToIntegerTests
{
    private readonly S13RomanToInteger _solution = new S13RomanToInteger();

    [Fact]
    public void RomanToInt_SimpleRomanNumeral_ReturnsCorrectInteger()
    {
        // Arrange
        string s = "III";

        // Act
        var result = _solution.RomanToInt(s);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void RomanToInt_ComplexRomanNumeral_ReturnsCorrectInteger()
    {
        // Arrange
        string s = "LVIII"; // L = 50, V= 5, III = 3

        // Act
        var result = _solution.RomanToInt(s);

        // Assert
        Assert.Equal(58, result);
    }

    [Fact]
    public void RomanToInt_RomanWithSubtractions_ReturnsCorrectInteger()
    {
        // Arrange
        string s = "MCMXCIV"; // M = 1000, CM = 900, XC = 90 and IV = 4

        // Act
        var result = _solution.RomanToInt(s);

        // Assert
        Assert.Equal(1994, result);
    }

    [Fact]
    public void RomanToInt_SingleCharacters_ReturnsCorrectInteger()
    {
        // Test all single characters
        Assert.Equal(1, _solution.RomanToInt("I"));
        Assert.Equal(5, _solution.RomanToInt("V"));
        Assert.Equal(10, _solution.RomanToInt("X"));
        Assert.Equal(50, _solution.RomanToInt("L"));
        Assert.Equal(100, _solution.RomanToInt("C"));
        Assert.Equal(500, _solution.RomanToInt("D"));
        Assert.Equal(1000, _solution.RomanToInt("M"));
    }

    [Fact]
    public void RomanToInt_SubtractionCases_ReturnsCorrectInteger()
    {
        // Test subtraction cases
        Assert.Equal(4, _solution.RomanToInt("IV"));
        Assert.Equal(9, _solution.RomanToInt("IX"));
        Assert.Equal(40, _solution.RomanToInt("XL"));
        Assert.Equal(90, _solution.RomanToInt("XC"));
        Assert.Equal(400, _solution.RomanToInt("CD"));
        Assert.Equal(900, _solution.RomanToInt("CM"));
    }

    [Fact]
    public void RomanToInt_MixedCases_ReturnsCorrectInteger()
    {
        // Arrange & Act & Assert
        Assert.Equal(27, _solution.RomanToInt("XXVII")); // XX + V + II = 20 + 5 + 2 = 27
        Assert.Equal(444, _solution.RomanToInt("CDXLIV")); // CD + XL + IV = 400 + 40 + 4 = 444
        Assert.Equal(621, _solution.RomanToInt("DCXXI")); // D + C + XX + I = 500 + 100 + 20 + 1 = 621
    }

    [Fact]
    public void RomanToInt_LargeNumbers_ReturnsCorrectInteger()
    {
        // Arrange & Act & Assert
        Assert.Equal(3999, _solution.RomanToInt("MMMCMXCIX")); // Maximum valid Roman numeral
        Assert.Equal(2023, _solution.RomanToInt("MMXXIII"));
        Assert.Equal(1776, _solution.RomanToInt("MDCCLXXVI"));
    }
}