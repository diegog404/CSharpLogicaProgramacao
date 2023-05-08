using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());

            int cont = 5;
            int soma = 0;
            int aux;

            while(X != 0)
            {
                aux = X;

                while(cont > 0)
                {
                    if(aux % 2 == 0)
                    {
                        soma = soma + aux;
                        cont--;
                        aux++;
                    }
                    else
                    {
                        aux++;
                    }
                }

                Console.WriteLine(soma);

                aux = 0;
                soma = 0;
                cont = 5;

                X = int.Parse(Console.ReadLine());
            }
        }
    }
}

