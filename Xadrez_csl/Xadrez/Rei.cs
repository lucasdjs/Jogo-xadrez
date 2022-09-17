using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiros;

namespace Xadrez
{
    internal class Rei : Peca
    {
        public Rei( Cor cor, Tabuleiro tabuleiro) : base(tabuleiro, cor)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p == null || p.cor != cor;

        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.Linhas, tabuleiro.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);

            if(tabuleiro.posicaoValida(pos) && PodeMover(pos)){
                mat[pos.Linha, pos.Coluna] = true;
            }

            //ne
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna+1);

            if (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.DefinirValores(posicao.Linha, posicao.Coluna+1);

            if (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //se
            pos.DefinirValores(posicao.Linha +1, posicao.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //abaixo
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna);

            if (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //so
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);

            if (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda

            pos.DefinirValores(posicao.Linha , posicao.Coluna + 1);

            if (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}
