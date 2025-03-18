namespace JogoDaVelha
{
    public class Exercicio6
    {
        static string[,] tabuleiro = new string[3, 3];
        static string jogadorAtual = "X";

        public static void Main()
        {
            bool fimDeJogo = false;

            while (!fimDeJogo)
            {
                Console.Clear();
                ImprimirTabuleiro();
                Console.WriteLine($"Jogador atual: {jogadorAtual}");
                Console.Write("Digite a linha e coluna (1-3 1-3): ");

                string[] entrada = Console.ReadLine().Split();
                int linha = int.Parse(entrada[0]) - 1;
                int coluna = int.Parse(entrada[1]) - 1;

                if (tabuleiro[linha, coluna] == null)
                {
                    tabuleiro[linha, coluna] = jogadorAtual;
                    fimDeJogo = VerificarVitoria() || VerificarEmpate();

                    jogadorAtual = jogadorAtual == "X" ? "O" : "X";
                }
                else
                    Console.WriteLine("Posição ocupada, tente novamente!");
            }

            Console.Clear();
            ImprimirTabuleiro();
            Console.WriteLine(fimDeJogo ? "Fim de jogo!" : "");
        }

        static void ImprimirTabuleiro()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write($" {(tabuleiro[i, j] ?? " ")} {(j < 2 ? "|" : "")}");
                Console.WriteLine(i < 2 ? "\n---------" : "");
            }
        }

        static bool VerificarVitoria()
        {
            for (int i = 0; i < 3; i++)
                if ((tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2] && tabuleiro[i, 0] != null) ||
                    (tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i] && tabuleiro[0, i] != null))
                {
                    Console.WriteLine($"Vitória do jogador {jogadorAtual}!");
                    return true;
                }

            if ((tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2] && tabuleiro[0, 0] != null) ||
                (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0] && tabuleiro[0, 2] != null))
            {
                Console.WriteLine($"Vitória do jogador {jogadorAtual}!");
                return true;
            }
            return false;
        }

        static bool VerificarEmpate()
        {
            foreach (var celula in tabuleiro)
                if (celula == null) return false;

            Console.WriteLine("Deu velha!");
            return true;
        }
    }
}