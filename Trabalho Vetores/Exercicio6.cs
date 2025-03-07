using System;

public class Exercicio6
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de pessoas: ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        int[] idades = new int[n];

        Console.WriteLine("Digite os nomes e idades das pessoas:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nome da {i + 1}ª pessoa: ");
            nomes[i] = Console.ReadLine();
            
            Console.WriteLine($"Idade de {nomes[i]}: ");
            idades[i] = int.Parse(Console.ReadLine());
        }

        int indiceMaisVelho = 0;
        for (int i = 1; i < n; i++)
        {
            if (idades[i] > idades[indiceMaisVelho])
            {
                indiceMaisVelho = i;
            }
        }

        Console.WriteLine($"\nPessoa mais velha: {nomes[indiceMaisVelho]}");
    }
}
