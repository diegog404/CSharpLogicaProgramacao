using System;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int opcao = int.Parse(Console.ReadLine());

            while (opcao != 4)
            {     
                if(opcao == 1)
                {
                    alcool = alcool + 1;
                }
                else if (opcao == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (opcao == 3)
                {
                    diesel = diesel + 1;
                }

                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}