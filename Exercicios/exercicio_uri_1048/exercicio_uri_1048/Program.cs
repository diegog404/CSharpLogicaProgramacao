using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBruto;

            salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;
            if (salarioBruto <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salarioBruto <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salarioBruto <= 1200.00)
            {
                percentual = 10.0;
            }
            else if (salarioBruto <= 2000.00)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            double reajuste = salarioBruto * percentual / 100.0;
            double salarioLiquido = salarioBruto + reajuste;


            Console.WriteLine("Novo salario: " + salarioLiquido.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");

        }
    }
}






