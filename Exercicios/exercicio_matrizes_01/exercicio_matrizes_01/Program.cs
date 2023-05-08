string[] vet = Console.ReadLine().Split(' ');

int M = int.Parse(vet[0]);
int N = int.Parse(vet[1]);

int[,] mat = new int[M,N];

for(int i = 0; i < M; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(dados[j]);
    }
}

Console.WriteLine("VALORES NEGATIVOS:");
for(int i = 0; i < M; i++)
{
    for(int j = 0; j < N; j++)
    {
        if (mat[i, j] < 0)
        {
            Console.WriteLine(mat[i, j]);
        }
    }
}
