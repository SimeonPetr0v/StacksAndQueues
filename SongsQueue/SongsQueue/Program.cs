namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                switch (input[0].ToLower())
                {
                    case "play":
                        queue.Dequeue();
                        break;
                    case "add":
                        input.RemoveAt(0);
                        if (queue.Contains(string.Join(" ", input)))
                        {
                            Console.WriteLine($"{string.Join(" ", input)} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(string.Join(" ", input));
                        }

                        break;
                    case "show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}