using Problems.Leetcode;

namespace Problems.Tests.Leetcode;

public class S739DailyTemperaturesTests
{
    private readonly S739DailyTemperatures _solution = new S739DailyTemperatures();

    [Fact]
    public void TestExample1()
    {
        int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
        int[] expected = { 1, 1, 4, 2, 1, 1, 0, 0 };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestExample2()
    {
        int[] temperatures = { 30, 40, 50, 60 };
        int[] expected = { 1, 1, 1, 0 };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestExample3()
    {
        int[] temperatures = { 30, 60, 90 };
        int[] expected = { 1, 1, 0 };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestAllDecreasingTemperatures()
    {
        int[] temperatures = { 90, 80, 70, 60 };
        int[] expected = { 0, 0, 0, 0 };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestAllIncreasingTemperatures()
    {
        int[] temperatures = { 60, 70, 80, 90 };
        int[] expected = { 1, 1, 1, 0 };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestSingleTemperature()
    {
        int[] temperatures = { 75 };
        int[] expected = { 0 };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TestEmptyArray()
    {
        int[] temperatures = { };
        int[] expected = { };
        int[] result = _solution.DailyTemperatures(temperatures);
        Assert.Equal(expected, result);
    }
}