using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelhaV1.Models
{
    public enum TipoPeca
    {
        Cruzado = 0,
        Circulo = 1,
    }
    public struct Coordenadas
    {
        public int linha;
        public int coluna;

        public Coordenadas()
        {
            linha = -1;
            coluna = -1;
        }
    }
}
