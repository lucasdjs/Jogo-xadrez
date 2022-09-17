using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiros
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca( Tabuleiro tabuleiro, Cor cor)
        {
            qtdMovimentos = 0;
            this.posicao = null;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
        }
        public void IncrementarQtdMovimentos()
        {
            qtdMovimentos++;
        }
    }
}
