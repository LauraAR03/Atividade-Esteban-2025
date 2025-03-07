using System;

public class Exercicio7
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de alunos: ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        double[] nota1 = new double[n];
        double[] nota2 = new double[n];

        Console.WriteLine("Digite o nome e as duas notas de cada aluno:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nome do {i + 1}º aluno: ");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Nota 1 de {nomes[i]}: ");
            nota1[i] = double.Parse(Console.ReadLine());

            Console.WriteLine($"Nota 2 de {nomes[i]}: ");
            nota2[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nAlunos aprovados:");
        for (int i = 0; i < n; i++)
        {
            double media = (nota1[i] + nota2[i]) / 2.0;
            if (media >= 6.0)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
