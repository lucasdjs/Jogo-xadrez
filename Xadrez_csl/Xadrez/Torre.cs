using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiros;

namespace Xadrez
{
    internal class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tabuleiro) : base(tabuleiro, cor)
        {

        }

        public override string ToString()
        {
            return "T";
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
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            while (tabuleiro.posicaoValida(pos) && PodeMover(pos)){

                mat[pos.Linha, pos.Coluna] = true;
                if(tabuleiro.peca(pos)!=null && tabuleiro.peca(pos).cor!= cor)
                {
                    break;
                }
            }
            pos.Linha = pos.Linha - 1;
            //abaixo
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna);
            while (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {

                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
            }
            pos.Linha = pos.Linha + 1;

            //abaixo
            posicao.DefinirValores(posicao.Linha, posicao.Coluna+1);
            while (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {

                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
            }
            pos.Linha = pos.Coluna + 1;

            //abaixo
            posicao.DefinirValores(posicao.Linha, posicao.Coluna-1);
            while (tabuleiro.posicaoValida(pos) && PodeMover(pos))
            {

                mat[pos.Linha, pos.Coluna] = true;
                if (tabuleiro.peca(pos) != null && tabuleiro.peca(pos).cor != cor)
                {
                    break;
                }
            }
            pos.Linha = pos.Linha -1;

            return mat;
        }
    }
}
