namespace TermoApp
{
    partial class FormDicaValt
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
            label1 = new Label();
            negarDica = new Button();
            aceitarDica = new Button();
            labelValt = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sans Serif Collection", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 52);
            label1.Name = "label1";
            label1.Size = new Size(0, 64);
            label1.TabIndex = 0;
            // 
            // negarDica
            // 
            negarDica.BackColor = Color.Gainsboro;
            negarDica.FlatAppearance.BorderSize = 0;
            negarDica.FlatStyle = FlatStyle.Flat;
            negarDica.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
            negarDica.Location = new Point(358, 398);
            negarDica.Name = "negarDica";
            negarDica.Size = new Size(204, 63);
            negarDica.TabIndex = 11;
            negarDica.Text = "Recusar";
            negarDica.UseVisualStyleBackColor = false;
            negarDica.Click += negarDica_Click;
            // 
            // aceitarDica
            // 
            aceitarDica.BackColor = Color.Gainsboro;
            aceitarDica.FlatAppearance.BorderSize = 0;
            aceitarDica.FlatStyle = FlatStyle.Flat;
            aceitarDica.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
            aceitarDica.Location = new Point(94, 398);
            aceitarDica.Name = "aceitarDica";
            aceitarDica.Size = new Size(204, 63);
            aceitarDica.TabIndex = 10;
            aceitarDica.Text = "Aceitar";
            aceitarDica.UseVisualStyleBackColor = false;
            aceitarDica.Click += aceitarDica_Click;
            // 
            // labelValt
            // 
            labelValt.AutoSize = true;
            labelValt.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelValt.Location = new Point(43, 26);
            labelValt.Name = "labelValt";
            labelValt.Size = new Size(580, 29);
            labelValt.TabIndex = 9;
            labelValt.Text = "Valtão está feliz hoje, quer uma dica do Valtão?";
            labelValt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MuitoFeliz;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(61, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FormDicaValt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 486);
            Controls.Add(negarDica);
            Controls.Add(aceitarDica);
            Controls.Add(labelValt);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDicaValt";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Valtão ta na maldade";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button negarDica;
        private Button aceitarDica;
        private Label labelValt;
        private PictureBox pictureBox1;
    }
}