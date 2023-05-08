using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CALCULAR A DURAÇÃO, mínimo 1m, máximo 24h

            int horaInicial, horaFinal, minutoInicial, minutoFinal, duracaoHoras, duracaoMinutos;

            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            minutoInicial = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            //Converte tudo para minutos
            int instanteInicial = horaInicial * 60 + minutoInicial;
            int instanteFinal = horaFinal * 60 + minutoFinal;

            //Primeiro calcula tudo em minutos
            int duracao;
            if(instanteInicial < instanteFinal)
            {
                //Se o instante inicial for menor que o final, basta realizar o cálculo normalmente
                duracao = instanteFinal - instanteInicial;
            }
            else
            {
                //Se não, multiplica o instante inicial pelas 24 horas, já multiplicando pelos minutos
                duracao = (24 * 60 - instanteInicial) + instanteFinal;
            }

            //Converte dnv os instantes restantes para hora dividindo por 60, e o resto são os minutos
            duracaoHoras = duracao / 60;
            duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
        }
    }
}




