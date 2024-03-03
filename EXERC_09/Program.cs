/*
– Implemente um programa para o cálculo de Fatorial,
  utilizando o conceito de recursividade.
*/

namespace EXERC_09;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                      FATORIAL                       ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");


        Console.WriteLine("\n Informe um número para calcular o fatorial:");
        int vNum = TesteConvertNum("  - Número:   ");

        if (vNum >= 0)
        {
            long vResult = CalcularFatorial(vNum);
            Console.WriteLine($"\n  Fatorial de << {vNum} >>  =  {vResult}");
        }
        else
        {
            Console.WriteLine("O fatorial não definido para números negativos!");
        }

        Console.WriteLine("\nPressione uma tecla para sair...");
        Console.ReadKey();
    }


    static long CalcularFatorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        else
            return n * CalcularFatorial(n - 1);
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
