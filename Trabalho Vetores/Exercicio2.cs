using System;
public class Exercicio2
{
    static void Main()
    {
        Console.Write("Quantos números você deseja inserir?");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        List<int> pares = new List<int>();

        Console.WriteLine($"Digite os {n} números inteiros:");
        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());
            if (numeros[i] % 2 == 0)
            {
                pares.Add(numeros[i]);
            }
        }

        Console.WriteLine("Números pares:");
        foreach (int par in pares)
        {
            Console.Write(par + " ");
        }

        Console.WriteLine();
        Console.WriteLine($"Quantidade de números pares: {pares.Count}");
    }
}
