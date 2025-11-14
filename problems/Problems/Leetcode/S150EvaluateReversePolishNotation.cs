namespace Problems.Leetcode;

/// <summary>+
/// https://leetcode.com/problems/evaluate-reverse-polish-notation/
/// </summary>
public class S150EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var number))
            {
                stack.Push(number);
            }
            else
            {
                var b = stack.Pop();
                var a = stack.Pop();
                switch (token)
                {
                    case "+":
                        stack.Push(a + b);
                        break;
                    case "-":
                        stack.Push(a - b);
                        break;
                    case "*":
                        stack.Push(a * b);
                        break;
                    case "/":
                        stack.Push(a / b);
                        break;
                }
            }
        }

        return stack.Pop();
    }
}
