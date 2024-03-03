/*
Criar um programa que leia uma matriz 3x4 (3 linhas e 4 colunas).
Exibir a matriz informada e sua Transposta.
*/

namespace EXERC_14;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                      MATRIZ 3x4                     ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int[,] matrizBase = new int[3, 4];
        Console.WriteLine("\nPreencher a matriz base:");
        PreencherMatriz(matrizBase);

        Console.WriteLine("\n--- BASE ---");
        ShowMatriz(matrizBase);

        int[,] matrizTransposta = TransporMatriz(matrizBase);
        Console.WriteLine("\n--- TRANSPOSTA ---");
        ShowMatriz(matrizTransposta);

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }

    // ==================================================================
    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            if (i > 0) Console.WriteLine("\n");
            for (int j = 0; j < matriz.GetLength(1); j++)
                matriz[i, j] = TesteConvertNum($"  • [{i + 1}, {j + 1}]:   ");

        }
    }

    // ==================================================================
    static void ShowMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
                Console.Write($"{matriz[i, j]}  ");
            Console.WriteLine();
        }
    }

    // ==================================================================
    static int[,] TransporMatriz(int[,] matriz)
    {
        int[,] transposta = new int[matriz.GetLength(1), matriz.GetLength(0)];

        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
                transposta[j, i] = matriz[i, j];

        return transposta;
    }

    // ==================================================================
    public static int TesteConvertNum(string texto)
    {
        bool check;
        int vNum;
        do
        {
            Console.Write(texto);

            if (!int.TryParse(Console.ReadLine(), out vNum))
            {
                Console.WriteLine("O valor informado é inválido! Tente novamente.");
                check = false;
            }
            else { check = true; }

        } while (check == false);

        return vNum;
    }
}
