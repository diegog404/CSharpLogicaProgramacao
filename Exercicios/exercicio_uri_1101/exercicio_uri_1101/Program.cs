using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, N, soma = 0, menor, maior;

            string[] vet = Console.ReadLine().Split(' ');

            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);

            while (M != 0 && M > 0 && N != 0 && N > 0)
            {
                if (M < N)
                {
                    menor = M;
                    maior = N;
                }
                else
                {
                    menor = N;
                    maior = M;
                }

                for (int i = menor; i <= maior; i++)
                {
                    Console.Write(i + " ");
                    soma = soma + i;
                }

                Console.WriteLine("Sum=" + soma);
                soma = 0;

                vet = Console.ReadLine().Split(' ');

                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
            }                 
        }
    }
}