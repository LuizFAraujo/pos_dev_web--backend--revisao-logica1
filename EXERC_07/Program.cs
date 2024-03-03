/*
Desenvolver um algoritmo que simule um jogo de adivinhação:
O jogador insere números na tentativa de acertar o número sorteado entre 0 e 9 pelo algoritmo.
Quando acertar, o programa deve informar que ele acertou o
número x (sorteado) em x tentativas (quantidade de tentativas do jogador).
Verificar como é realizada a geração de números aleatórios na linguagem escolhida.
*/

namespace EXERC_07;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                  JOGO ADIVINHAÇÃO                   ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Random random = new Random();
        int numSorteado = random.Next(10);

        Console.WriteLine("\n");

        int tentativas = 0;
        int num;


        do
        {
            Console.WriteLine("Insira seu palpite (entre 0 e 9):");
            num = TesteConvertNum("  - Número:   ");

            if (num < 0 || num > 9)
            {
                Console.WriteLine("Informe apenas número entre 0 e 9.");
                continue;
            }

            tentativas++;

            if (num == numSorteado)
                Console.WriteLine($"\n\nParabéns! Você acertou o número {numSorteado} em {tentativas} tentativas.");
            else
                Console.WriteLine("Tente novamente!\n");

        } while (num != numSorteado);


        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();

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
