namespace CountOddNumbersInAnIntervalRange;
public class Solution
{
    public int CountOddsBruteForce(int low, int high)
    {
        var count = 0;
        for(int i = low; i <= high; i++)
        {
            if(i%2 != 0)
            {
                count++;
            }
        }
        return count;
    }

    public int CountOddsSmart(int low, int high)
    {
        var range = high - low;
        var lowContribution = low % 2 != 0 ? 1 : 0;
        var highContribution = high % 2 != 0 ? 1 : 0;
        if (range == 0)
            return lowContribution;
        if (range == 1)
            return 1;

        var rangeContribution = lowContribution + highContribution == 2 ? range / 2 - 1 : range / 2;

        return lowContribution + highContribution + rangeContribution;
    }

}
