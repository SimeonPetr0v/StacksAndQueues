namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> c = new Queue<string>(input);

            while (c.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == n)
                    {
                        string rChildren = c.Dequeue();
                        Console.WriteLine($"Removed {rChildren}");
                    }
                    else
                    {
                        string cur = c.Dequeue();
                        c.Enqueue(cur);
                    }
                }
            }

            Console.WriteLine($"Last is {c.Dequeue()}");
        }
    }
}