/*
Ler uma matriz 3x3 e exibir o valor do seu Determinante.
Criar o algoritmo de acordo com a regra de Sarrus.
*/

namespace EXERC_16;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                 MATRIZ DETERMINANTE                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int[,] matriz = new int[3, 3];
        Console.WriteLine("\nPreencher a matriz:");
        PreencherMatriz(matriz);

        Console.WriteLine("\n---------------------");
        Console.WriteLine("--- MATRIZ ---");
        ShowMatriz(matriz);

        int determinante = CalcularDeterminante(matriz);
        Console.WriteLine("\n---------------------");
        Console.WriteLine("--- DETERMINANTE ---");
        Console.WriteLine($"  • Resp. = {determinante}");

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }

    //=====================================================
    static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            if (i > 0) Console.WriteLine("\n");
            for (int j = 0; j < matriz.GetLength(1); j++)
                matriz[i, j] = TesteConvertNum($"  • [{i + 1}, {j + 1}]:   ");

        }
    }

    //=====================================================
    static void ShowMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
                Console.Write($"{matriz[i, j]}  ");
            Console.WriteLine();
        }
    }

    //=====================================================
    static int CalcularDeterminante(int[,] matriz)
    {
        int det = 0;

        det = (matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) +
              (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) +
              (matriz[0, 2] * matriz[1, 0] * matriz[2, 1]) -
              (matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) -
              (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]) -
              (matriz[0, 0] * matriz[1, 2] * matriz[2, 1]);

        return det;
    }

    //=====================================================
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
