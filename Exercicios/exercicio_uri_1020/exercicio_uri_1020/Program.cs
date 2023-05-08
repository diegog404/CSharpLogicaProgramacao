using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, resto, anos, meses, dias;

            N = int.Parse(Console.ReadLine());

            anos = N / 365;
            resto = N % 365;
            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}


