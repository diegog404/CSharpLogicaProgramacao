using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, maior = 0, posicao = 0;

            for(int i = 1; i <= 100; i++)
            {
                N = int.Parse(Console.ReadLine());

                if(N > maior)
                {
                    maior = N;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
