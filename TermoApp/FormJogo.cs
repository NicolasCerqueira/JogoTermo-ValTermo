using TermoLib;
using static System.Windows.Forms.LinkLabel;

namespace TermoApp
{
    public partial class FormJogo : Form
    {
        public Termo termo;
        int coluna = 1;
        int coluna2;

        public FormJogo()
        {
            InitializeComponent();
            termo = new Termo();
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            if (coluna > 5) return;
            // Botão do Teclado que foi clicado
            var button = (Button)sender;
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            // Botão do Tabuleiro da linha e coluna atual
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = button.Text;

            //buttonTabuleiro.BackColor = Color.Gray;
            coluna++;


            //daqui para baixo é para saber em qual letra estou digitando, em fase de teste
            if (coluna >= 2)
            {
                //para não tentar colorir a coluna 6
                if (coluna <= 5)
                {
                    //linha = termo.palavraAtual;
                    nomeButton = $"btn{linha}{coluna}";
                    buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                    buttonTabuleiro.BackColor = Color.Silver; //cor da letra atual
                }

                nomeButton = $"btn{linha}{coluna - 1}";
                buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                buttonTabuleiro.BackColor = Color.Transparent; // ou a cor padrão do seu botão
            }
            if (coluna > 5)
            {
                btnEnter.Focus();//para resolver o problema do enter na primeira linha
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            if (coluna <= 1) return;

            if (coluna <= 5)
            {
                coluna2 = coluna;
            }
            else
            {
                coluna2 = coluna - 1;
            }
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna2}";
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Transparent;//cor da letra atual

            nomeButton = $"btn{linha}{coluna - 1}";
            buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Silver;

            // diminui a coluna para ir para a letra certa  que será apagada
            coluna--;

            linha = termo.palavraAtual;
            nomeButton = $"btn{linha}{coluna}";
            buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            var palavra = string.Empty;
            for (int i = 1; i <= 5; i++)
            {
                var nomeBotao = $"btn{termo.palavraAtual}{i}";
                var botao = RetornaBotao(nomeBotao);
                palavra += botao.Text;
            }
            termo.ChecaPalavra(palavra);
            AtualizaTabuleiro();
            coluna = 1;
            if (termo.JogoFinalizado)
            {
                MessageBox.Show("Parabéns, Palavra Correta!",
                            "Jogo termo", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            }

            //muda o indicador da letra que esta sendo editada
            var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{1}";
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Silver;
        }

        private Button RetornaBotao(string name)
        {
            return (Button)Controls.Find(name, true)[0];
        }

        private void AtualizaTabuleiro()
        {
            for (int col = 1; col <= 5; col++)
            {
                var letra = termo.tabuleiro[termo.palavraAtual - 2][col - 1];
                var nomeBotaoTab = $"btn{termo.palavraAtual - 1}{col}";
                var botaoTab = RetornaBotao(nomeBotaoTab);
                var nomeBotaoKey = $"btn{letra.Caracter}";
                var botaoKey = RetornaBotao(nomeBotaoKey);
                if (letra.Cor == 'A')
                {
                    botaoTab.BackColor = Color.Yellow;
                    botaoKey.BackColor = Color.Yellow;
                }
                else if (letra.Cor == 'V')
                {
                    botaoTab.BackColor = Color.Green;
                    botaoKey.BackColor = Color.Green;
                }
                else
                {
                    botaoTab.BackColor = Color.Gray;
                    botaoKey.BackColor = Color.Gray;
                }
            }
        }

        private void atualizaCorParaBtnColuna(int colunaAtual)
        {
            var linha = termo.palavraAtual;
            if (coluna > 5)
            {
                coluna = 5;
            }
            //var linha = termo.palavraAtual;
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Transparent;

            coluna = colunaAtual;

            //linha = termo.palavraAtual; //desativei pq ja fazia em cima a mesma coisa, se der problema reativar
            nomeButton = $"btn{linha}{coluna}";
            buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Silver;

        }
        private void btnColuna1_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(1);
        }

        private void btnColuna2_Click(object sender, EventArgs e)
        {
            //coluna = 2;
            atualizaCorParaBtnColuna(2);
        }

        private void btnColuna3_Click(object sender, EventArgs e)
        {
            //coluna = 3;
            atualizaCorParaBtnColuna(3);
        }

        private void btnColuna4_Click(object sender, EventArgs e)
        {
            //coluna = 4;
            atualizaCorParaBtnColuna(4);
        }

        private void btnColuna5_Click(object sender, EventArgs e)
        {
            //coluna = 5;
            atualizaCorParaBtnColuna(5);
        }

        private void btnReiniciar_Click(object sender, EventArgs e) //terminar essa runção, falta reiniciar o teclado
        {
            coluna = 1;
            for (int lin = 1; lin <= 6; lin++) //percorre as linhas
            {
                for (int col = 1; col <= 5; col++)
                {
                    var nomeButton = $"btn{lin}{col}";
                    var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                    buttonTabuleiro.Text = "";

                    buttonTabuleiro.BackColor = Color.White;
                }
            }
            foreach (Control controle in jpbTeclado.Controls)
            {
                if (controle is Button)
                {
                    Button botao = (Button)controle;
                    botao.BackColor = Color.Transparent;
                }
            }
            btn11.BackColor = Color.Silver;
            termo.reiniciaJogo();
        }

        private void FormJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            /*if (e.KeyChar == (char)Keys.Enter)
            {
                jpbTeclado.Focus();
                btnEnter.PerformClick();
                //return;
            }*/

            if (char.IsLetter(tecla) && e.KeyChar != (char)Keys.Enter)
            {
                string teclaPressionada = tecla.ToString(); // pega o caracter da tecla pressionada
                teclaPressionada = teclaPressionada.ToUpper();

                var nomeButton = $"btn{teclaPressionada}";
                var buttonTeclado = (Button)Controls.Find(nomeButton, true)[0];
                buttonTeclado.PerformClick();

            }

            if (e.KeyChar == (char)Keys.Back)
            {
                backSpace.PerformClick();
            }
        }

        private void FormJogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                btnEnter.PerformClick();
            }
        }
    }
}