int N = int.Parse(Console.ReadLine());

int[,] mat = new int[N, N];

for (int i = 0;i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(dados[j]);
    }
}

int soma = 0;
for (int i = 0; i < N; i++)
{
    for (int j = i + 1; j < N; j++)
    { // j inicia com i+1
        soma = soma + mat[i, j];
    }
}
Console.WriteLine(soma);
