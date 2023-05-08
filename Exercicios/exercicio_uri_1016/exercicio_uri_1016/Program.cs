using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distancia, calculo;

            distancia = int.Parse(Console.ReadLine());

            calculo = distancia * 2;

            Console.WriteLine(calculo + " minutos");
        }
    }
}

