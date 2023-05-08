using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFunc, horasTrab;
            double valorHora, salario;

            numeroFunc = int.Parse(Console.ReadLine());
            horasTrab = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horasTrab;

            Console.WriteLine("NUMBER = " + numeroFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


