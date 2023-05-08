int N = int.Parse(Console.ReadLine());

int[,] numeros = new int[N, N];

for(int i = 0; i < N; i++)
{
    //i = linha da matriz = escreve dados na linha inteira
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; i < N; j++)
    {
        //j = coluna da matriz = distribui os dados nas colunas dependendo da linha. Depois incrementa a linha(i) e escreve novos dados.
        numeros[i, j] = int.Parse(dados[j]);
    }
}

Console.WriteLine("DIAGONAL PRINCIPAL:");

for(int i = 0; i < N; i++)
{
    //Para a diagonal, basta escrever as posições espelhadas da matriz, se baseando no ponteiro de i.
    Console.Write(numeros[i, i] + " ");
}
Console.WriteLine();

int cont = 0;

for(int i = 0; i < N; i++)
{
    for(int j = 0; j < N; j++)
    {
        if (numeros[i, j] < 0)
        {
            cont++;
        }
    }
}

Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
