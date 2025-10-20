using LibVLCSharp.Shared;
using System;
using System.Diagnostics;
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
        bool modoescuro = false;
        private bool musicaTocando = false;

        public LibVLC _libVLC;
        public MediaPlayer _mediaPlayer;

        public FormJogo()
        {
            InitializeComponent();
            termo = new Termo();
            Core.Initialize();

            _libVLC = new LibVLC();

            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mediaPlayer;
            // Dentro de public FormJogo()
            ouvirMusic.Image = Properties.Resources.play;
            ModoClaroEscuro.Image = Properties.Resources.dark_mode;
        }

        private void AplicarTemaEscuro(Control ctrl)
        {
            Color corFundo = Color.FromArgb(24, 26, 41);
            Color corBotao = Color.FromArgb(72, 79, 109);
            Color corTexto = Color.White;

            this.BackColor = corFundo;

            if (ctrl is Button btn)
            {
                btn.BackColor = corBotao;
                btn.ForeColor = corTexto;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                ouvirMusic.BackColor = corBotao;
                ouvirMusic.ForeColor = corTexto;
                ouvirMusic.FlatAppearance.BorderSize = 0;
                ouvirMusic.FlatAppearance.BorderColor = corFundo;
            }
            else if (ctrl is Label lbl)
            {
                lbl.ForeColor = corTexto;
            }
            else if (ctrl is GroupBox gb)
            {
                gb.ForeColor = corTexto;
                foreach (Control sub in gb.Controls)
                    AplicarTemaEscuro(sub);
            }
            else if (ctrl is RadioButton rdo)
            {
                rdo.ForeColor = corTexto;
            }
            else
            {
                foreach (Control sub in ctrl.Controls)
                    AplicarTemaEscuro(sub);
            }
        }

        private void AplicarTemaClaro(Control ctrl)
        {
            this.BackColor = Color.White;

            if (ctrl is Button btn)
            {
                btn.BackColor = SystemColors.Control;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.LightGray;
                ouvirMusic.BackColor = SystemColors.Control;
                ouvirMusic.ForeColor = Color.Black;

            }
            else if (ctrl is Label lbl)
            {
                lbl.ForeColor = Color.Black;
            }
            else if (ctrl is GroupBox gb)
            {
                gb.ForeColor = Color.Black;
                foreach (Control sub in gb.Controls)
                    AplicarTemaClaro(sub);
            }
            else if (ctrl is RadioButton rdo)
            {
                rdo.ForeColor = Color.Black;
            }
            else
            {
                foreach (Control sub in ctrl.Controls)
                    AplicarTemaClaro(sub);
            }
        }

        private void Button_Chance_Click(object sender, EventArgs e)
        {
            Button btnTema = (Button)sender;

            modoescuro = !modoescuro;

            if (modoescuro)
            {
                // Ativando o tema escuro
                foreach (Control ctrl in this.Controls)
                {
                    AplicarTemaEscuro(ctrl);
                }
                // O tema está escuro, então o botão deve mostrar o ícone para ir para o claro (SOL)
                btnTema.Image = Properties.Resources.light_mode;
            }
            else
            {
                // Voltando para o tema claro
                foreach (Control ctrl in this.Controls)
                {
                    AplicarTemaClaro(ctrl);
                }
                // O tema está claro, então o botão deve mostrar o ícone para ir para o escuro (LUA)
                btnTema.Image = Properties.Resources.dark_mode;
            }
            RepintarTabuleiroInteiro();
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
                    buttonTabuleiro.BackColor = Color.Silver;//cor da letra atual
                }

                nomeButton = $"btn{linha}{coluna - 1}";
                buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                buttonTabuleiro.BackColor = Color.Transparent;
            }
            if (coluna > 5)
            {
                btnEnter.Focus();
            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (coluna <= 1 || termo.palavraAtual > tentativas) return;

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

            // diminui a coluna para ir para a letra certa  que será apagada
            coluna--;

            nomeButton = $"btn{linha}{coluna}";
            buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Silver;

            buttonTabuleiro.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //if(termo.valtBreak == true) this.Close(); 
            if (termo.palavraAtual > tentativas || coluna <= 5) return;
            var palavra = string.Empty;
            for (int i = 1; i <= 5; i++)
            {
                var nomeBotao = $"btn{termo.palavraAtual}{i}";
                var botao = RetornaBotao(nomeBotao);
                palavra += botao.Text;
            }
            termo.ChecaPalavra(palavra);
            if (termo.valtBreak == true)
            {
                this.Close(); 
                return;       
            }
            AtualizaTabuleiro();
            coluna = 1;
            if (termo.JogoFinalizado)
            {
                MessageBox.Show("Parabéns você passou pelo Valtermir," +
                    " nos vemo semestre que vem!",
                                "VelTermo", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                tentativas = termo.palavraAtual - 1;
                termo.JogoFinalizado = false;

            }

            //muda o indicador da letra que esta sendo editada
            if (termo.palavraAtual <= tentativas)
            {
                var linha = termo.palavraAtual;
                var nomeButton = $"btn{linha}{1}";
                var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                buttonTabuleiro.BackColor = Color.Silver;
                //dicaValtao();
                for (int i = 0; i <= 3; i++) Valt_Click(sender, e);
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
            var nomeButton = $"btn{linha}{coluna}";
            var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Transparent;

            coluna = colunaAtual;

            nomeButton = $"btn{linha}{coluna}";
            buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
            buttonTabuleiro.BackColor = Color.Silver;

        }
        private void btnColuna1_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(1);
            Valt_Click(sender, e);
        }

        private void btnColuna2_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(2);
            Valt_Click(sender, e);
        }

        private void btnColuna3_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(3);
            Valt_Click(sender, e);
        }

        private void btnColuna4_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(4);
            Valt_Click(sender, e);
        }

        private void btnColuna5_Click(object sender, EventArgs e)
        {
            atualizaCorParaBtnColuna(5);
            Valt_Click(sender, e);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            coluna = 1;
            Color corPadraoTabuleiro = modoescuro ? Color.FromArgb(72, 79, 109) : SystemColors.Control;

            for (int lin = 1; lin <= 6; lin++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    var nomeButton = $"btn{lin}{col}";
                    var buttonTabuleiro = (Button)Controls.Find(nomeButton, true)[0];
                    buttonTabuleiro.Text = "";
                    buttonTabuleiro.BackColor = corPadraoTabuleiro;
                }
            }
            foreach (Control controle in this.Controls)
            {
                if (controle is Button)
                {
                    Button botao = (Button)controle;
                    botao.BackColor = corPadraoTabuleiro;
                }
            }
            btn11.BackColor = Color.Silver;
            termo.reiniciaJogo();
            //dicaValtao();
            tentativas = 6;
            btn61.Enabled = true;
            btn62.Enabled = true;
            btn63.Enabled = true;
            btn64.Enabled = true;
            btn65.Enabled = true;
        }

        private void FormJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;

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

        private void dicaValtao()//atualmente sem uso
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
            //dicaValtao();
            tentativas--;
            btn61.Enabled = false;
            btn62.Enabled = false;
            btn63.Enabled = false;
            btn64.Enabled = false;
            btn65.Enabled = false;
            for (int i = 0; i <= 3; i++) Valt_Click(sender, e);
            btn61.Text = "B";
            btn62.Text = "R";
            btn63.Text = "E";
            btn64.Text = "A";
            btn65.Text = "K";

            pictureBox1.Visible = false;
            labelValt.Visible = false;
            aceitarDica.Visible = false;
            negarDica.Visible = false;

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
            int numAleatorio = random.Next(1, 8);
            switch (numAleatorio)
            {
                case 1: frase = "if(finalizado == true) {BREAK;}"; break;
                case 2: frase = "if(ValtãoFeliz == true) {RETURN;}"; break;
                case 3: frase = "var novaVariavelGlobal"; break;
                case 4: frase = "Seu código é desestruturado"; break;
                case 5: frase = "Cade a indentação desse código?"; break;
                case 6: frase = "Você não sabe conceito basico"; break;
                case 7: frase = "while(true) {if() return;}"; break;
            }
            return frase;
        }

        private void RepintarTabuleiroInteiro()
        {
            for (int linha = 0; linha < termo.tabuleiro.Count; linha++)
            {
                for (int col = 0; col < 5; col++)
                {
                    var letra = termo.tabuleiro[linha][col];
                    var nomeBotao = $"btn{linha + 1}{col + 1}";
                    var botao = RetornaBotao(nomeBotao);
                    if (letra.Cor == 'V') botao.BackColor = Color.Green;
                    else if (letra.Cor == 'A') botao.BackColor = Color.Yellow;
                    else if (letra.Cor == 'P') botao.BackColor = Color.Gray;
                }
            }

            foreach (var par in termo.teclado)
            {
                if (par.Value != 'C')
                {
                    var nomeBotao = $"btn{par.Key}";
                    var botao = RetornaBotao(nomeBotao);
                    if (par.Value == 'V')
                    {
                        botao.BackColor = Color.Green;
                    }
                    else if (par.Value == 'A' && botao.BackColor != Color.Green)
                    {
                        botao.BackColor = Color.Yellow;
                    }
                    else if (par.Value == 'P' && botao.BackColor != Color.Green && botao.BackColor != Color.Yellow)
                    {
                        botao.BackColor = Color.Gray;
                    }
                }
            }
        }

        private void Musica_Click(object sender, EventArgs e)
        {
            musicaTocando = !musicaTocando;
            if (ouvirMusic.Checked == true)
            {
                ouvirMusic.Image = Properties.Resources.pause;
                videoView1.Visible = true;
                musica1.Visible = true;
                musica2.Visible = true;
                musica3.Visible = true;
                musica4.Visible = true;
            }
            else
            {
                ouvirMusic.Image = Properties.Resources.play;
                _mediaPlayer.Play();
                videoView1.Visible = false;
                musica1.Visible = false;
                musica2.Visible = false;
                musica3.Visible = false;
                musica4.Visible = false;
                ouvirMusic.Checked = false;
                musica1.Checked = false;
                musica2.Checked = false;
                musica3.Checked = false;
                musica4.Checked = false;
                _mediaPlayer.Stop();
            }
        }
        private void playVideo(string caminhoVideo)
        {
            using (var media = new Media(_libVLC, new Uri(caminhoVideo)))
            {
                _mediaPlayer.Play(media);
            }
        }

        private void musica1_CheckedChanged(object sender, EventArgs e)
        {
            //videoView1.Size = new Size(400, 630);
            playVideo(@"C:\Users\Nicolas Cerqueira\Documents\IFSP 6° semestre 2-2025\Programação orientada a eventos\JogoTermo\JogoTermo\TermoApp\Resources\É so o amor.mp4");
        }
        private void musica2_CheckedChanged(object sender, EventArgs e)
        {
            playVideo(@"C:\Users\Nicolas Cerqueira\Documents\IFSP 6° semestre 2-2025\Programação orientada a eventos\JogoTermo\JogoTermo\TermoApp\Resources\O grande amor da minha vida.mp4");
        }

        private void musica3_CheckedChanged(object sender, EventArgs e)
        {
            playVideo(@"C:\Users\Nicolas Cerqueira\Documents\IFSP 6° semestre 2-2025\Programação orientada a eventos\JogoTermo\JogoTermo\TermoApp\Resources\Pensando em voce.mp4");
        }

        private void musica4_CheckedChanged(object sender, EventArgs e)
        {
            playVideo(@"C:\Users\Nicolas Cerqueira\Documents\IFSP 6° semestre 2-2025\Programação orientada a eventos\JogoTermo\JogoTermo\TermoApp\Resources\Talvez seja amor.mp4");
        }

        private void dica_Click(object sender, EventArgs e)
        {
            int pos = 0;
            pos = termo.palavraAtual;

            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.MuitoFeliz;
            labelValt.Visible = true;
            aceitarDica.Visible = true;
            negarDica.Visible = true;

            //pictureBox1.Visible = false;
            //labelValt.Visible = false;
            //aceitarDica.Visible = false;
            //negarDica.Visible = false;

        }
    }
}