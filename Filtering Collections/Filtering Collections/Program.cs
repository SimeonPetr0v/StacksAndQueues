namespace Filtering_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).Where(n => n > 0).ToArray();

        }
    }
}