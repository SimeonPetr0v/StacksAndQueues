namespace Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            bool balanced = true;

            if (input.Length != 0)
            {
                foreach (var @char in input)
                {
                    switch (@char)
                    {
                        case '(':
                        case '[':
                        case '{':
                            stack.Push(@char);
                            break;
                        case ')':
                            if (!stack.Any() || stack.Pop() != '(')
                            {
                                balanced = false;
                            }
                            break;
                        case ']':
                            if (!stack.Any() || stack.Pop() != '[')
                            {
                                balanced = false;
                            }
                            break;
                        case '}':
                            if (!stack.Any() || stack.Pop() != '{')
                            {
                                balanced = false;
                            }
                            break;
                    }
                }
            }

            if (balanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}