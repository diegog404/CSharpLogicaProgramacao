using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p1, p2, p3, resposta;

            p1 = Console.ReadLine();

            if(p1 == "vertebrado")
            {
                p2 = Console.ReadLine();

                if(p2 == "ave")
                {
                    p3 = Console.ReadLine();

                    if(p3 == "carnivoro")
                    {
                        resposta = "aguia";
                    }
                    else
                    {
                        resposta = "pomba";
                    }
                }
                else
                {
                    p3 = Console.ReadLine();

                    if(p3 == "onivoro")
                    {
                        resposta = "homem";
                    }
                    else
                    {
                        resposta = "vaca";
                    }
                }
            }
            else
            {
                p2 = Console.ReadLine();

                if(p2 == "inseto")
                {
                    p3 = Console.ReadLine();

                    if(p3 == "hematofago")
                    {
                        resposta = "pulga";
                    }
                    else
                    {
                        resposta = "lagarta";
                    }
                }
                else
                {
                    p3 = Console.ReadLine();

                    if(p3 == "hematofago")
                    {
                        resposta = "sanguessuga";
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
