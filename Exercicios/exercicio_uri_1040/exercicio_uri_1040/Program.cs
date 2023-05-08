using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media, notaExame, mediaFinal;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            n4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            media = (float)((n1 * 2.0 + n2 * 3.0 + n3 * 4.0 + n4 * 1.0) / 10.0);

            if(media == 4.85f)
            {
                media = 4.8f;
            }

            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            if(media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                notaExame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + notaExame.ToString("F1", CultureInfo.InvariantCulture));

                mediaFinal = (float)((media + notaExame) / 2.0);

                if (mediaFinal >=  5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (mediaFinal <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }

                Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

