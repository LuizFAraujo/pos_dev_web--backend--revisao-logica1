/*
Criar um programa que receba 10 valores inteiros e armazene-os em um vetor.
Exibir o vetor ordenado de maneira crescente e também de maneira decrescente.
Realizar a ordenação usando um algoritmo de ordenação.
 – Não utilizar funções prontas se existirem na linguagem escolhida
*/



namespace EXERC_17;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                 VETOR 10 - ASC/DESC                 ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int tamVetor = 10;
        int[] vetor = new int[tamVetor];

        Console.WriteLine("\nPreencher o vetor:");
        PreencherVetor(vetor);

        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("--- VETOR - INFORMADO ---");
        ShowVetor(vetor);

        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("--- VETOR - CRESCENTE ---");
        OrderByAsc(vetor);
        ShowVetor(vetor);

        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("--- VETOR - DECRESCENTE ---");
        OrderByDesc(vetor);
        ShowVetor(vetor);

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }

    // ==================================================================
    static void PreencherVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            string msg = i < 9 ? "•   " : "•  ";
            vetor[i] = TesteConvertNum($"  {msg} <{i + 1}> :   ");
        }
    }

    // ==================================================================
    static void ShowVetor(int[] vetor)
    {
        foreach (var valor in vetor)
            Console.Write($"{valor} ");
        Console.WriteLine();
    }

    // ==================================================================
    static void TrocarElemento(int[] vetor, int i, int j)
    {
        int temp = vetor[i];
        vetor[i] = vetor[j];
        vetor[j] = temp;
    }

    // ==================================================================
    static void OrderByAsc(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
            for (int j = 0; j < vetor.Length - i - 1; j++)
                if (vetor[j] > vetor[j + 1])
                    TrocarElemento(vetor, j, j + 1);
    }

    // ==================================================================
    static void OrderByDesc(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
            for (int j = 0; j < vetor.Length - i - 1; j++)
                if (vetor[j] < vetor[j + 1])
                    TrocarElemento(vetor, j, j + 1);
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