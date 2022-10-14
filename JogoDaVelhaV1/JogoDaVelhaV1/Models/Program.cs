namespace JogoDaVelhaV1.Models
{
    public class Program
    {
        static void Main(string[] args)
        {

            IniciaNovoJogo();         
            
        }

        public static void IniciaNovoJogo()
        {
            Jogo jogo = new Jogo();

            jogo.Tabuleiro.InicializaTabuleiro();

            Console.WriteLine("\nBem Vindo ao Jogo da Velha!");

            Console.WriteLine("Digite o nome do primeiro Jogador: ");
            Jogador jogador = new Jogador(TipoPeca.Cruzado, Console.ReadLine());
            jogo.Jogadores.Add(jogador);
            jogo.Jogadores[0].Turno = true;


            Console.WriteLine("\nDigite o nome do primeiro Jogador: ");
            Jogador oponente = new Jogador(TipoPeca.Circulo, Console.ReadLine());
            jogo.Jogadores.Add(oponente);

            do
            {
                Console.Clear();

                jogo.Tabuleiro.ImprimeTabuleiro();

                var jogadorDaVez = jogo.DecideTurno();

                Console.WriteLine($"Jogador {jogadorDaVez.Nome}, escolha um dos quadrantes do template abaixo para realizar sua jogada");

                jogo.MostraQuadrantes();

                do
                {
                    jogadorDaVez.DecideQuadrante(int.Parse(Console.ReadLine()));

                } while (!jogo.VerificaQuadrante(jogadorDaVez));


                jogo.Tabuleiro.ImprimeJogada(jogadorDaVez);
                jogo.TrocaTurno();


            } while (!jogo.FimDeJogo);
        }

    }
}

