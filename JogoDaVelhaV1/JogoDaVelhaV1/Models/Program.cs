namespace JogoDaVelhaV1.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();

            jogo.Jogadores = new List<Jogador>();

            Jogador inicio = new Jogador(TipoPeca.Vazia, "inicio");
            jogo.Jogadores.Add(inicio);

            Console.WriteLine("\nBem Vindo ao Jogo da Velha!");

            Console.WriteLine("Digite o nome do primeiro Jogador: ");
            Jogador jogador = new Jogador(TipoPeca.Cruzado, Console.ReadLine());
            jogo.Jogadores.Add(jogador);


            Console.WriteLine("\nDigite o nome do primeiro Jogador: ");
            Jogador oponente = new Jogador(TipoPeca.Circulo, Console.ReadLine());
            jogo.Jogadores.Add(oponente);

            //============================================================
            do
            {
                Console.Clear();

                Jogador jogadorDaVez = jogo.DecideTurno(jogo.Jogadores);

                jogo.Tabuleiro.ImprimeJogada(jogadorDaVez).ImprimeTabuleiro();

                Console.WriteLine($"{jogadorDaVez.Nome}, escolha um quadrante correspondente: ");

                jogo.MostraQuadrantes();

                Console.WriteLine("Escolha um dos quadrantes do template acima para realizar seu movimento:");
                jogadorDaVez.DecideQuadrante(int.Parse(Console.ReadLine()));

                jogo.TrocaTurno();

            } while (!jogo.FimDeJogo);






        }
    }
}

