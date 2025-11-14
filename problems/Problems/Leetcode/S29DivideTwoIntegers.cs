namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/divide-two-integers/
/// </summary>
public class S29DivideTwoIntegers
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        var isNegative = (dividend < 0) ^ (divisor < 0);
        var longDividend = Math.Abs((long)dividend);
        var longDivisor = Math.Abs((long)divisor);
        var result = 0;

        while (longDividend >= longDivisor)
        {
            var temp = longDivisor;
            var multiple = 1;
            while (longDividend >= (temp << 1))
            {
                temp <<= 1;
                multiple <<= 1;
            }

            longDividend -= temp;
            result += multiple;
        }

        return isNegative ? -result : result;
    }
}
