namespace Manipulating_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40 };
            int[] nums2 = nums.Select(x => x/2).ToArray();
            Console.WriteLine(String.Join(",", nums2));
            string[] nums3 = nums.Select(x => "num" + x).ToArray();
            Console.WriteLine(String.Join(" ", nums3));
        }
    }
}