using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            int n3 = int.Parse(vet[2]);

            int maior = (n1 + n2 + Math.Abs(n1 - n2)) / 2;
            int maiorABS = (maior + n3 + Math.Abs(maior - n3)) / 2;

            Console.WriteLine(maiorABS + " eh o maior");
        }
    }
}



