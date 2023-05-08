using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] genero = new char[N];

            for(int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');

                alturas[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);
                genero[i] = char.Parse(dados[1]);
            }

            double menorAltura = alturas[0];
            double maiorAltura = alturas[0];
            int contMulheres = 0;
            double somaAlturasMulheres = 0.0;
            double mediaMulheres;
            int contHomens = 0;

            for (int i = 0; i<N; i++)
            {
                if (alturas[i] < menorAltura)
                {
                    menorAltura = alturas[i];
                }
                else if (alturas[i] > maiorAltura)
                {
                    maiorAltura = alturas[i];
                }

                if (genero[i] == 'F')
                {
                    contMulheres++;
                    somaAlturasMulheres = somaAlturasMulheres + alturas[i];
                }

                if (genero[i] == 'M')
                {
                    contHomens++;
                }
            }

            mediaMulheres = somaAlturasMulheres / contMulheres;

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media das alturas das mulheres = " + mediaMulheres.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens = " + contHomens);            
        }
    }
}
