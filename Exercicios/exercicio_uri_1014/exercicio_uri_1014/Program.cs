using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivel, consumoMedio;

            distancia = int.Parse(Console.ReadLine());
            combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = distancia / combustivel;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
