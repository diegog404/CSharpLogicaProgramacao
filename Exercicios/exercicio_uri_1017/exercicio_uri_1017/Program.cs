using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade, distancia;
            double litro;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo * velocidade;

            litro = (double) distancia / 12;

            Console.WriteLine(litro.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}


