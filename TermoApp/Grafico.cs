using System;
using System.Drawing;
using System.Windows.Forms;

namespace TermoApp
{
    public partial class Grafico : Form
    {
        public Grafico(int jogos, int vitorias, int sequencia, int derrotas)
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(24, 26, 41);
            this.ForeColor = Color.White;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Progresso";

            double porcentagemVitorias = 0;
            if (jogos > 0)
            {
                porcentagemVitorias = ((double)vitorias / jogos) * 100;
            }

            JogosValor.Text = jogos.ToString();
            VitoriasPctValor.Text = $"{porcentagemVitorias:F0}%";
            SequenciaValor.Text = sequencia.ToString();
            DerrotasValor.Text = derrotas.ToString();

            EstilizarLabels();
        }

        private void EstilizarLabels()
        {
            Font fonteValor = new Font("Segoe UI", 28, FontStyle.Bold);
            Font fonteTexto = new Font("Segoe UI", 10);

            JogosValor.Font = fonteValor;
            VitoriasPctValor.Font = fonteValor;
            SequenciaValor.Font = fonteValor;
            DerrotasValor.Font = fonteValor;

            JogosTexto.Font = fonteTexto;
            VitoriasPctTexto.Font = fonteTexto;
            SequenciaTexto.Font = fonteTexto;
            DerrotasTexto.Font = fonteTexto;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label)
                {
                    ((Label)ctrl).TextAlign = ContentAlignment.MiddleCenter;
                }
            }
        }
    }
}