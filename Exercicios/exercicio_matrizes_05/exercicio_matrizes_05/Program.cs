string[] s = Console.ReadLine().Split(' ');

int M = int.Parse(s[0]);
int N = int.Parse(s[1]);

int[,] A = new int[M, N];
int[,] B = new int[M, N];

for (int i = 0;i < M; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for(int j = 0; j < N; j++)
    {
        A[i, j] = int.Parse(dados[j]);
    }
}

for (int i = 0; i < M; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        B[i, j] = int.Parse(dados[j]);
    }
}

int[,] C = new int[M, N];

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        C[i, j] = A[i, j] + B[i, j];
        Console.Write(C[i, j] + " ");
    }
    Console.WriteLine();
}
