namespace Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numQ = new Queue<int>(input);
            int length = numQ.Count();

            for (int i = 0; i < length; i++)
            {
                if (numQ.Peek() % 2 != 0)
                {
                    numQ.Dequeue();
                }
                else
                {
                    int evenNum = numQ.Dequeue();
                    numQ.Enqueue(evenNum);
                }
            }

            Console.WriteLine(String.Join(", ", numQ));
        }
    }
}