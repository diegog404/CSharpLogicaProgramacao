using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] nomeProduto = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            for(int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');

                nomeProduto[i] = dados[0];
                precoCompra[i] = double.Parse(dados[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(dados[2], CultureInfo.InvariantCulture);
            }

            double lucro;
            double porcentagemLucro;
            int lucroMenor10 = 0;
            int lucroEntre10E20 = 0;
            int lucroMaior20 = 0;
            double valorTotalCompra = 0.0;
            double valorTotalVenda = 0.0;
            double lucroTotal = 0.0;

            for(int i = 0; i < N;i++)
            {
                lucro = precoVenda[i] - precoCompra[i];
                porcentagemLucro = lucro / precoCompra[i] * 100.0;

                if(porcentagemLucro < 10.0)
                {
                    lucroMenor10++;
                }
                else if(porcentagemLucro <= 20)
                {
                    lucroEntre10E20++;
                }
                else
                {
                    lucroMaior20++;
                }

                valorTotalCompra = valorTotalCompra + precoCompra[i];
                valorTotalVenda = valorTotalVenda + precoVenda[i];
                lucroTotal = lucroTotal + lucro;
            }

            Console.WriteLine("Lucro abaixo de 10%: " + lucroMenor10);
            Console.WriteLine("Lucro entre 10% e 20%: " + lucroEntre10E20);
            Console.WriteLine("Lucro maior que 20%: " + lucroMaior20);
            Console.WriteLine("Valor total de compra: " + valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
