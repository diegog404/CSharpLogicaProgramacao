using System;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, PROD;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            PROD = n1 * n2;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
