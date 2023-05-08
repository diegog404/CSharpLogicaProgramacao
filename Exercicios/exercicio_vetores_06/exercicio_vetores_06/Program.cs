using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for(int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');

                nomes[i] = dados[0];
                idades[i] = int.Parse(dados[1]);
            }

            int velho = idades[0];
            int posicaoMaiorIdade = 0;

            for(int i = 0; i < N; i++)
            {
                if (idades[i] > velho) 
                {              
                    velho = idades[i];
                    posicaoMaiorIdade = i;
                }
            }

            Console.WriteLine("Pessoa mais velha: " + nomes[posicaoMaiorIdade]);
        }
    }
}

