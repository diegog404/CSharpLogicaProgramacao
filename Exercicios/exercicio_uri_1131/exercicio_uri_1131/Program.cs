using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golsGremio, golsInter, opcao, contGrenais = 0, vitGremio = 0, vitInter = 0, empates = 0;

            opcao = 1;

            while (opcao == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');

                golsInter = int.Parse(vet[0]);
                golsGremio = int.Parse(vet[1]);

                contGrenais++;

                if (golsGremio > golsInter)
                {
                    vitGremio++;
                }
                else if (golsInter > golsGremio)
                {
                    vitInter++;
                }
                else
                {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                opcao = int.Parse(Console.ReadLine());
            }

            if(contGrenais == 1)
            {
                Console.WriteLine(contGrenais + "grenal");
            }
            else
            {
                Console.WriteLine(contGrenais + " grenais");
            }
            
            Console.WriteLine("Inter:" + vitInter);
            Console.WriteLine("Gremio:" + vitGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitInter > vitGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitGremio > vitInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}