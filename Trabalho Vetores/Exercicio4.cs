using System;

public class Exercicio4
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de números reais no vetor: ");
        int n = int.Parse(Console.ReadLine());

        double[] numeros = new double[n];
        double soma = 0;

        Console.WriteLine($"Digite os {n} números reais:");
        for (int i = 0; i < n; i++)
        {
            numeros[i] = double.Parse(Console.ReadLine());
            soma += numeros[i];
        }

        double media = soma / n;

        Console.WriteLine($"\nMédia aritmética: {media:F3}");
        Console.WriteLine("Números abaixo da média:");

        for (int i = 0; i < n; i++)
        {
            if (numeros[i] < media)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
