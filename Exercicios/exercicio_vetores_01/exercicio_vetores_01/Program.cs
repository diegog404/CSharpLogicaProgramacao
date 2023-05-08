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

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                numeros[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double maior = 0.0;
            double posicao = 0;

            for(int i = 0; i < N; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);
        }
    }
}
