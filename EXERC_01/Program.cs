/*
Elaborar um programa que receba o nome de um cliente, seu endereço, valor de uma compras e data de entrega.
O programa deve exibir o seguinte texto (apresentar na tela a mesma formatação):
*/

namespace EXERC_01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("Favor informar os dados abaixo:");

        Console.WriteLine("\n");
        Console.Write("  - Nome:   ");
        var name = Console.ReadLine();


        Console.WriteLine("\n");
        float valor;
        bool check;
        do
        {
            Console.Write("  - Valor:   ");

            if (!float.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("O valor informado, não é um número! Tente novamente.");
                check = false;
            }
            else { check = true; }

        } while (check == false);

        Console.WriteLine("\n");
        Console.Write("  - Endereço:   ");
        var endereco = Console.ReadLine();

        Console.WriteLine("\n");
        Console.Write("  - Data Entrega:   ");
        var data = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("--------------------------------------------------------------------");
        Console.WriteLine("                               AVISO                                ");
        Console.WriteLine("\n");
        Console.WriteLine($"Caro cliente Sr(a) {name}, os produtos da sua compra no");
        Console.WriteLine($"valor de R${valor:0.00} serão entregues no endereço abaixo:");
        Console.WriteLine($"{endereco}.");
        Console.WriteLine($"Data da Entrega: {data}.");
        Console.WriteLine("\n");
        Console.WriteLine("******************** Obrigado pela Preferência! ********************");
        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();
        Console.WriteLine("\n");

    }
}














        