// See https:using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, min, max, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            //garantir que independente do número em x ou y, um precisa ser o menor valor, e o outro o maior
            if(x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            //soma para somar os numeros impares
            soma = 0;

            //min+1 pois o próprio número mínimo não é considerado
            for(int i = min+1; i < max; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
