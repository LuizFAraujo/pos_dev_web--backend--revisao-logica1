/*
Criar um programa que leia um vetor de números inteiros com 10 posições.
Exibir quantos números pares e quantos números ímpares foram informados.
Exibir também a soma dos números pares e a média dos números ímpares.
*/

namespace EXERC_11;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                     VETOR 10                        ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


        int tamVetor = 10;
        int[] vetor = new int[tamVetor];

        Console.WriteLine("\n Entrada de valores do vetor:");
        for (int i = 0; i < tamVetor; i++)
            vetor[i] = TesteConvertNum(i < 9 ? $"  • Número  <{i + 1}>:   " : $"  • Número <{i + 1}>:   ");

        int numPares = 0, numImpares = 0;
        int somaPares = 0, somaImpares = 0;

        for (int i = 0; i < tamVetor; i++)
        {
            if (vetor[i] % 2 == 0)
            {
                numPares++;
                somaPares += vetor[i];
            }
            else
            {
                numImpares++;
                somaImpares += vetor[i];
            }
        }

        Console.WriteLine("\n---------------------------------");
        Console.WriteLine(" Resultado:");
        Console.WriteLine($" • ....... Pares = {numPares}");
        Console.WriteLine($" • ..... Ímpares = {numImpares}");

        if (numPares > 0)
            Console.WriteLine($" • .. Soma Pares = {somaPares}");

        if (numImpares > 0 && numImpares > 1)
        {
            double mediaImpares = (double)somaImpares / numImpares;
            Console.WriteLine($" • Média Ímpares = {mediaImpares:F2}");
        }
        else
        {
            if (numImpares > 0)
                Console.WriteLine($" • Média Ímpares = {numImpares:F2}");
            else
                Console.WriteLine($" • Média Ímpares = {0:F2}");
        }

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }


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
