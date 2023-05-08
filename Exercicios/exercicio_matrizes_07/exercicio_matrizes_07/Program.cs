int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int[,] mat = new int[M, N];

for (int i = 0; i < M; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(dados[j]);
    }
}

int filaEscolhida = int.Parse(Console.ReadLine());

//decrementar o valor da fila para cair na fila certa, já que começa no 0
filaEscolhida = filaEscolhida - 1;

//1: salvar o ultimo da fila, N-1 pra bater certo com a matriz
int ultimoFila = mat[filaEscolhida, N - 1];

//2: mover todos da fila para a direita (menos o ultimo), necessario fazer da direita pra esquerda
for (int j = N - 1; j > 0; j--)
{
    mat[filaEscolhida, j] = mat[filaEscolhida, j - 1];
}

//3: armazenar o ultimo na primeira posicao da fila
mat[filaEscolhida, 0] = ultimoFila;

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(mat[i, j] + " ");
    }
    Console.WriteLine();
}
