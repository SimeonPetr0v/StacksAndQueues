namespace TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> traf = new Queue<string>();

            string command = Console.ReadLine();
            while (command != "end")
            {

                if (command == "green")
                {
                    for (int i = 0; i < cars; i++)
                    {
                        if (traf.Count == 0)
                        {
                            break;
                        }
                        string currCar = traf.Dequeue();
                        Console.WriteLine($"{currCar} passed!");
                        count++;
                    }
                }
                else
                {
                    traf.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");


        }
    }
}