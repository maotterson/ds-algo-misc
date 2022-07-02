namespace CountOddNumbersInAnIntervalRange.Test;

public class SolutionTest
{
    Solution _sut = new Solution();

    [Theory]
    [InlineData(3,7,3)]
    [InlineData(8,10,1)]
    public void CountOddsBruteForce_ShouldReturnZ_WhenXandYProvided(int low, int high, int expected)
    {
        var actual = _sut.CountOddsBruteForce(low, high);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(3, 7, 3)]
    [InlineData(8, 10, 1)]
    [InlineData(14, 17, 2)]
    public void CountOddsSmart_ShouldReturnZ_WhenXandYProvided(int low, int high, int expected)
    {
        var actual = _sut.CountOddsSmart(low, high);
        Assert.Equal(expected, actual);
    }
}