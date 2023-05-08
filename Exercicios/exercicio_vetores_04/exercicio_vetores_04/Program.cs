using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] numeros = new double[N];

            string[] vet = Console.ReadLine().Split(' ');

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
                soma = soma + numeros[i];
            }

            double media =(double) soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for(int i = 0; i < N; i++)
            {
                if (numeros[i] < media)
                {
                    Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
