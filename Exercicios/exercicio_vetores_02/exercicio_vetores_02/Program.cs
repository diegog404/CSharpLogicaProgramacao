using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] numeros = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {                
                numeros[i] = int.Parse(s[i]);
            }

            int cont = 0;

            for (int i = 0; i < N; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                    cont++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(cont);  
        }
    }
}
