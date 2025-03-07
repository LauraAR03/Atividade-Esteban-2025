using System;

public class Exercicio3
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de elementos nos vetores:");
        int n = int.Parse(Console.ReadLine());

        int[] vetorA = new int[n];
        int[] vetorB = new int[n];
        int[] vetorC = new int[n];

        Console.WriteLine("Digite os elementos do vetor A:");
        for (int i = 0; i < n; i++)
        {
            vetorA[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite os elementos do vetor B:");
        for (int i = 0; i < n; i++)
        {
            vetorB[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            vetorC[i] = vetorA[i] + vetorB[i];
        }

        Console.WriteLine("Vetor C (soma dos elementos correspondentes):");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vetorC[i] + " ");
        }
    }
}

