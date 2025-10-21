using LibVLCSharp.Shared;

namespace TermoApp
{
    public partial class FormDerrota : Form
    {
        public LibVLC _libVLC;
        public MediaPlayer _mediaPlayer;
        public FormDerrota()
        {
            InitializeComponent();
            Core.Initialize();

            _libVLC = new LibVLC();

            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mediaPlayer;
            playVideo(@"C:\Users\Nicolas Cerqueira\Documents\IFSP 6° semestre 2-2025\Programação orientada a eventos\JogoTermo\JogoTermo\TermoApp\Resources\valtemirDerrota.mp4");
        }

        private void playVideo(string caminhoVideo)
        {
            using (var media = new Media(_libVLC, new Uri(caminhoVideo)))
            {
                _mediaPlayer.Play(media);
            }
        }
    }
}