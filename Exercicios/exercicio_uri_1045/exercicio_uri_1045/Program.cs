using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            //deve-se criar as variaveis auxiliares n1, n2 e n3 para verificar a ordem dos números e
            //colocar na ordem certa antes de calcular os triângulos

            double n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double A, B, C;

            //casos possiveis: n1 maior que todos, n1 maior que outro, n1 menor
            //n2 maior que todos, n2 maior que outro, n2 menor
            //n3 maior que todos, n3, maior que outro, n3 menor

            if (n1 > n2 && n1 > n3)
            {
                A = n1;

                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }
            else if (n2 > n3) //verifica se n2 é maior que n3, pq se for, significa que é o maior, ja que passou da primeira
            {
                A = n2;

                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n1;
                }
            }
            else
            {
                A = n3;

                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }
                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                //primeiro testar as 3 possibilidades em angulos

                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else //se n for nenhum dos dois so pode ser acutangulo
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

            }

            //testar se é equilatero ou isosceles

            if (A == B && B == C)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || B == C || A == C)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}



