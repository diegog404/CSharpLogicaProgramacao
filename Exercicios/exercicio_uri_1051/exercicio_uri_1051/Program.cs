using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, totalImposto;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //se o salario for menor que 2000, o imposto vai ser zero. Logo, a pessoa está isenta do imposto
            if(salario <= 2000.0)
            {
                totalImposto = 0.0;
            }            
            else if(salario <= 3000.0)
            {
                //se o imposto for apenas menor ou igual que 3000, a pessoa vai ter que pagar apenas 8% sobre
                //o valor do seu salario menos o mínimo do grau de imposto em que está incluído
                totalImposto = (salario - 2000.0) * 0.08;
            }
            else if(salario <= 4500.0)
            {
                //se o imposto for menor ou igual a 4500, a pessoa vai ter que pagar 18% sobre o valor do
                //salario menos o mínimo do grau de imposto que está incluído. E ainda, pagar 1000 vezes 8%
                //referente a diferença do grau anterior (já que passou tem que pagar por ele tambem).
               
                totalImposto = (salario - 3000.0) * 0.18 + 1000 * 0.08;
            }
            else 
            {
                totalImposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if(totalImposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + totalImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

