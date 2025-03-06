using System;

public class Exercicio1067
{

    static void Main(string[] args)
    {
        Console.WriteLine("escreva um numero inteiro: ");
        int X = int.Parse(Console.ReadLine());

        for (int i = 1; i<= X; i += 2)
        {
            Console.WriteLine(i);
        }

    }

}
