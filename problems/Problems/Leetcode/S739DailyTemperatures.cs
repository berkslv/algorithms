using System.Collections;

namespace Problems.Leetcode;

/// <summary>
/// https://leetcode.com/problems/daily-temperatures/submissions/1560977816
/// </summary>
public class S739DailyTemperatures
{
    public record Holder(int Value, int Index);
    
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];

        var stack = new Stack<Holder>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            var temperature = temperatures[i];

            while (true)
            {
                stack.TryPeek(out var peek);
                if (temperature > peek?.Value)
                {
                    var item = stack.Pop();
                    result[item.Index] = i - item.Index;
                    continue;
                }

                break;
            }

            stack.Push(new Holder(temperature, i));
        }

        return result;
    }
}