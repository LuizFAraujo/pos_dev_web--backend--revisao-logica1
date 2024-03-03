/*
Pesquisar o algoritmo de validação de CPF e implemente-o
*/

namespace EXERC_08;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("                  VALIDAÇÃO DE CPF                   ");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

        Console.WriteLine("\nInforme um número de CPF (apenas números):");
        Console.Write("  - CPF:   ");
        string vCPF = Console.ReadLine() ?? "";

        string vResult = ValidarCPF(vCPF) ? "<< CPF VÁLIDO >>" : "<< CPF INVÁLIDO >>";

        Console.WriteLine($"\n   {vResult}");

        Console.WriteLine("\nPressione uma tecla para sair...");
        Console.ReadKey();
    }



    static bool ValidarCPF(string cpf)
    {
        // Verificar se o CPF possui 11 dígitos
        if (cpf.Length != 11) return false;

        // Verificar se todos os dígitos são iguais, o que tornaria o CPF inválido
        if (cpf.Distinct().Count() == 1) return false;

        // Calcular os dígitos verificadores
        int soma = 0;
        int peso = 10;

        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * peso;
            peso--;
        }

        int digito1 = 11 - (soma % 11);

        if (digito1 > 9) digito1 = 0;

        soma = 0;
        peso = 11;

        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * peso;
            peso--;
        }

        int digito2 = 11 - (soma % 11);

        if (digito2 > 9) digito2 = 0;

        // Verificar se os dígitos calculados são iguais aos dígitos informados
        return cpf.EndsWith(digito1.ToString() + digito2.ToString());
    }
}
