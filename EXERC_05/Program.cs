/*
Crie um programa que receba dois números inteiros e diferentes, maiores do que 0.
Exiba as tabuadas de todos os números do intervalo.
(Ex. Números digitados: 3 e 7 → exibirá as tabuadas do 3, 4, 5, 6 e 7).
O resultado deve ser exibido no terminal.
*/

namespace EXERC_05;

class Program
{
    static void Main(string[] args)
    {
        int vNum1, vNum2;

        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                      TABUADAS                       ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine("\n");
        Console.WriteLine("Informar dois números abaixo:");

        Console.WriteLine("\n");
        vNum1 = TesteConvertNum("  - Número << 1 >>:   ");
        vNum2 = TesteConvertNum("  - Número << 2 >>:   ");

        if (vNum1 > vNum2)
        {
            int tmp = vNum1;
            vNum1 = vNum2;
            vNum2 = tmp;
        }


        for (int i = vNum1; i <= vNum2; i++)
        {
            Console.WriteLine("\n");
            CalcTabuada(i);
        }


        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();
    }


    public static void CalcTabuada(int num)
    {
        Console.WriteLine("*********************************");
        Console.WriteLine($"        TABUADA << {num} >>");

        for (int i = 1; i <= 10; i++)
        {
            if (i < 10)
                Console.WriteLine($" •  {i} x {num} = {i * num}");
            else
                Console.WriteLine($" • {i} x {num} = {i * num}");
        }

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
