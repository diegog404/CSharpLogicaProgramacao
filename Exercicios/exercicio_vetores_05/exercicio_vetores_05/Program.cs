using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];

            string[] vet = Console.ReadLine().Split(' ');

            for(int i = 0; i< N; i++)
            {
                numeros[i] = int.Parse(vet[i]);
            }

            int soma = 0;
            int cont = 0;
            double media;

            for(int i = 0; i < N; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    soma = soma + numeros[i];
                    cont++;
                }
            }

            media =(double) soma / cont;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
