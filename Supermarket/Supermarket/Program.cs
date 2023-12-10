namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> iQueue = new Queue<string>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (iQueue.Count > 0)
                    {
                        Console.WriteLine(iQueue.Dequeue());
                    }
                }
                else
                {
                    iQueue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{iQueue.Count} people remaining.");

        }
    }
}