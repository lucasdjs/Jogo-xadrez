using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiros;

namespace Tabuleiros
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        public Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }
        public bool posicaoValida(Posicao pos) { 
        if(pos.Linha<0|| pos.Linha>=Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }
        return true;
        }

        public void ValidarPosicao(Posicao pos) {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida!");

            }
        }

        public bool existePeca(Posicao pos) {

            ValidarPosicao(pos);
            return peca(pos) != null;
        }
    }
}
