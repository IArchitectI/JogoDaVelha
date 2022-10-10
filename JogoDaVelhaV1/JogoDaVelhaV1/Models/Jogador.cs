using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public class Jogador
    {
        public string Nome { get; set; }

        public Coordenadas _coordenadaEscolhida;

        public bool Turno { get; set; }

        public TipoPeca Peca { get; set; }

        public Jogador(TipoPeca peca, string nome)
        {
            _coordenadaEscolhida = new Coordenadas();
            Turno = false;
            Peca = peca;
            Nome = nome;
        }
        public void DecideCoordenada()
        {

        }
        public void DecideQuadrante(int quadrante)
        {
            switch (quadrante)
            {
                case 1: _coordenadaEscolhida.linha = 0; _coordenadaEscolhida.coluna = 0; break;
                case 2: _coordenadaEscolhida.linha = 0; _coordenadaEscolhida.coluna = 1; break;
                case 3: _coordenadaEscolhida.linha = 0; _coordenadaEscolhida.coluna = 2; break;
                case 4: _coordenadaEscolhida.linha = 1; _coordenadaEscolhida.coluna = 0; break;
                case 5: _coordenadaEscolhida.linha = 1; _coordenadaEscolhida.coluna = 1; break;
                case 6: _coordenadaEscolhida.linha = 1; _coordenadaEscolhida.coluna = 2; break;
                case 7: _coordenadaEscolhida.linha = 2; _coordenadaEscolhida.coluna = 0; break;
                case 8: _coordenadaEscolhida.linha = 2; _coordenadaEscolhida.coluna = 1; break;
                case 9: _coordenadaEscolhida.linha = 2; _coordenadaEscolhida.coluna = 2; break;
                default: Console.WriteLine("Digite um quadrante válido."); break;
            }
        }

    }
}
