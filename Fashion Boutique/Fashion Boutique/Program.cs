namespace Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> boxClothes = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (int item in input.Reverse())
                boxClothes.Push(item);

            int rackCapacity = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int rackCount = 1;

            while (boxClothes.Count > 0)
            {
                if (currentSum + boxClothes.Peek() <= rackCapacity)
                {
                    currentSum += boxClothes.Pop();
                }
                else
                {
                    currentSum = boxClothes.Pop();
                    rackCount++;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}