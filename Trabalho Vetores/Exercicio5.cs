using System;

public class Exercicio5
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de números inteiros no vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] numeros = new int[n];
        int somaPares = 0;
        int contPares = 0;

        Console.WriteLine($"Digite os {n} números inteiros:");
        for (int i = 0; i < n; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
                contPares++;
            }
        }

        if (contPares > 0)
        {
            double mediaPares = (double)somaPares / contPares;
            Console.WriteLine($"\nMédia aritmética dos números pares: {mediaPares:F1}");
        }
        else
        {
            Console.WriteLine("\nNenhum número par foi digitado.");
        }
    }
}
