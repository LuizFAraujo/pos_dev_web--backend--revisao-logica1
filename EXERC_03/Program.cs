/*
Crie um programa que leia dois números reais e apresente um menu com as opções:
1 - Somar
2 - Subtrair
3 - Multiplicar
4 - Dividir
Caso a linguagem escolhida tenha suporte, exibir o resultado em uma tela gráfica.
*/

namespace EXERC_03;
class Program
{
    static void Main(string[] args)
    {
        double vNum1, vNum2, vRes = 0;
        bool check, divZero = false;
        int op;

        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                      OPERAÇÕES                      ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine("\n");
        Console.WriteLine("Escolha uma das operações abaixo:");
        Console.WriteLine("  • 1 : SOMAR");
        Console.WriteLine("  • 2 : SUBTRAIR");
        Console.WriteLine("  • 3 : MULTIPLICAR");
        Console.WriteLine("  • 4 : DIVIDIR");

        Console.WriteLine("\n");
        do
        {
            Console.Write("  - Digite a opção escolhida:   ");

            if (!int.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine("O valor informado, não é um número! Tente novamente.");
                check = false;
            }
            else
            {
                check = op >= 1 && op <= 4 ? true : false;
                if (!check) { Console.WriteLine("Opção inválida! Tente novamente."); }
            }

        } while (check == false);


        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Para efetuar a operação, favor informar dois números abaixo:");

        Console.WriteLine("\n");
        vNum1 = testeConvertNum("  - Número << 1 >>:   ");
        vNum2 = testeConvertNum("  - Número << 2 >>:   ");

        switch (op)
        {
            case 1:
                vRes = vNum1 + vNum2;
                break;
            case 2:
                vRes = vNum1 - vNum2;
                break;
            case 3:
                vRes = vNum1 * vNum2;
                break;
            case 4:
                if (vNum2 > 0)
                    vRes = vNum1 / vNum2;
                else
                    divZero = true;
                break;
        }

        Console.WriteLine("\n");
        if (!divZero)
            Console.WriteLine($"O resultado da operação é:  {vRes} ");
        else
            Console.WriteLine("Não é possível dividir por zero.");


        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();
    }




    public static double testeConvertNum(string texto)
    {
        bool check;
        double vNum;
        do
        {
            Console.Write(texto);

            if (!double.TryParse(Console.ReadLine(), out vNum))
            {
                Console.WriteLine("O valor informado, não é um número! Tente novamente.");
                check = false;
            }
            else { check = true; }

        } while (check == false);

        return vNum;
    }

}
