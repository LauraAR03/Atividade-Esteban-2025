using System;

public class Exercicio1
{
    static void Main(string[] args)
    {
        Console.Write("Quantos números você vai digitar? ");
        int n = int.Parse(Console.ReadLine());
        double[] numeros = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Digite o valor {i + 1}: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }
        double maiorValor = numeros[0];
        int posicao = 0;

        for (int i = 1; i < n; i++)
        {
            if (numeros[i] > maiorValor)
            {
                maiorValor = numeros[i];
                posicao = i;
            }
        }

        Console.WriteLine($"\nMAIOR VALOR = {maiorValor}");
        Console.WriteLine($"POSIÇÃO DO MAIOR VALOR = {posicao}");
    }
}
