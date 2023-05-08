using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, dentro, fora;

            n = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;
            for(int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if(x >= 10 && x <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}

