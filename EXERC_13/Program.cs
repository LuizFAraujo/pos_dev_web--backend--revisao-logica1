/*
Criar um programa que preenche uma Matriz de 10 linhas com 10 colunas.
Exibir a matriz na tela.
O programa deve então gerar uma segunda matriz que tem como base a primeira:
 - Se o número da linha for igual ao número da coluna, colocar o valor "1" na posição.
 - Se o número da linha for menor que o número da coluna, colocar o valor "0".
 - Se o número da linha for maior que o número da coluna, colocar o valor "2".
Exibir a segunda matriz na tela.
*/

namespace EXERC_13;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                     MATRIZ 10x10                    ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int[,] matrizPrimeira = new int[10, 10];
        PreencherMatrizPrimeira(matrizPrimeira);

        Console.WriteLine("\n===================================");
        Console.WriteLine("------ PRIMEIRA MATRIZ ------");
        ShowMatriz(matrizPrimeira);

        int[,] matrizSegunda = GetMatrizSegunda(matrizPrimeira);

        Console.WriteLine("\n===================================");
        Console.WriteLine("------ SEGUNDA MATRIZ ------");
        ShowMatriz(matrizSegunda, true);

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }

    // ======================================================================
    static void PreencherMatrizPrimeira(int[,] matriz)
    {
        Random random = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
                matriz[i, j] = random.Next(10);
    }

    // ======================================================================
    static int[,] GetMatrizSegunda(int[,] matrizBase)
    {
        int[,] vResult = new int[10, 10];

        for (int i = 0; i < matrizBase.GetLength(0); i++)
        {
            for (int j = 0; j < matrizBase.GetLength(1); j++)
                if (i == j) vResult[i, j] = 1;
                else if (i < j) vResult[i, j] = 0;
                else vResult[i, j] = 2;
        }

        return vResult;
    }

    // ======================================================================
    static void ShowMatriz(int[,] matriz, bool color = false)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                int tmp = matriz[i, j];
                if (color)
                    ResultValor(tmp);
                else
                    Console.Write($"{tmp}  ");
            }
            Console.WriteLine();
        }
    }

    // ======================================================================
    public static void ResultValor(int value)
    {
        ConsoleColor cor = value == 1 ? ConsoleColor.DarkCyan : value == 2 ? ConsoleColor.DarkRed : ConsoleColor.DarkMagenta;
        Console.ForegroundColor = cor;
        Console.Write($"{value}  ");
        Console.ResetColor();
    }

}
