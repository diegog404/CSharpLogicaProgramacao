using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[] vet;

            //instancia o vetor e faz ele ter N posições
            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            //usa o vetor de strings para digitar na mesma linha e aloca os numeros do vetor s nas posições do vetor vet, convertido para números
            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            //percorre o vetor já preenchido e mostra os números negativos
            for(int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
