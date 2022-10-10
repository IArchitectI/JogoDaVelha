using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public class Tabuleiro
    {
        public string[,] Matriz { get; set; }

        public Tabuleiro(int tamanho)
        {
            Matriz = new string[tamanho, tamanho];
        }

        public Tabuleiro ImprimeJogada(Jogador jogador)
        {
            for (int i = 0; i < Math.Sqrt(Matriz.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(Matriz.Length); j++)
                {
                    if ((jogador.Peca == TipoPeca.Cruzado) && (i == jogador._coordenadaEscolhida.linha && j == jogador._coordenadaEscolhida.coluna))
                    {
                        this.Matriz[i, j] = " X ";
                    }
                    else if ((jogador.Peca == TipoPeca.Circulo) && (i == jogador._coordenadaEscolhida.linha && j == jogador._coordenadaEscolhida.coluna))
                    {
                        this.Matriz[i, j] = " O ";
                    }
                    else
                    {
                        Matriz[i, j] = " - ";
                    }


                }
            }

            return this;
        }

        public void ImprimeTabuleiro()
        {
            for (int i = 0; i < Math.Sqrt(Matriz.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(Matriz.Length); j++)
                {
                    Console.Write($" {this.Matriz[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
