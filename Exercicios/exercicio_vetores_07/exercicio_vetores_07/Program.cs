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
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            for(int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');

                nomes[i] = dados[0];
                nota1[i] = double.Parse(dados[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(dados[2], CultureInfo.InvariantCulture);
            }

            double media;

            Console.WriteLine("Alunos aprovados:");

            for(int i = 0; i < N;i++)
            {
                media = (nota1[i] + nota2[i]) / 2.0;

                if(media >= 6.0)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
