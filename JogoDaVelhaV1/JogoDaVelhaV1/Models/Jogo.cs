using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public class Jogo
    {
        public List<Jogador> Jogadores { get; set; }
        public Tabuleiro Tabuleiro { get; set; }
        public bool FimDeJogo { get; private set; }

        public Jogo()
        {
            FimDeJogo = false;
            Tabuleiro = new Tabuleiro(3);
        }

        public void RenderizaTela()
        {
            Console.WriteLine("Bem Vindo ao Jogo Da Velha!");

            Tabuleiro.ImprimeJogada(DecideTurno(Jogadores));

        }
        public void MostraQuadrantes()
        {
            int quadrante = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {quadrante} ");
                    quadrante++;
                }
                Console.WriteLine("");
            }

        }
        public void TrocaTurno()
        {
            Jogadores[0].Turno = !(Jogadores[0].Turno);
            Jogadores[1].Turno = !(Jogadores[1].Turno);
        }
        public Jogador DecideTurno(List<Jogador> jogadores)
        {
            return (jogadores[0].Turno == true) ? jogadores[0] : jogadores[1];
        }


    }

}
