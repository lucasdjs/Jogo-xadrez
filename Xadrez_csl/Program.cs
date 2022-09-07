using Tabuleiros;
using Xadrez_csl;
using Xadrez;


try {
    Tabuleiro tab = new Tabuleiro(8, 8);


    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 9));
    tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

    Tela.ImprimirTabuleiro(tab);

    Console.ReadLine();
}

catch(TabuleiroException e)
{
    Console.WriteLine(e.Message);
}

