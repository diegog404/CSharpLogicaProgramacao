using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notaFinal;

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = nota1 + nota2;
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

            if(notaFinal < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }   
        }
    }
}



