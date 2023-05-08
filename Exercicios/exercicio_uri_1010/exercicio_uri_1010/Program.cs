using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(vet[0]);
            int numeroPecas1 = int.Parse(vet[1]);
            double valorPecas1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string[] vet2 = Console.ReadLine().Split(' ');

            int codigoPeca2 = int.Parse(vet2[0]);
            int numeroPecas2 = int.Parse(vet2[1]);
            double valorPecas2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorTotalPago = valorPecas1 * numeroPecas1 + valorPecas2 * numeroPecas2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotalPago.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}



