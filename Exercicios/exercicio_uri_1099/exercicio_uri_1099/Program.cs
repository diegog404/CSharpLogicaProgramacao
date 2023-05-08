using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, y, menor, maior, soma = 0;

            N = int.Parse(Console.ReadLine());
            string[] vet;
            
            for(int i = 1; i <= N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if(x < y)
                {
                    menor = x;
                    maior = y;
                }
                else
                {
                    menor = y;
                    maior = x;
                }

                for(int b= menor+1; b < maior; b++)
                {
                    if(b % 2 != 0)
                    {
                        soma = soma + b;
                    }
                }

                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}

