using System;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            int opcao = 1;

            while(opcao == 1)
            {
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (n1 < 0.0 || n1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (n2 < 0.0 || n2 > 10.0)
                {
                    Console.WriteLine("nota invalida");

                    n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (n1 + n2) / 2.0;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());

                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    opcao = int.Parse(Console.ReadLine());
                }
            }            
        }
    }
}
