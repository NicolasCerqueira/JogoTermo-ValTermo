namespace TermoLib
{
    public class Letra
    {
        public Letra(char caracter, char cor)
        {
            Caracter = caracter;
            Cor = cor;
        }
        public char Caracter;
        public char Cor;
    }

    public class Termo
    {
        public List<string> palavras;
        public string palavraSorteada;
        public List<List<Letra>> tabuleiro;
        public Dictionary<char, char> teclado;
        public int palavraAtual;
        public bool JogoFinalizado;
        public bool valtBreak = false;

        public Termo()
        {
            CarregaPalavras("Palavras.txt");
            SorteiaPalavra();
            palavraAtual = 1;
            JogoFinalizado = false;
            tabuleiro = new List<List<Letra>>();
            teclado = new Dictionary<char, char>();
            for (int i = 65; i <= 90; i++)
            {
                // Cinza - Não digitado | Verde - Posição correta | Amarelo - Na palavra | Preto - Não faz parte
                teclado.Add((char)i, 'C');
            }
        }
        
        public void reiniciaJogo()
        {
            SorteiaPalavra();
            palavraAtual = 1;
            JogoFinalizado = false;
            tabuleiro.Clear();
            teclado.Clear();
            for (int i = 65; i <= 90; i++)
            {
                // Cinza - Não digitado | Verde - Posição correta | Amarelo - Na palavra | Preto - Não faz parte
                teclado.Add((char)i, 'C');
            }
        }

        public void CarregaPalavras(string fileName)
        {
            palavras = File.ReadAllLines(fileName).ToList();
        }
        public void SorteiaPalavra()
        {
            Random rnd = new Random();
            var index = rnd.Next(0, palavras.Count() - 1);
            palavraSorteada = palavras[index];
        }

        public void ChecaPalavra(string palavra)
        {
            if (palavra == "BREAK") valtBreak = true;
            if (palavra == palavraSorteada)
                JogoFinalizado = true;
            if (palavra.Length != 5) return;

            var palavraTabuleiro = new List<Letra>();
            bool[] palavraSorteadaUsada = new bool[5];
            char[] coresDaRodada = new char[5];

            for (int i = 0; i < 5; i++)
            {
                coresDaRodada[i] = 'P';
            }

            for (int i = 0; i < 5; i++)
            {
                if (palavra[i] == palavraSorteada[i])
                {
                    coresDaRodada[i] = 'V';
                    palavraSorteadaUsada[i] = true;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (coresDaRodada[i] != 'V')
                {
                    bool achou = false; 
                    for (int j = 0; j < 5 && !achou; j++)
                    {
                        if (palavra[i] == palavraSorteada[j] && !palavraSorteadaUsada[j])
                        {
                            coresDaRodada[i] = 'A';
                            palavraSorteadaUsada[j] = true;
                            achou = true; 
                        }
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                char letra = palavra[i];
                char cor = coresDaRodada[i];

                palavraTabuleiro.Add(new Letra(letra, cor));

                if (cor == 'V')
                {
                    teclado[letra] = 'V';
                }
                else if (cor == 'A')
                {
                    if (teclado[letra] != 'V')
                    {
                        teclado[letra] = 'A';
                    }
                }
                else if (cor == 'P')
                {
                    if (teclado[letra] != 'V' && teclado[letra] != 'A')
                    {
                        teclado[letra] = 'P';
                    }
                }
            }

            tabuleiro.Add(palavraTabuleiro);
            palavraAtual++;
        }

        /// <summary>
        /// Verifica se a palavra fornecida existe na lista de palavras do jogo.
        /// </summary>
        /// <param name="palavra">A palavra a ser validada.</param>
        /// <returns>True se a palavra for válida, False caso contrário.</returns>
        public bool palavraValida(string palavra)
        {
            // Verifica se a lista de palavras carregada contém a palavra digitada.
            return palavras.Contains(palavra);
        }

    }
}
