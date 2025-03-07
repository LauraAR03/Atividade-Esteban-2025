using System;

public class Exercicio8
{
    static void Main()
    {
        Console.WriteLine("Digite o número de pessoas: ");
        int n = int.Parse(Console.ReadLine());

        double[] alturas = new double[n];
        char[] generos = new char[n];
        double somaAlturaMulheres = 0.0;
        int quantidadeMulheres = 0;
        int quantidadeHomens = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Digite a altura da {i + 1}ª pessoa: ");
            alturas[i] = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o gênero (M/F) da {i + 1}ª pessoa: ");
            generos[i] = char.Parse(Console.ReadLine().ToUpper());

            if (generos[i] == 'F')
            {
                somaAlturaMulheres += alturas[i];
                quantidadeMulheres++;
            }
            else if (generos[i] == 'M')
            {
                quantidadeHomens++;
            }
        }

        double menorAltura = alturas[0];
        double maiorAltura = alturas[0];

        for (int i = 1; i < n; i++)
        {
            if (alturas[i] < menorAltura)
            {
                menorAltura = alturas[i];
            }
            if (alturas[i] > maiorAltura)
            {
                maiorAltura = alturas[i];
            }
        }

        Console.WriteLine($"\nMenor altura = {menorAltura.ToString("F2")}");
        Console.WriteLine($"Maior altura = {maiorAltura.ToString("F2")}");

        if (quantidadeMulheres > 0)
        {
            double mediaAlturaMulheres = somaAlturaMulheres / quantidadeMulheres;
            Console.WriteLine($"Média das alturas das mulheres = {mediaAlturaMulheres.ToString("F2")}");
        }
        else
        {
            Console.WriteLine("Não há mulheres no grupo.");
        }

        Console.WriteLine($"Número de homens = {quantidadeHomens}");
    }
}
