using System;
using System.Security.Cryptography.Xml;
using TermoLib;
using static System.Windows.Forms.LinkLabel;

namespace TermoApp
{
    public partial class FormJogo : Form
    {
        public Termo termo;
        int coluna = 1;
        int coluna2;
        int tentativas = 6;

        public FormJogo()
        {
            InitializeComponent();
            termo = new Termo();
        }

        private void btnTeclado_Click(object sender, EventArgs e)
        {
            if (coluna > 5 || termo.palavraAtual > tentativas) return;
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
            if (termo.palavraAtual > 6 ||termo.palavraAtual > tentativas) return;
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
            if (termo.palavraAtual < 6)
            {
                var linha = termo.palavraAtual;
                var nomeButton = $"btn{linha}{1}";
                var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                buttonTabuleiro.BackColor = Color.Silver;
                dicaValtao();
                for (int i = 0; i <=3; i++) Valt_Click(sender, e);
            }
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
            Valt_Click(sender, e);
            btnEnter.Focus();
        }

        private void btnColuna2_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(2);
            Valt_Click(sender, e);
            btnEnter.Focus();
        }

        private void btnColuna3_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(3);
            Valt_Click(sender, e);
            btnEnter.Focus();
        }

        private void btnColuna4_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(4);
            Valt_Click(sender, e);
            btnEnter.Focus();
        }

        private void btnColuna5_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(5);
            Valt_Click(sender, e);
            btnEnter.Focus();
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
            dicaValtao();
            btn61.Enabled = true;
            btn62.Enabled = true;
            btn63.Enabled = true;
            btn64.Enabled = true;
            btn65.Enabled = true;
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

        private void FormJogo_Load(object sender, EventArgs e)
        {

        }

        private void dicaValtao()
        {
            if (termo.palavraAtual == 2)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.MuitoFeliz;
                labelValt.Visible = true;
                aceitarDica.Visible = true;
                negarDica.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
                labelValt.Visible = false;
                aceitarDica.Visible = false;
                negarDica.Visible = false;
            }
        }

        private void aceitarDica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sei que você usa break no código,\n" +
                "vai ficar sem dica e perdeu uma tentativa",
                            "Valtão ta na maldade", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
            dicaValtao();
            tentativas--;
            btn61.Enabled = false;
            btn62.Enabled = false;
            btn63.Enabled = false;
            btn64.Enabled = false;
            btn65.Enabled = false;
            for (int i = 0; i <= 3; i++) Valt_Click(sender, e);
            tentativas--;
            btn61.Text = "B";
            btn62.Text = "R";
            btn63.Text = "E";
            btn64.Text = "A";
            btn65.Text = "K";

        }

        private void negarDica_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            labelValt.Visible = false;
            aceitarDica.Visible = false;
            negarDica.Visible = false;
        }

        private void Valt_Click(object sender, EventArgs e)
        {
            Label labelValt = new Label();
            labelValt.Font = new Font("MS Reference Sans Serif", 15.75f, FontStyle.Bold);
            labelValt.Text = fraseValt();
            labelValt.AutoSize = true;

            this.Controls.Add(labelValt);

            Random random = new Random();
            int newX = random.Next(0, this.ClientSize.Width - labelValt.Width);
            int newY = random.Next(0, this.ClientSize.Height - labelValt.Height);

            labelValt.Location = new Point(newX, newY);
            
        }

        private string fraseValt()
        {
            string frase = "";
            Random random = new Random();
            int numAleatorio = random.Next(1, 7);
            if (numAleatorio == 1) frase = "if(finalizado == true) {BREAK;}";
            if (numAleatorio == 2) frase = "if(ValtãoFeliz == true) {RETURN;}";
            if (numAleatorio == 3) frase = "var novaVariavelGlobal";
            if (numAleatorio == 4) frase = "Seu código é desestruturado";
            if (numAleatorio == 5) frase = "Cade a intentação desse código?";
            if (numAleatorio == 6) frase = "Você não sabe conceito basico";
            if (numAleatorio == 7) frase = "while(true) {if() return;}";

            return frase;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}