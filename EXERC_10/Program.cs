/*
Criar um programa que solicite um "login" e uma "senha".
Se o login for igual a "IFSP" e a senha for igual a "PosWEB", exibir a mensagem "Login efetuado com sucesso".Se o usuário errar a senha 3 vezes seguidas, informar "Acesso negado".
*/


namespace EXERC_10;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                    LOGIN / SENHA                    ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        string login = "IFSP";
        string senha = "PosWEB";

        int limiteTentativa = 3;

        do
        {
            Console.WriteLine("\nInforme o login abaixo:");
            Console.Write("  - LOGIN:   ");
            string loginEntrada = Console.ReadLine() ?? "";

            Console.WriteLine("\nInforme a senha abaixo:");
            Console.Write("  - SENHA:   ");
            string senhaEntrada = Console.ReadLine() ?? "";

            if (loginEntrada == login && senhaEntrada == senha)
            {
                Console.WriteLine("\nLogin efetuado com sucesso!");
                Console.WriteLine("-----------------------------------------------------");
                break;
            }
            else
            {
                limiteTentativa--;

                if (limiteTentativa > 0)
                {
                    Console.WriteLine($"\nAcesso negado. Tentativas restantes: {limiteTentativa}");
                    Console.WriteLine("-----------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("\nAcesso negado. Limite de tentativas atingido.");
                    Console.WriteLine("-----------------------------------------------------");
                }
            }

        } while (limiteTentativa > 0);


        Console.WriteLine("\nPressione uma tecla para sair...");
        Console.ReadKey();
    }
}
