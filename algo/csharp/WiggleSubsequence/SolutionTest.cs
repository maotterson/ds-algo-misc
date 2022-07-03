namespace WiggleSubsequence;

public class SolutionTest
{
    private readonly Solution _sut = new Solution();

    [Theory]
    [InlineData(new[]{ 1, 7, 4, 9, 2, 5 }, 6)]
    [InlineData(new[]{ 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 }, 7)]
    [InlineData(new[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 2)]
    public void WiggleMaxLengthSlidingWindow_ShouldBeY_WhenSequenceIsX(int[] sequence, int expected)
    {
        var actual = _sut.WiggleMaxLengthSlidingWindow(sequence);
        Assert.Equal(expected, actual);
    }
}