namespace TermoApp
{
    partial class Grafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            JogosTexto = new Label();
            VitoriasPctTexto = new Label();
            SequenciaTexto = new Label();
            DerrotasTexto = new Label();
            JogosValor = new Label();
            VitoriasPctValor = new Label();
            SequenciaValor = new Label();
            DerrotasValor = new Label();
            SuspendLayout();
            // 
            // JogosTexto
            // 
            JogosTexto.AutoSize = true;
            JogosTexto.Font = new Font("Segoe UI", 25F);
            JogosTexto.Location = new Point(52, 135);
            JogosTexto.Name = "JogosTexto";
            JogosTexto.Size = new Size(132, 46);
            JogosTexto.TabIndex = 0;
            JogosTexto.Text = "Vitórias";
            // 
            // VitoriasPctTexto
            // 
            VitoriasPctTexto.AutoSize = true;
            VitoriasPctTexto.Font = new Font("Segoe UI", 25F);
            VitoriasPctTexto.Location = new Point(254, 135);
            VitoriasPctTexto.Name = "VitoriasPctTexto";
            VitoriasPctTexto.Size = new Size(183, 46);
            VitoriasPctTexto.TabIndex = 1;
            VitoriasPctTexto.Text = "De Vitórias";
            // 
            // SequenciaTexto
            // 
            SequenciaTexto.AutoSize = true;
            SequenciaTexto.Font = new Font("Segoe UI", 25F);
            SequenciaTexto.Location = new Point(511, 135);
            SequenciaTexto.Name = "SequenciaTexto";
            SequenciaTexto.Size = new Size(341, 46);
            SequenciaTexto.TabIndex = 2;
            SequenciaTexto.Text = "Sequência de Vitorias";
            // 
            // DerrotasTexto
            // 
            DerrotasTexto.AutoSize = true;
            DerrotasTexto.Font = new Font("Segoe UI", 25F);
            DerrotasTexto.Location = new Point(895, 135);
            DerrotasTexto.Name = "DerrotasTexto";
            DerrotasTexto.Size = new Size(149, 46);
            DerrotasTexto.TabIndex = 3;
            DerrotasTexto.Text = "Derrotas";
            // 
            // JogosValor
            // 
            JogosValor.AutoSize = true;
            JogosValor.Font = new Font("Segoe UI", 25F);
            JogosValor.Location = new Point(77, 72);
            JogosValor.Name = "JogosValor";
            JogosValor.Size = new Size(38, 46);
            JogosValor.TabIndex = 4;
            JogosValor.Text = "0";
            // 
            // VitoriasPctValor
            // 
            VitoriasPctValor.AutoSize = true;
            VitoriasPctValor.Font = new Font("Segoe UI", 25F);
            VitoriasPctValor.Location = new Point(293, 72);
            VitoriasPctValor.Name = "VitoriasPctValor";
            VitoriasPctValor.Size = new Size(38, 46);
            VitoriasPctValor.TabIndex = 5;
            VitoriasPctValor.Text = "0";
            // 
            // SequenciaValor
            // 
            SequenciaValor.AutoSize = true;
            SequenciaValor.Font = new Font("Segoe UI", 25F);
            SequenciaValor.Location = new Point(626, 72);
            SequenciaValor.Name = "SequenciaValor";
            SequenciaValor.Size = new Size(38, 46);
            SequenciaValor.TabIndex = 6;
            SequenciaValor.Text = "0";
            // 
            // DerrotasValor
            // 
            DerrotasValor.AutoSize = true;
            DerrotasValor.Font = new Font("Segoe UI", 25F);
            DerrotasValor.Location = new Point(922, 72);
            DerrotasValor.Name = "DerrotasValor";
            DerrotasValor.Size = new Size(38, 46);
            DerrotasValor.TabIndex = 7;
            DerrotasValor.Text = "0";
            // 
            // Grafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 275);
            Controls.Add(DerrotasValor);
            Controls.Add(SequenciaValor);
            Controls.Add(VitoriasPctValor);
            Controls.Add(JogosValor);
            Controls.Add(DerrotasTexto);
            Controls.Add(SequenciaTexto);
            Controls.Add(VitoriasPctTexto);
            Controls.Add(JogosTexto);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Grafico";
            ShowIcon = false;
            Text = "Grafico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label JogosTexto;
        private Label VitoriasPctTexto;
        private Label SequenciaTexto;
        private Label DerrotasTexto;
        private Label JogosValor;
        private Label VitoriasPctValor;
        private Label SequenciaValor;
        private Label DerrotasValor;
    }
}