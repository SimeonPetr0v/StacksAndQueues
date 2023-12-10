namespace Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ")
                .Where(n => n.Length % 2 == 0)
                .ToArray();
            Console.WriteLine(String.Join(" ",arr));
           
        }
    }
}