namespace Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int input1 = input[1];
            int input2 = input[2];

            Queue<int> numQueue = new Queue<int>();

            List<int> enqueNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            enqueNums.ForEach(input2 => numQueue.Enqueue(input2));

            for (int i = 0; i < input1; i++)
            {
                numQueue.Dequeue();
            }

            if (numQueue.Count() > 0)
            {
                if (numQueue.Contains(input2))
                {
                    Console.WriteLine("true");
                }

                else
                {
                    Console.WriteLine(numQueue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
                
        }
    }
}