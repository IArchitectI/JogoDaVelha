using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public class Jogo
    {
        public List<Jogador> Jogadores { get; set; }
        public Tabuleiro Tabuleiro { get; set; }
        public bool FimDeJogo { get; private set; }

        public Jogador Vencedor { get; private set; }
        public Jogo()
        {
            Jogadores = new List<Jogador>();
            FimDeJogo = false;
            Tabuleiro = new Tabuleiro(3);
        }

        public void MostraQuadrantes()
        {
            int quadrante = 1;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {quadrante}   ");
                    quadrante++;
                }
                Console.WriteLine("");
            }

        }
        public bool VerificaQuadrante(Jogador jogador)
        {
            if (!(Tabuleiro.Matriz[jogador._coordenadaEscolhida.linha, jogador._coordenadaEscolhida.coluna] == " - "))
                return false;
            return true;
        }
        public void TrocaTurno()
        {
            Jogadores[0].Turno = !(Jogadores[0].Turno);
            Jogadores[1].Turno = !(Jogadores[1].Turno);
        }
        public Jogador DecideTurno()
        {
            return (Jogadores[0].Turno == true) ? Jogadores[0] : Jogadores[1];
        }

        public void VerificaVencedor(Jogador jogador)
        {
            if ((Tabuleiro.Matriz[0,0] == Tabuleiro.Matriz[0,1] && Tabuleiro.Matriz[0,1] == Tabuleiro.Matriz[0,2]) && (Tabuleiro.Matriz[0,2] != " - ") ||
                (Tabuleiro.Matriz[1,0] == Tabuleiro.Matriz[1,1] && Tabuleiro.Matriz[1,1] == Tabuleiro.Matriz[1,2]) && (Tabuleiro.Matriz[1,2] != " - ") ||
                (Tabuleiro.Matriz[2,0] == Tabuleiro.Matriz[2,1] && Tabuleiro.Matriz[2,1] == Tabuleiro.Matriz[2,2]) && (Tabuleiro.Matriz[2,2] != " - ") ||
                (Tabuleiro.Matriz[0,0] == Tabuleiro.Matriz[1,0] && Tabuleiro.Matriz[1,0] == Tabuleiro.Matriz[2,0]) && (Tabuleiro.Matriz[2,0] != " - ") ||
                (Tabuleiro.Matriz[0,1] == Tabuleiro.Matriz[1,1] && Tabuleiro.Matriz[1,1] == Tabuleiro.Matriz[2,1]) && (Tabuleiro.Matriz[2,1] != " - ") ||
                (Tabuleiro.Matriz[0,2] == Tabuleiro.Matriz[1,2] && Tabuleiro.Matriz[1,2] == Tabuleiro.Matriz[2,0]) && (Tabuleiro.Matriz[2,0] != " - ") ||
                (Tabuleiro.Matriz[0,0] == Tabuleiro.Matriz[1,1] && Tabuleiro.Matriz[1,1] == Tabuleiro.Matriz[2,2]) && (Tabuleiro.Matriz[2,2] != " - ") ||
                (Tabuleiro.Matriz[0,2] == Tabuleiro.Matriz[1,1] && Tabuleiro.Matriz[1,1] == Tabuleiro.Matriz[2,0]) && (Tabuleiro.Matriz[2,0] != " - "))
            {
                FimDeJogo = true;
                Vencedor = jogador;
            }               
        }

        public void VerificaVelha()
        {            
            int contador = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(Tabuleiro.Matriz[i,j] != " - ")
                    {
                        contador++;
                    }
                }
            }
            
            if(contador == 9)
            {
                FimDeJogo = true;
                Console.WriteLine("Deu Velha!");
            }
        }


    }

}
