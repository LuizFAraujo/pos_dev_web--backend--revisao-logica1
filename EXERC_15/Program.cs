/*
Exibir uma matriz com os números de 1 a 100, adicionando uma marca.
ex: asterisco) em todos os números primos. (Crivo de Eratóstenes)
*/

namespace EXERC_15;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                  MATRIZ PRIMO                       ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int[,] matriz = new int[10, 10];
        PreencherMatriz(matriz);

        Console.WriteLine("\nMatriz 1 a 100 (*num* é primo):");
        Console.Write("Obs.: ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write("*num* ");
        Console.ResetColor();
        Console.Write("é primo.\n\n");
        ExibirMatrizComMarcacao(matriz);

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }

    //=====================================================
    static void PreencherMatriz(int[,] matriz)
    {
        int num = 1;
        for (int i = 0; i < matriz.GetLength(0); i++)
            for (int j = 0; j < matriz.GetLength(1); j++)
                matriz[i, j] = num++;
    }

    //=====================================================
    static void ExibirMatrizComMarcacao(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
                if (CheckNumeroPrimo(matriz[i, j]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"*{matriz[i, j]}*  ");
                    Console.ResetColor();
                }
                else
                    Console.Write($"{matriz[i, j]}   ");

            Console.WriteLine();
        }
    }

    //=====================================================
    static bool CheckNumeroPrimo(int num)
    {
        if (num < 2) return false;

        for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
            if (num % divisor == 0) return false;

        return true;
    }
}
