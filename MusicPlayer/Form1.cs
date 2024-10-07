using System.Media;
using TagLib;


namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        string musica = "";
        private SoundPlayer soundPlayer;
        bool musicaTocando = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string musica = "";
            soundPlayer = new SoundPlayer();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selecionarMusica_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Áudio (*.WAV)|*.wav";
                ofd.Title = "Selecione uma musica";
                ofd.RestoreDirectory = true;

                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        musica = ofd.FileName;
                        var msc = TagLib.File.Create(ofd.FileName);
                        if (msc.Tag.Pictures.Length >= 1)
                        {
                            var imagemMsc = msc.Tag.Pictures[0];
                            using (var memStream = new System.IO.MemoryStream(imagemMsc.Data.Data))
                            {
                                Image originalImage = Image.FromStream(memStream);


                                imagemMusica.Image = ResizeImage(originalImage, 565, 522);
                            }
                        }
                        if (msc.Tag.Title.Length >= 1)
                        {
                            musicTitle.Text = msc.Tag.Title;
                        }
                        else
                        {
                            musicTitle.Text = Path.GetFileName(ofd.FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }


            }
        }

        private Image? ResizeImage(Image image, int width, int height)
        {
            // Calcula novas dimensões preservando a proporção
            int newWidth, newHeight;
            if (image.Width > image.Height)
            {
                newWidth = width;
                newHeight = (int)((float)image.Height / image.Width * width);
            }
            else
            {
                newHeight = height;
                newWidth = (int)((float)image.Width / image.Height * height);
            }

            // Redimensiona imagem
            Image resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!musicaTocando)
            {
                try
                {
                    soundPlayer.Stream = new FileStream(musica, FileMode.Open);
                    soundPlayer.Play();
                    musicaTocando = !musicaTocando;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao reproduzir o arquivo de áudio: {ex.Message}");
                }
            }
            else {
                soundPlayer.Stop();
                musicaTocando = !musicaTocando;

            }
        }
    }
}
