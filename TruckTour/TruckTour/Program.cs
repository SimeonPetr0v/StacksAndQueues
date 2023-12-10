namespace TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            var allPumps = new Queue<int[]>();

            for (int i = 0; i < pumps; i++)
            {
                allPumps.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            for (int i = 0; i < allPumps.Count; i++)
            {
                int fuelTank = 0;
                var curr = allPumps.Peek();
                var completed = true;

                for (int j = 0; j < allPumps.Count; j++)
                {
                    fuelTank += curr[0];

                    if (fuelTank < curr[1])
                    {
                        completed = false;

                        for (int k = allPumps.Count - j + 1; k > 0; k--)
                        {
                            allPumps.Enqueue(allPumps.Dequeue());
                        }
                        break;
                    }

                    fuelTank -= curr[1];
                    allPumps.Enqueue(allPumps.Dequeue());
                    curr = allPumps.Peek();
                }

                if (completed)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}