namespace TermoApp;

partial class FormJogo
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureBox1 = new PictureBox();
        ModoClaroEscuro = new Button();
        btnReiniciar = new Button();
        label1 = new Label();
        labelValt = new Label();
        aceitarDica = new Button();
        negarDica = new Button();
        videoView1 = new LibVLCSharp.WinForms.VideoView();
        musica1 = new RadioButton();
        musica2 = new RadioButton();
        musica3 = new RadioButton();
        musica4 = new RadioButton();
        ouvirMusic = new CheckBox();
        dica = new Button();
        btn65 = new Button();
        btn64 = new Button();
        btn63 = new Button();
        btn62 = new Button();
        btn61 = new Button();
        btn55 = new Button();
        btn54 = new Button();
        btn53 = new Button();
        btn52 = new Button();
        btn51 = new Button();
        btn45 = new Button();
        btn44 = new Button();
        btn43 = new Button();
        btn42 = new Button();
        btn41 = new Button();
        btn35 = new Button();
        btn34 = new Button();
        btn33 = new Button();
        btn32 = new Button();
        btn31 = new Button();
        btn25 = new Button();
        btn24 = new Button();
        btn23 = new Button();
        btn22 = new Button();
        btn21 = new Button();
        btn15 = new Button();
        btn14 = new Button();
        btn13 = new Button();
        btn12 = new Button();
        btn11 = new Button();
        btnEnter = new Button();
        btnM = new Button();
        btnN = new Button();
        btnB = new Button();
        btnV = new Button();
        btnC = new Button();
        btnX = new Button();
        btnZ = new Button();
        backSpace = new Button();
        btnL = new Button();
        btnK = new Button();
        btnJ = new Button();
        btnH = new Button();
        btnG = new Button();
        btnF = new Button();
        btnD = new Button();
        btnS = new Button();
        btnA = new Button();
        btnP = new Button();
        btnO = new Button();
        btnI = new Button();
        btnU = new Button();
        btnY = new Button();
        btnT = new Button();
        btnR = new Button();
        btnE = new Button();
        btnW = new Button();
        btnQ = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new Point(90, 124);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(540, 330);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 4;
        pictureBox1.TabStop = false;
        pictureBox1.Visible = false;
        // 
        // ModoClaroEscuro
        // 
        ModoClaroEscuro.BackColor = Color.Gainsboro;
        ModoClaroEscuro.BackgroundImageLayout = ImageLayout.Stretch;
        ModoClaroEscuro.FlatAppearance.BorderSize = 0;
        ModoClaroEscuro.FlatStyle = FlatStyle.Flat;
        ModoClaroEscuro.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        ModoClaroEscuro.Location = new Point(695, 12);
        ModoClaroEscuro.Name = "ModoClaroEscuro";
        ModoClaroEscuro.Size = new Size(60, 60);
        ModoClaroEscuro.TabIndex = 28;
        ModoClaroEscuro.UseVisualStyleBackColor = false;
        ModoClaroEscuro.Click += Button_Chance_Click;
        // 
        // btnReiniciar
        // 
        btnReiniciar.BackColor = Color.Gainsboro;
        btnReiniciar.FlatAppearance.BorderColor = Color.Silver;
        btnReiniciar.FlatAppearance.BorderSize = 0;
        btnReiniciar.FlatStyle = FlatStyle.Flat;
        btnReiniciar.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnReiniciar.Location = new Point(705, 699);
        btnReiniciar.Name = "btnReiniciar";
        btnReiniciar.Size = new Size(498, 75);
        btnReiniciar.TabIndex = 2;
        btnReiniciar.Text = "Reiniciar";
        btnReiniciar.UseVisualStyleBackColor = false;
        btnReiniciar.Click += btnReiniciar_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("MS Reference Sans Serif", 48F, FontStyle.Bold);
        label1.Location = new Point(791, 27);
        label1.Name = "label1";
        label1.Size = new Size(347, 79);
        label1.TabIndex = 3;
        label1.Text = "ValTermo";
        // 
        // labelValt
        // 
        labelValt.AutoSize = true;
        labelValt.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelValt.Location = new Point(90, 88);
        labelValt.Name = "labelValt";
        labelValt.Size = new Size(580, 29);
        labelValt.TabIndex = 5;
        labelValt.Text = "Valtão está feliz hoje, quer uma dica do Valtão?";
        labelValt.TextAlign = ContentAlignment.MiddleCenter;
        labelValt.Visible = false;
        labelValt.Click += Valt_Click;
        // 
        // aceitarDica
        // 
        aceitarDica.BackColor = Color.Gainsboro;
        aceitarDica.FlatAppearance.BorderSize = 0;
        aceitarDica.FlatStyle = FlatStyle.Flat;
        aceitarDica.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        aceitarDica.Location = new Point(131, 460);
        aceitarDica.Name = "aceitarDica";
        aceitarDica.Size = new Size(204, 63);
        aceitarDica.TabIndex = 6;
        aceitarDica.Text = "Aceitar";
        aceitarDica.UseVisualStyleBackColor = false;
        aceitarDica.Visible = false;
        aceitarDica.Click += aceitarDica_Click;
        // 
        // negarDica
        // 
        negarDica.BackColor = Color.Gainsboro;
        negarDica.FlatAppearance.BorderSize = 0;
        negarDica.FlatStyle = FlatStyle.Flat;
        negarDica.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        negarDica.Location = new Point(383, 460);
        negarDica.Name = "negarDica";
        negarDica.Size = new Size(204, 63);
        negarDica.TabIndex = 7;
        negarDica.Text = "Recusar";
        negarDica.UseVisualStyleBackColor = false;
        negarDica.Visible = false;
        negarDica.Click += negarDica_Click;
        // 
        // videoView1
        // 
        videoView1.BackColor = Color.Gray;
        videoView1.Location = new Point(1366, 77);
        videoView1.MediaPlayer = null;
        videoView1.Name = "videoView1";
        videoView1.Size = new Size(460, 712);
        videoView1.TabIndex = 10;
        videoView1.Text = "videoView1";
        videoView1.Visible = false;
        // 
        // musica1
        // 
        musica1.AutoSize = true;
        musica1.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        musica1.Location = new Point(1366, 9);
        musica1.Name = "musica1";
        musica1.Size = new Size(144, 28);
        musica1.TabIndex = 11;
        musica1.Text = "É so o amor";
        musica1.UseVisualStyleBackColor = true;
        musica1.Visible = false;
        musica1.CheckedChanged += musica1_CheckedChanged;
        // 
        // musica2
        // 
        musica2.AutoSize = true;
        musica2.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        musica2.Location = new Point(1511, 9);
        musica2.Name = "musica2";
        musica2.Size = new Size(315, 28);
        musica2.TabIndex = 12;
        musica2.Text = "O grande amor da minha vida";
        musica2.UseVisualStyleBackColor = true;
        musica2.Visible = false;
        musica2.CheckedChanged += musica2_CheckedChanged;
        // 
        // musica3
        // 
        musica3.AutoSize = true;
        musica3.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        musica3.Location = new Point(1366, 43);
        musica3.Name = "musica3";
        musica3.Size = new Size(206, 28);
        musica3.TabIndex = 13;
        musica3.Text = "Pensando em você";
        musica3.UseVisualStyleBackColor = true;
        musica3.Visible = false;
        musica3.CheckedChanged += musica3_CheckedChanged;
        // 
        // musica4
        // 
        musica4.AutoSize = true;
        musica4.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        musica4.Location = new Point(1635, 43);
        musica4.Name = "musica4";
        musica4.Size = new Size(191, 28);
        musica4.TabIndex = 14;
        musica4.Text = "Talvez seja amor";
        musica4.UseVisualStyleBackColor = true;
        musica4.Visible = false;
        musica4.CheckedChanged += musica4_CheckedChanged;
        // 
        // ouvirMusic
        // 
        ouvirMusic.Appearance = Appearance.Button;
        ouvirMusic.BackColor = Color.Gainsboro;
        ouvirMusic.FlatAppearance.BorderSize = 0;
        ouvirMusic.FlatStyle = FlatStyle.Flat;
        ouvirMusic.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ouvirMusic.ForeColor = Color.Transparent;
        ouvirMusic.Location = new Point(1155, 12);
        ouvirMusic.Name = "ouvirMusic";
        ouvirMusic.Size = new Size(60, 60);
        ouvirMusic.TabIndex = 15;
        ouvirMusic.TextAlign = ContentAlignment.MiddleCenter;
        ouvirMusic.UseVisualStyleBackColor = false;
        ouvirMusic.CheckedChanged += Musica_Click;
        // 
        // dica
        // 
        dica.BackColor = Color.Gainsboro;
        dica.BackgroundImageLayout = ImageLayout.Center;
        dica.FlatAppearance.BorderSize = 0;
        dica.FlatStyle = FlatStyle.Flat;
        dica.Image = Properties.Resources.dicaValt;
        dica.Location = new Point(629, 12);
        dica.Name = "dica";
        dica.Size = new Size(60, 60);
        dica.TabIndex = 16;
        dica.UseVisualStyleBackColor = false;
        dica.Click += dica_Click;
        // 
        // btn65
        // 
        btn65.BackColor = Color.Gainsboro;
        btn65.FlatAppearance.BorderSize = 0;
        btn65.FlatStyle = FlatStyle.Flat;
        btn65.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn65.Location = new Point(1089, 588);
        btn65.Name = "btn65";
        btn65.Size = new Size(80, 80);
        btn65.TabIndex = 59;
        btn65.UseVisualStyleBackColor = false;
        btn65.Click += btnColuna5_Click;
        // 
        // btn64
        // 
        btn64.BackColor = Color.Gainsboro;
        btn64.FlatAppearance.BorderSize = 0;
        btn64.FlatStyle = FlatStyle.Flat;
        btn64.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn64.Location = new Point(1003, 588);
        btn64.Name = "btn64";
        btn64.Size = new Size(80, 80);
        btn64.TabIndex = 58;
        btn64.UseVisualStyleBackColor = false;
        btn64.Click += btnColuna4_Click;
        // 
        // btn63
        // 
        btn63.BackColor = Color.Gainsboro;
        btn63.FlatAppearance.BorderSize = 0;
        btn63.FlatStyle = FlatStyle.Flat;
        btn63.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn63.Location = new Point(917, 588);
        btn63.Name = "btn63";
        btn63.Size = new Size(80, 80);
        btn63.TabIndex = 57;
        btn63.UseVisualStyleBackColor = false;
        btn63.Click += btnColuna3_Click;
        // 
        // btn62
        // 
        btn62.BackColor = Color.Gainsboro;
        btn62.FlatAppearance.BorderSize = 0;
        btn62.FlatStyle = FlatStyle.Flat;
        btn62.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn62.Location = new Point(831, 588);
        btn62.Name = "btn62";
        btn62.Size = new Size(80, 80);
        btn62.TabIndex = 56;
        btn62.UseVisualStyleBackColor = false;
        btn62.Click += btnColuna2_Click;
        // 
        // btn61
        // 
        btn61.BackColor = Color.Gainsboro;
        btn61.FlatAppearance.BorderSize = 0;
        btn61.FlatStyle = FlatStyle.Flat;
        btn61.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn61.Location = new Point(745, 588);
        btn61.Name = "btn61";
        btn61.Size = new Size(80, 80);
        btn61.TabIndex = 55;
        btn61.UseVisualStyleBackColor = false;
        btn61.Click += btnColuna1_Click;
        // 
        // btn55
        // 
        btn55.BackColor = Color.Gainsboro;
        btn55.FlatAppearance.BorderSize = 0;
        btn55.FlatStyle = FlatStyle.Flat;
        btn55.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn55.Location = new Point(1089, 502);
        btn55.Name = "btn55";
        btn55.Size = new Size(80, 80);
        btn55.TabIndex = 54;
        btn55.UseVisualStyleBackColor = false;
        btn55.Click += btnColuna5_Click;
        // 
        // btn54
        // 
        btn54.BackColor = Color.Gainsboro;
        btn54.FlatAppearance.BorderSize = 0;
        btn54.FlatStyle = FlatStyle.Flat;
        btn54.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn54.Location = new Point(1003, 502);
        btn54.Name = "btn54";
        btn54.Size = new Size(80, 80);
        btn54.TabIndex = 53;
        btn54.UseVisualStyleBackColor = false;
        btn54.Click += btnColuna4_Click;
        // 
        // btn53
        // 
        btn53.BackColor = Color.Gainsboro;
        btn53.FlatAppearance.BorderSize = 0;
        btn53.FlatStyle = FlatStyle.Flat;
        btn53.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn53.Location = new Point(917, 502);
        btn53.Name = "btn53";
        btn53.Size = new Size(80, 80);
        btn53.TabIndex = 52;
        btn53.UseVisualStyleBackColor = false;
        btn53.Click += btnColuna3_Click;
        // 
        // btn52
        // 
        btn52.BackColor = Color.Gainsboro;
        btn52.FlatAppearance.BorderSize = 0;
        btn52.FlatStyle = FlatStyle.Flat;
        btn52.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn52.Location = new Point(831, 502);
        btn52.Name = "btn52";
        btn52.Size = new Size(80, 80);
        btn52.TabIndex = 51;
        btn52.UseVisualStyleBackColor = false;
        btn52.Click += btnColuna2_Click;
        // 
        // btn51
        // 
        btn51.BackColor = Color.Gainsboro;
        btn51.FlatAppearance.BorderSize = 0;
        btn51.FlatStyle = FlatStyle.Flat;
        btn51.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn51.Location = new Point(745, 502);
        btn51.Name = "btn51";
        btn51.Size = new Size(80, 80);
        btn51.TabIndex = 50;
        btn51.UseVisualStyleBackColor = false;
        btn51.Click += btnColuna1_Click;
        // 
        // btn45
        // 
        btn45.BackColor = Color.Gainsboro;
        btn45.FlatAppearance.BorderSize = 0;
        btn45.FlatStyle = FlatStyle.Flat;
        btn45.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn45.Location = new Point(1089, 416);
        btn45.Name = "btn45";
        btn45.Size = new Size(80, 80);
        btn45.TabIndex = 49;
        btn45.UseVisualStyleBackColor = false;
        btn45.Click += btnColuna5_Click;
        // 
        // btn44
        // 
        btn44.BackColor = Color.Gainsboro;
        btn44.FlatAppearance.BorderSize = 0;
        btn44.FlatStyle = FlatStyle.Flat;
        btn44.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn44.Location = new Point(1003, 416);
        btn44.Name = "btn44";
        btn44.Size = new Size(80, 80);
        btn44.TabIndex = 48;
        btn44.UseVisualStyleBackColor = false;
        btn44.Click += btnColuna4_Click;
        // 
        // btn43
        // 
        btn43.BackColor = Color.Gainsboro;
        btn43.FlatAppearance.BorderSize = 0;
        btn43.FlatStyle = FlatStyle.Flat;
        btn43.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn43.Location = new Point(917, 416);
        btn43.Name = "btn43";
        btn43.Size = new Size(80, 80);
        btn43.TabIndex = 47;
        btn43.UseVisualStyleBackColor = false;
        btn43.Click += btnColuna3_Click;
        // 
        // btn42
        // 
        btn42.BackColor = Color.Gainsboro;
        btn42.FlatAppearance.BorderSize = 0;
        btn42.FlatStyle = FlatStyle.Flat;
        btn42.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn42.Location = new Point(831, 416);
        btn42.Name = "btn42";
        btn42.Size = new Size(80, 80);
        btn42.TabIndex = 46;
        btn42.UseVisualStyleBackColor = false;
        btn42.Click += btnColuna2_Click;
        // 
        // btn41
        // 
        btn41.BackColor = Color.Gainsboro;
        btn41.FlatAppearance.BorderSize = 0;
        btn41.FlatStyle = FlatStyle.Flat;
        btn41.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn41.Location = new Point(745, 416);
        btn41.Name = "btn41";
        btn41.Size = new Size(80, 80);
        btn41.TabIndex = 45;
        btn41.UseVisualStyleBackColor = false;
        btn41.Click += btnColuna1_Click;
        // 
        // btn35
        // 
        btn35.BackColor = Color.Gainsboro;
        btn35.FlatAppearance.BorderSize = 0;
        btn35.FlatStyle = FlatStyle.Flat;
        btn35.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn35.Location = new Point(1089, 330);
        btn35.Name = "btn35";
        btn35.Size = new Size(80, 80);
        btn35.TabIndex = 44;
        btn35.UseVisualStyleBackColor = false;
        btn35.Click += btnColuna5_Click;
        // 
        // btn34
        // 
        btn34.BackColor = Color.Gainsboro;
        btn34.FlatAppearance.BorderSize = 0;
        btn34.FlatStyle = FlatStyle.Flat;
        btn34.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn34.Location = new Point(1003, 330);
        btn34.Name = "btn34";
        btn34.Size = new Size(80, 80);
        btn34.TabIndex = 43;
        btn34.UseVisualStyleBackColor = false;
        btn34.Click += btnColuna4_Click;
        // 
        // btn33
        // 
        btn33.BackColor = Color.Gainsboro;
        btn33.FlatAppearance.BorderSize = 0;
        btn33.FlatStyle = FlatStyle.Flat;
        btn33.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn33.Location = new Point(917, 330);
        btn33.Name = "btn33";
        btn33.Size = new Size(80, 80);
        btn33.TabIndex = 42;
        btn33.UseVisualStyleBackColor = false;
        btn33.Click += btnColuna3_Click;
        // 
        // btn32
        // 
        btn32.BackColor = Color.Gainsboro;
        btn32.FlatAppearance.BorderSize = 0;
        btn32.FlatStyle = FlatStyle.Flat;
        btn32.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn32.Location = new Point(831, 330);
        btn32.Name = "btn32";
        btn32.Size = new Size(80, 80);
        btn32.TabIndex = 41;
        btn32.UseVisualStyleBackColor = false;
        btn32.Click += btnColuna2_Click;
        // 
        // btn31
        // 
        btn31.BackColor = Color.Gainsboro;
        btn31.FlatAppearance.BorderSize = 0;
        btn31.FlatStyle = FlatStyle.Flat;
        btn31.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn31.Location = new Point(745, 330);
        btn31.Name = "btn31";
        btn31.Size = new Size(80, 80);
        btn31.TabIndex = 40;
        btn31.UseVisualStyleBackColor = false;
        btn31.Click += btnColuna1_Click;
        // 
        // btn25
        // 
        btn25.BackColor = Color.Gainsboro;
        btn25.FlatAppearance.BorderSize = 0;
        btn25.FlatStyle = FlatStyle.Flat;
        btn25.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn25.Location = new Point(1089, 244);
        btn25.Name = "btn25";
        btn25.Size = new Size(80, 80);
        btn25.TabIndex = 39;
        btn25.UseVisualStyleBackColor = false;
        btn25.Click += btnColuna5_Click;
        // 
        // btn24
        // 
        btn24.BackColor = Color.Gainsboro;
        btn24.FlatAppearance.BorderSize = 0;
        btn24.FlatStyle = FlatStyle.Flat;
        btn24.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn24.Location = new Point(1003, 244);
        btn24.Name = "btn24";
        btn24.Size = new Size(80, 80);
        btn24.TabIndex = 38;
        btn24.UseVisualStyleBackColor = false;
        btn24.Click += btnColuna4_Click;
        // 
        // btn23
        // 
        btn23.BackColor = Color.Gainsboro;
        btn23.FlatAppearance.BorderSize = 0;
        btn23.FlatStyle = FlatStyle.Flat;
        btn23.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn23.Location = new Point(917, 244);
        btn23.Name = "btn23";
        btn23.Size = new Size(80, 80);
        btn23.TabIndex = 37;
        btn23.UseVisualStyleBackColor = false;
        btn23.Click += btnColuna3_Click;
        // 
        // btn22
        // 
        btn22.BackColor = Color.Gainsboro;
        btn22.FlatAppearance.BorderSize = 0;
        btn22.FlatStyle = FlatStyle.Flat;
        btn22.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn22.Location = new Point(831, 244);
        btn22.Name = "btn22";
        btn22.Size = new Size(80, 80);
        btn22.TabIndex = 36;
        btn22.UseVisualStyleBackColor = false;
        btn22.Click += btnColuna2_Click;
        // 
        // btn21
        // 
        btn21.BackColor = Color.Gainsboro;
        btn21.FlatAppearance.BorderSize = 0;
        btn21.FlatStyle = FlatStyle.Flat;
        btn21.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn21.Location = new Point(745, 244);
        btn21.Name = "btn21";
        btn21.Size = new Size(80, 80);
        btn21.TabIndex = 35;
        btn21.UseVisualStyleBackColor = false;
        btn21.Click += btnColuna1_Click;
        // 
        // btn15
        // 
        btn15.BackColor = Color.Gainsboro;
        btn15.FlatAppearance.BorderSize = 0;
        btn15.FlatStyle = FlatStyle.Flat;
        btn15.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn15.Location = new Point(1089, 158);
        btn15.Name = "btn15";
        btn15.Size = new Size(80, 80);
        btn15.TabIndex = 34;
        btn15.UseVisualStyleBackColor = false;
        btn15.Click += btnColuna5_Click;
        // 
        // btn14
        // 
        btn14.BackColor = Color.Gainsboro;
        btn14.FlatAppearance.BorderSize = 0;
        btn14.FlatStyle = FlatStyle.Flat;
        btn14.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn14.Location = new Point(1003, 158);
        btn14.Name = "btn14";
        btn14.Size = new Size(80, 80);
        btn14.TabIndex = 33;
        btn14.UseVisualStyleBackColor = false;
        btn14.Click += btnColuna4_Click;
        // 
        // btn13
        // 
        btn13.BackColor = Color.Gainsboro;
        btn13.FlatAppearance.BorderSize = 0;
        btn13.FlatStyle = FlatStyle.Flat;
        btn13.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn13.Location = new Point(917, 158);
        btn13.Name = "btn13";
        btn13.Size = new Size(80, 80);
        btn13.TabIndex = 32;
        btn13.UseVisualStyleBackColor = false;
        btn13.Click += btnColuna3_Click;
        // 
        // btn12
        // 
        btn12.BackColor = Color.Gainsboro;
        btn12.FlatAppearance.BorderSize = 0;
        btn12.FlatStyle = FlatStyle.Flat;
        btn12.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn12.Location = new Point(831, 158);
        btn12.Name = "btn12";
        btn12.Size = new Size(80, 80);
        btn12.TabIndex = 31;
        btn12.UseVisualStyleBackColor = false;
        btn12.Click += btnColuna2_Click;
        // 
        // btn11
        // 
        btn11.BackColor = Color.Silver;
        btn11.FlatAppearance.BorderSize = 0;
        btn11.FlatStyle = FlatStyle.Flat;
        btn11.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btn11.Location = new Point(745, 158);
        btn11.Name = "btn11";
        btn11.Size = new Size(80, 80);
        btn11.TabIndex = 30;
        btn11.UseVisualStyleBackColor = false;
        btn11.Click += btnColuna1_Click;
        // 
        // btnEnter
        // 
        btnEnter.BackColor = Color.Gainsboro;
        btnEnter.FlatAppearance.BorderColor = Color.Silver;
        btnEnter.FlatAppearance.BorderSize = 0;
        btnEnter.FlatStyle = FlatStyle.Flat;
        btnEnter.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnEnter.Location = new Point(1190, 949);
        btnEnter.Name = "btnEnter";
        btnEnter.Size = new Size(120, 60);
        btnEnter.TabIndex = 87;
        btnEnter.Text = "Enter";
        btnEnter.UseVisualStyleBackColor = false;
        btnEnter.Click += btnEnter_Click;
        // 
        // btnM
        // 
        btnM.BackColor = Color.Gainsboro;
        btnM.FlatAppearance.BorderColor = Color.Silver;
        btnM.FlatAppearance.BorderSize = 0;
        btnM.FlatStyle = FlatStyle.Flat;
        btnM.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnM.Location = new Point(1104, 949);
        btnM.Name = "btnM";
        btnM.Size = new Size(80, 60);
        btnM.TabIndex = 86;
        btnM.Text = "M";
        btnM.UseVisualStyleBackColor = false;
        btnM.Click += btnTeclado_Click;
        // 
        // btnN
        // 
        btnN.BackColor = Color.Gainsboro;
        btnN.FlatAppearance.BorderColor = Color.Silver;
        btnN.FlatAppearance.BorderSize = 0;
        btnN.FlatStyle = FlatStyle.Flat;
        btnN.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnN.Location = new Point(1018, 949);
        btnN.Name = "btnN";
        btnN.Size = new Size(80, 60);
        btnN.TabIndex = 85;
        btnN.Text = "N";
        btnN.UseVisualStyleBackColor = false;
        btnN.Click += btnTeclado_Click;
        // 
        // btnB
        // 
        btnB.BackColor = Color.Gainsboro;
        btnB.FlatAppearance.BorderColor = Color.Silver;
        btnB.FlatAppearance.BorderSize = 0;
        btnB.FlatStyle = FlatStyle.Flat;
        btnB.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnB.Location = new Point(932, 949);
        btnB.Name = "btnB";
        btnB.Size = new Size(80, 60);
        btnB.TabIndex = 84;
        btnB.Text = "B";
        btnB.UseVisualStyleBackColor = false;
        btnB.Click += btnTeclado_Click;
        // 
        // btnV
        // 
        btnV.BackColor = Color.Gainsboro;
        btnV.FlatAppearance.BorderColor = Color.Silver;
        btnV.FlatAppearance.BorderSize = 0;
        btnV.FlatStyle = FlatStyle.Flat;
        btnV.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnV.Location = new Point(846, 949);
        btnV.Name = "btnV";
        btnV.Size = new Size(80, 60);
        btnV.TabIndex = 83;
        btnV.Text = "V";
        btnV.UseVisualStyleBackColor = false;
        btnV.Click += btnTeclado_Click;
        // 
        // btnC
        // 
        btnC.BackColor = Color.Gainsboro;
        btnC.FlatAppearance.BorderColor = Color.Silver;
        btnC.FlatAppearance.BorderSize = 0;
        btnC.FlatStyle = FlatStyle.Flat;
        btnC.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnC.Location = new Point(761, 949);
        btnC.Name = "btnC";
        btnC.Size = new Size(80, 60);
        btnC.TabIndex = 82;
        btnC.Text = "C";
        btnC.UseVisualStyleBackColor = false;
        btnC.Click += btnTeclado_Click;
        // 
        // btnX
        // 
        btnX.BackColor = Color.Gainsboro;
        btnX.FlatAppearance.BorderColor = Color.Silver;
        btnX.FlatAppearance.BorderSize = 0;
        btnX.FlatStyle = FlatStyle.Flat;
        btnX.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnX.Location = new Point(675, 949);
        btnX.Name = "btnX";
        btnX.Size = new Size(80, 60);
        btnX.TabIndex = 81;
        btnX.Text = "X";
        btnX.UseVisualStyleBackColor = false;
        btnX.Click += btnTeclado_Click;
        // 
        // btnZ
        // 
        btnZ.BackColor = Color.Gainsboro;
        btnZ.FlatAppearance.BorderColor = Color.Silver;
        btnZ.FlatAppearance.BorderSize = 0;
        btnZ.FlatStyle = FlatStyle.Flat;
        btnZ.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnZ.Location = new Point(589, 949);
        btnZ.Name = "btnZ";
        btnZ.Size = new Size(80, 60);
        btnZ.TabIndex = 80;
        btnZ.Text = "Z";
        btnZ.UseVisualStyleBackColor = false;
        btnZ.Click += btnTeclado_Click;
        // 
        // backSpace
        // 
        backSpace.BackColor = Color.Gainsboro;
        backSpace.FlatAppearance.BorderColor = Color.Silver;
        backSpace.FlatAppearance.BorderSize = 0;
        backSpace.FlatStyle = FlatStyle.Flat;
        backSpace.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        backSpace.Location = new Point(1307, 883);
        backSpace.Name = "backSpace";
        backSpace.Size = new Size(100, 60);
        backSpace.TabIndex = 79;
        backSpace.Text = "⌫";
        backSpace.UseVisualStyleBackColor = false;
        backSpace.Click += btnBack_Click;
        // 
        // btnL
        // 
        btnL.BackColor = Color.Gainsboro;
        btnL.FlatAppearance.BorderColor = Color.Silver;
        btnL.FlatAppearance.BorderSize = 0;
        btnL.FlatStyle = FlatStyle.Flat;
        btnL.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnL.Location = new Point(1221, 883);
        btnL.Name = "btnL";
        btnL.Size = new Size(80, 60);
        btnL.TabIndex = 78;
        btnL.Text = "L";
        btnL.UseVisualStyleBackColor = false;
        btnL.Click += btnTeclado_Click;
        // 
        // btnK
        // 
        btnK.BackColor = Color.Gainsboro;
        btnK.FlatAppearance.BorderColor = Color.Silver;
        btnK.FlatAppearance.BorderSize = 0;
        btnK.FlatStyle = FlatStyle.Flat;
        btnK.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnK.Location = new Point(1135, 883);
        btnK.Name = "btnK";
        btnK.Size = new Size(80, 60);
        btnK.TabIndex = 77;
        btnK.Text = "K";
        btnK.UseVisualStyleBackColor = false;
        btnK.Click += btnTeclado_Click;
        // 
        // btnJ
        // 
        btnJ.BackColor = Color.Gainsboro;
        btnJ.FlatAppearance.BorderColor = Color.Silver;
        btnJ.FlatAppearance.BorderSize = 0;
        btnJ.FlatStyle = FlatStyle.Flat;
        btnJ.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnJ.Location = new Point(1049, 883);
        btnJ.Name = "btnJ";
        btnJ.Size = new Size(80, 60);
        btnJ.TabIndex = 76;
        btnJ.Text = "J";
        btnJ.UseVisualStyleBackColor = false;
        btnJ.Click += btnTeclado_Click;
        // 
        // btnH
        // 
        btnH.BackColor = Color.Gainsboro;
        btnH.FlatAppearance.BorderColor = Color.Silver;
        btnH.FlatAppearance.BorderSize = 0;
        btnH.FlatStyle = FlatStyle.Flat;
        btnH.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnH.Location = new Point(963, 883);
        btnH.Name = "btnH";
        btnH.Size = new Size(80, 60);
        btnH.TabIndex = 75;
        btnH.Text = "H";
        btnH.UseVisualStyleBackColor = false;
        btnH.Click += btnTeclado_Click;
        // 
        // btnG
        // 
        btnG.BackColor = Color.Gainsboro;
        btnG.FlatAppearance.BorderColor = Color.Silver;
        btnG.FlatAppearance.BorderSize = 0;
        btnG.FlatStyle = FlatStyle.Flat;
        btnG.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnG.Location = new Point(877, 883);
        btnG.Name = "btnG";
        btnG.Size = new Size(80, 60);
        btnG.TabIndex = 74;
        btnG.Text = "G";
        btnG.UseVisualStyleBackColor = false;
        btnG.Click += btnTeclado_Click;
        // 
        // btnF
        // 
        btnF.BackColor = Color.Gainsboro;
        btnF.FlatAppearance.BorderColor = Color.Silver;
        btnF.FlatAppearance.BorderSize = 0;
        btnF.FlatStyle = FlatStyle.Flat;
        btnF.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnF.Location = new Point(791, 883);
        btnF.Name = "btnF";
        btnF.Size = new Size(80, 60);
        btnF.TabIndex = 73;
        btnF.Text = "F";
        btnF.UseVisualStyleBackColor = false;
        btnF.Click += btnTeclado_Click;
        // 
        // btnD
        // 
        btnD.BackColor = Color.Gainsboro;
        btnD.FlatAppearance.BorderColor = Color.Silver;
        btnD.FlatAppearance.BorderSize = 0;
        btnD.FlatStyle = FlatStyle.Flat;
        btnD.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnD.Location = new Point(705, 883);
        btnD.Name = "btnD";
        btnD.Size = new Size(80, 60);
        btnD.TabIndex = 72;
        btnD.Text = "D";
        btnD.UseVisualStyleBackColor = false;
        btnD.Click += btnTeclado_Click;
        // 
        // btnS
        // 
        btnS.BackColor = Color.Gainsboro;
        btnS.FlatAppearance.BorderColor = Color.Silver;
        btnS.FlatAppearance.BorderSize = 0;
        btnS.FlatStyle = FlatStyle.Flat;
        btnS.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnS.Location = new Point(619, 883);
        btnS.Name = "btnS";
        btnS.Size = new Size(80, 60);
        btnS.TabIndex = 71;
        btnS.Text = "S";
        btnS.UseVisualStyleBackColor = false;
        btnS.Click += btnTeclado_Click;
        // 
        // btnA
        // 
        btnA.BackColor = Color.Gainsboro;
        btnA.FlatAppearance.BorderColor = Color.Silver;
        btnA.FlatAppearance.BorderSize = 0;
        btnA.FlatStyle = FlatStyle.Flat;
        btnA.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnA.Location = new Point(533, 883);
        btnA.Name = "btnA";
        btnA.Size = new Size(80, 60);
        btnA.TabIndex = 70;
        btnA.Text = "A";
        btnA.UseVisualStyleBackColor = false;
        btnA.Click += btnTeclado_Click;
        // 
        // btnP
        // 
        btnP.BackColor = Color.Gainsboro;
        btnP.FlatAppearance.BorderColor = Color.Silver;
        btnP.FlatAppearance.BorderSize = 0;
        btnP.FlatStyle = FlatStyle.Flat;
        btnP.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnP.Location = new Point(1282, 817);
        btnP.Name = "btnP";
        btnP.Size = new Size(80, 60);
        btnP.TabIndex = 69;
        btnP.Text = "P";
        btnP.UseVisualStyleBackColor = false;
        btnP.Click += btnTeclado_Click;
        // 
        // btnO
        // 
        btnO.BackColor = Color.Gainsboro;
        btnO.FlatAppearance.BorderColor = Color.Silver;
        btnO.FlatAppearance.BorderSize = 0;
        btnO.FlatStyle = FlatStyle.Flat;
        btnO.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnO.Location = new Point(1196, 817);
        btnO.Name = "btnO";
        btnO.Size = new Size(80, 60);
        btnO.TabIndex = 68;
        btnO.Text = "O";
        btnO.UseVisualStyleBackColor = false;
        btnO.Click += btnTeclado_Click;
        // 
        // btnI
        // 
        btnI.BackColor = Color.Gainsboro;
        btnI.FlatAppearance.BorderColor = Color.Silver;
        btnI.FlatAppearance.BorderSize = 0;
        btnI.FlatStyle = FlatStyle.Flat;
        btnI.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnI.Location = new Point(1110, 817);
        btnI.Name = "btnI";
        btnI.Size = new Size(80, 60);
        btnI.TabIndex = 67;
        btnI.Text = "I";
        btnI.UseVisualStyleBackColor = false;
        btnI.Click += btnTeclado_Click;
        // 
        // btnU
        // 
        btnU.BackColor = Color.Gainsboro;
        btnU.FlatAppearance.BorderColor = Color.Silver;
        btnU.FlatAppearance.BorderSize = 0;
        btnU.FlatStyle = FlatStyle.Flat;
        btnU.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnU.Location = new Point(1024, 817);
        btnU.Name = "btnU";
        btnU.Size = new Size(80, 60);
        btnU.TabIndex = 66;
        btnU.Text = "U";
        btnU.UseVisualStyleBackColor = false;
        btnU.Click += btnTeclado_Click;
        // 
        // btnY
        // 
        btnY.BackColor = Color.Gainsboro;
        btnY.FlatAppearance.BorderColor = Color.Silver;
        btnY.FlatAppearance.BorderSize = 0;
        btnY.FlatStyle = FlatStyle.Flat;
        btnY.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnY.Location = new Point(938, 817);
        btnY.Name = "btnY";
        btnY.Size = new Size(80, 60);
        btnY.TabIndex = 65;
        btnY.Text = "Y";
        btnY.UseVisualStyleBackColor = false;
        btnY.Click += btnTeclado_Click;
        // 
        // btnT
        // 
        btnT.BackColor = Color.Gainsboro;
        btnT.FlatAppearance.BorderColor = Color.Silver;
        btnT.FlatAppearance.BorderSize = 0;
        btnT.FlatStyle = FlatStyle.Flat;
        btnT.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnT.Location = new Point(852, 817);
        btnT.Name = "btnT";
        btnT.Size = new Size(80, 60);
        btnT.TabIndex = 64;
        btnT.Text = "T";
        btnT.UseVisualStyleBackColor = false;
        btnT.Click += btnTeclado_Click;
        // 
        // btnR
        // 
        btnR.BackColor = Color.Gainsboro;
        btnR.FlatAppearance.BorderColor = Color.Silver;
        btnR.FlatAppearance.BorderSize = 0;
        btnR.FlatStyle = FlatStyle.Flat;
        btnR.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnR.Location = new Point(766, 817);
        btnR.Name = "btnR";
        btnR.Size = new Size(80, 60);
        btnR.TabIndex = 63;
        btnR.Text = "R";
        btnR.UseVisualStyleBackColor = false;
        btnR.Click += btnTeclado_Click;
        // 
        // btnE
        // 
        btnE.BackColor = Color.Gainsboro;
        btnE.FlatAppearance.BorderColor = Color.Silver;
        btnE.FlatAppearance.BorderSize = 0;
        btnE.FlatStyle = FlatStyle.Flat;
        btnE.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnE.Location = new Point(680, 817);
        btnE.Name = "btnE";
        btnE.Size = new Size(80, 60);
        btnE.TabIndex = 62;
        btnE.Text = "E";
        btnE.UseVisualStyleBackColor = false;
        btnE.Click += btnTeclado_Click;
        // 
        // btnW
        // 
        btnW.BackColor = Color.Gainsboro;
        btnW.FlatAppearance.BorderColor = Color.Silver;
        btnW.FlatAppearance.BorderSize = 0;
        btnW.FlatStyle = FlatStyle.Flat;
        btnW.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnW.Location = new Point(594, 817);
        btnW.Name = "btnW";
        btnW.Size = new Size(80, 60);
        btnW.TabIndex = 61;
        btnW.Text = "W";
        btnW.UseVisualStyleBackColor = false;
        btnW.Click += btnTeclado_Click;
        // 
        // btnQ
        // 
        btnQ.BackColor = Color.Gainsboro;
        btnQ.FlatAppearance.BorderColor = Color.Silver;
        btnQ.FlatAppearance.BorderSize = 0;
        btnQ.FlatStyle = FlatStyle.Flat;
        btnQ.Font = new Font("MS Reference Sans Serif", 15.75F, FontStyle.Bold);
        btnQ.Location = new Point(508, 817);
        btnQ.Name = "btnQ";
        btnQ.Size = new Size(80, 60);
        btnQ.TabIndex = 60;
        btnQ.Text = "Q";
        btnQ.UseVisualStyleBackColor = false;
        btnQ.Click += btnTeclado_Click;
        // 
        // FormJogo
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1904, 1041);
        Controls.Add(btnEnter);
        Controls.Add(btnM);
        Controls.Add(btnN);
        Controls.Add(btnB);
        Controls.Add(btnV);
        Controls.Add(btnC);
        Controls.Add(btnX);
        Controls.Add(btnZ);
        Controls.Add(backSpace);
        Controls.Add(btnL);
        Controls.Add(btnK);
        Controls.Add(btnJ);
        Controls.Add(btnH);
        Controls.Add(btnG);
        Controls.Add(btnF);
        Controls.Add(btnD);
        Controls.Add(btnS);
        Controls.Add(btnA);
        Controls.Add(btnP);
        Controls.Add(btnO);
        Controls.Add(btnI);
        Controls.Add(btnU);
        Controls.Add(btnY);
        Controls.Add(btnT);
        Controls.Add(btnR);
        Controls.Add(btnE);
        Controls.Add(btnW);
        Controls.Add(btnQ);
        Controls.Add(btn65);
        Controls.Add(btn64);
        Controls.Add(btn63);
        Controls.Add(btn62);
        Controls.Add(btn61);
        Controls.Add(btn55);
        Controls.Add(btn54);
        Controls.Add(btn53);
        Controls.Add(btn52);
        Controls.Add(btn51);
        Controls.Add(btn45);
        Controls.Add(btn44);
        Controls.Add(btn43);
        Controls.Add(btn42);
        Controls.Add(btn41);
        Controls.Add(btn35);
        Controls.Add(btn34);
        Controls.Add(btn33);
        Controls.Add(btn32);
        Controls.Add(btn31);
        Controls.Add(btn25);
        Controls.Add(btn24);
        Controls.Add(btn23);
        Controls.Add(btn22);
        Controls.Add(btn21);
        Controls.Add(btn15);
        Controls.Add(btn14);
        Controls.Add(btn13);
        Controls.Add(btn12);
        Controls.Add(btn11);
        Controls.Add(ModoClaroEscuro);
        Controls.Add(dica);
        Controls.Add(ouvirMusic);
        Controls.Add(musica4);
        Controls.Add(musica3);
        Controls.Add(musica2);
        Controls.Add(musica1);
        Controls.Add(videoView1);
        Controls.Add(negarDica);
        Controls.Add(aceitarDica);
        Controls.Add(labelValt);
        Controls.Add(pictureBox1);
        Controls.Add(label1);
        Controls.Add(btnReiniciar);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        KeyPreview = true;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormJogo";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ValTermo";
        WindowState = FormWindowState.Maximized;
        KeyDown += FormJogo_KeyDown;
        KeyPress += FormJogo_KeyPress;
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button btnReiniciar;
    private Label label1;
    private PictureBox pictureBox1;
    private Label labelValt;
    private Button aceitarDica;
    private Button negarDica;
    private Button ModoClaroEscuro;
    private LibVLCSharp.WinForms.VideoView videoView1;
    private RadioButton musica1;
    private RadioButton musica2;
    private RadioButton musica3;
    private RadioButton musica4;
    private CheckBox ouvirMusic;
    private Button dica;
    private Button btn65;
    private Button btn64;
    private Button btn63;
    private Button btn62;
    private Button btn61;
    private Button btn55;
    private Button btn54;
    private Button btn53;
    private Button btn52;
    private Button btn51;
    private Button btn45;
    private Button btn44;
    private Button btn43;
    private Button btn42;
    private Button btn41;
    private Button btn35;
    private Button btn34;
    private Button btn33;
    private Button btn32;
    private Button btn31;
    private Button btn25;
    private Button btn24;
    private Button btn23;
    private Button btn22;
    private Button btn21;
    private Button btn15;
    private Button btn14;
    private Button btn13;
    private Button btn12;
    private Button btn11;
    private Button btnEnter;
    private Button btnM;
    private Button btnN;
    private Button btnB;
    private Button btnV;
    private Button btnC;
    private Button btnX;
    private Button btnZ;
    private Button backSpace;
    private Button btnL;
    private Button btnK;
    private Button btnJ;
    private Button btnH;
    private Button btnG;
    private Button btnF;
    private Button btnD;
    private Button btnS;
    private Button btnA;
    private Button btnP;
    private Button btnO;
    private Button btnI;
    private Button btnU;
    private Button btnY;
    private Button btnT;
    private Button btnR;
    private Button btnE;
    private Button btnW;
    private Button btnQ;
}
