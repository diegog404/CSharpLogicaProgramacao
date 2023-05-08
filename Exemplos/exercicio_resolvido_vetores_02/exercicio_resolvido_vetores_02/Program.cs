using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vet;

            //instancia o vetor e faz ele ter N posições
            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            //usa o vetor de strings para digitar na mesma linha e aloca os numeros do vetor s nas posições do vetor vet, convertido para números
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i],CultureInfo.InvariantCulture);
            }

            //Mostra na tela os numeros no vetor na mesma linha
            for(int i = 0; i < N; i++)
            {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();

            //soma todos os numeros do vetor
            double soma = 0.0;

            for(int i = 0; i < N; i++)
            {
                soma += vet[i];
            }

            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

