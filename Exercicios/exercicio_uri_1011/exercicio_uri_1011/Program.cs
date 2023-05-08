using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int raio;
            double calculo;

            raio = int.Parse(Console.ReadLine());

            calculo = (double) (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = " + calculo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

