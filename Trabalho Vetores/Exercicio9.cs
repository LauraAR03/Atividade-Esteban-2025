using System;


public class Exercicio9
{
    static void Main()
    {
        Console.WriteLine("Digite a quantidade de mercadorias: ");
        int n = int.Parse(Console.ReadLine());

        string[] nomes = new string[n];
        double[] precosCompra = new double[n];
        double[] precosVenda = new double[n];

        int lucroAbaixo10 = 0;
        int lucroEntre10e20 = 0;
        int lucroAcima20 = 0;

        double totalCompra = 0.0;
        double totalVenda = 0.0;
        double lucroTotal = 0.0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nDigite os dados da {i + 1}ª mercadoria:");
            Console.WriteLine("Nome: ");
            nomes[i] = Console.ReadLine();

            Console.WriteLine("Preço de compra: ");
            precosCompra[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Preço de venda: ");
            precosVenda[i] = double.Parse(Console.ReadLine());

            double lucro = ((precosVenda[i] - precosCompra[i]) / precosCompra[i]) * 100;

            if (lucro < 10)
                lucroAbaixo10++;
            else if (lucro <= 20)
                lucroEntre10e20++;
            else
                lucroAcima20++;

            totalCompra += precosCompra[i];
            totalVenda += precosVenda[i];
            lucroTotal += precosVenda[i] - precosCompra[i];
        }

        Console.WriteLine($"\nLucro abaixo de 10%: {lucroAbaixo10}");
        Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
        Console.WriteLine($"Lucro acima de 20%: {lucroAcima20}");
        Console.WriteLine($"Valor total de compra: {totalCompra.ToString("F2")}");
        Console.WriteLine($"Valor total de venda: {totalVenda.ToString("F2")}");
        Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2")}");
    }
}
