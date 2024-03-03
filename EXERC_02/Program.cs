/*
Crie um programa para o cálculo do IMC de uma pessoa. Exibir mensagens de acordo com a faixa de valores encontrada:
Menor que 16,5 = Desnutrição
de 16,6 a 18,5 = Abaixo do peso
de 18,6 a 24,9 = Peso normal
de 25 a 29,9 = Sobrepeso
maior ou igual a 30 = Obesidade
*/

namespace EXERC_02;
class Program
{
    static void Main(string[] args)
    {
        double vAlt, vPeso, vIMC;

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                     CÁLCULO IMC                     ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("\n");
        Console.WriteLine("Favor informar os dados abaixo:");

        Console.WriteLine("\n");
        Console.Write("  - Sua altura:   ");
        double.TryParse(Console.ReadLine(), out vAlt);

        Console.WriteLine("\n");
        Console.Write("  - Sua peso:   ");
        double.TryParse(Console.ReadLine(), out vPeso);

        vIMC = vPeso / Math.Pow(vAlt, 2);

        Console.Clear();


        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Seu IMC: " + vIMC.ToString("N2"));

        switch (vIMC)
        {
            case < 16.5:
                resultIMC("Desnutrição", ConsoleColor.Red);
                break;
            case <= 18.5:
                resultIMC("Abaixo do peso", ConsoleColor.Magenta);
                break;
            case <= 24.9:
                resultIMC("Peso normal", ConsoleColor.Green);
                break;
            case <= 29.9:
                resultIMC("Sobrepeso", ConsoleColor.DarkYellow);
                break;
            default:
                resultIMC("Obesidade", ConsoleColor.DarkMagenta);
                break;
        }

        Console.WriteLine("\n");
        Console.WriteLine("Pressione uma tecla para sair...");
        Console.ReadKey();
    }

    public static void resultIMC(string texto, ConsoleColor cor)
    {
        Console.ForegroundColor = cor;
        Console.WriteLine(texto);
        Console.ResetColor();
    }

}
