using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, N, i, soma;

            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);

            i = 1;
            N = int.Parse(valores[i]);
            while (N <= 0)
            {
                i = i + 1;
                N = int.Parse(valores[i]);
            }

            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + A + i;
            }

            Console.WriteLine(soma);

        }
    }
}

