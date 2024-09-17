using System;

class CalcularImposto
{
    static void Main()
    {
        // Solicita ao usuário para inserir o salário
        Console.Write("Digite o valor do salário: ");
        float valorSalario = float.Parse(Console.ReadLine());

        // Solicita ao usuário para inserir o valor dos benefícios
        Console.Write("Digite o valor dos benefícios: ");
        float valorBeneficios = float.Parse(Console.ReadLine());

        // Calcula o valor do imposto com base no salário
        float valorImposto;
        if (valorSalario >= 0 && valorSalario <= 1100)
        {
            valorImposto = 0.05f * valorSalario;
        }
        else if (valorSalario >= 1101 && valorSalario <= 2500)
        {
            valorImposto = 0.10f * valorSalario;
        }
        else
        {
            valorImposto = 0.15f * valorSalario;
        }

        // Calcula o valor final após o imposto e adiciona os benefícios
        float saida = valorSalario - valorImposto + valorBeneficios;

        // Exibe o resultado formatado com 2 casas decimais
        Console.WriteLine($"O valor final após impostos e benefícios é: {saida:F2}");
    }
}
