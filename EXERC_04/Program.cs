/*
Criar um programa que escreva os números de 1 a 1000 na tela.
*/

namespace EXERC_04;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                    EXIBIR NÚMEROS                   ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("\n");

        for (int i = 0; i < 1000; i++)
        { Console.WriteLine($"  • {i + 1}"); }

        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();
    }
}
