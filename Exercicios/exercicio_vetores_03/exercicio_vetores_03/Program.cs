using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split(' ');
            int[] elementosA = new int[N];            

            for(int i = 0; i < N; i++)
            {
                elementosA[i] = int.Parse(s[i]); 
            }

            string[] s1 = Console.ReadLine().Split(' ');
            int[] elementosB = new int[N];

            for (int i = 0; i < N; i++)
            {
                elementosB[i] = int.Parse(s1[i]);
            }

            int[] somaElementos = new int[N];

            for(int i = 0; i <N; i++)
            {
                somaElementos[i] = elementosA[i] + elementosB[i];
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(somaElementos[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
