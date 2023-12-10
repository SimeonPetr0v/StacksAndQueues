using System.Security.Cryptography.X509Certificates;

namespace SquaredNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Square(num));

        }
        static int Square(int x) => x * x;
    }
}