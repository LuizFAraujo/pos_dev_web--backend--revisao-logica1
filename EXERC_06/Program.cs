/*
Crie um programa que receba um número n (inteiro e maior do que 1)
como entrada e retorne se é um número é primo ou não.
*/

namespace EXERC_06;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                    NÚMERO PRIMO                     ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine("\n");
        Console.WriteLine("Informe um número abaixo:");
        int num = TesteConvertNum("  - Número:   ");

        if (num >= 2)
        {
            bool isPrimo = CheckNumeroPrimo(num);
            Console.WriteLine("O número {0} {1} primo.\n", num, isPrimo ? "É" : "NÃO É");
        }
        else
        {
            Console.WriteLine("Valor informado é menor que 2.");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();
    }


    static bool CheckNumeroPrimo(int num)
    {
        bool isPrimo = true;
        for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
        {
            if (num % divisor == 0)
            {
                isPrimo = false;
                break;
            }
        }
        return isPrimo;
    }


    static int TesteConvertNum(string texto)
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
