using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar previamente as variaveis se elas vão ser usadas mais de uma vez
            //as variaveis podem ser declaradas como double mesmo escrevendo como int, pra nao dar diferença
            //na variavel media
            double idade, soma, media;
            int cont;

            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = 0.0;
            cont = 0;

            while(idade >= 0)
            {
                //as variaveis de incremento entram primeiro no loop pq já tem um valor prévio pra contar,
                //depois le dnv
                soma = soma + idade;
                cont = cont + 1;

                idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            if(cont == 0)
            {
                //Se um valor negativo foi lido no início, significa que cont nunca incrementou e o loop
                //acabou
                Console.WriteLine("Impossível calcular");
            }
            else
            {
                media = soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
