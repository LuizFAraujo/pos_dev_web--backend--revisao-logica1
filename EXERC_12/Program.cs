/*
Criar um programa que preencha um Vetor de 1000 posições com números aleatórios.
Exibir a porcentagem de números maiores ou iguais a 700 existentes no vetor.
*/

namespace EXERC_12;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                    VETOR 1000                       ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        int tamVetor = 1000, tamCalcPercent = 700;
        int[] vetor = new int[tamVetor];
        Random random = new Random();

        Console.WriteLine("\n Preenchendo vetor, aleatoriamente.....");
        Console.WriteLine($" Retornar percentual de valores >= {tamCalcPercent}.");

        for (int i = 0; i < tamVetor; i++)
        {
            vetor[i] = random.Next(tamVetor);
            // string msg = i < 9 ? "Posição ...." : i < 99 ? "Posição ..." : i < 999 ? "Posição .." : "Posição .";
            // Console.WriteLine($" • {msg} << {i + 1} >>  =  {vetor[i]}");
        }

        int qntAcima700 = 0;
        for (int i = 0; i < tamVetor; i++)
            if (vetor[i] >= tamCalcPercent)
                qntAcima700++;

        double porcentagem = qntAcima700 / (double)tamVetor * 100.0;

        Console.WriteLine("\n\n---------------------------------");
        Console.WriteLine(" Resultado:");
        Console.WriteLine($" • ..... {porcentagem:F2}%");

        Console.WriteLine("\n\n ----- Pressione uma tecla para sair -----");
        Console.ReadKey();
    }
}
