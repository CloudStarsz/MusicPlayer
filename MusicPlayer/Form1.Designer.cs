namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            selecionarMusica = new Button();
            label3 = new Label();
            playButton = new Label();
            label2 = new Label();
            label1 = new Label();
            musicTitle = new Label();
            closeButton = new Button();
            imagemMusica = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Gray;
            splitContainer1.Panel1.Controls.Add(selecionarMusica);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(playButton);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(musicTitle);
            splitContainer1.Panel2.Controls.Add(closeButton);
            splitContainer1.Panel2.Controls.Add(imagemMusica);
            splitContainer1.Panel2.Margin = new Padding(1, 0, 0, 0);
            splitContainer1.Size = new Size(870, 522);
            splitContainer1.SplitterDistance = 298;
            splitContainer1.TabIndex = 0;
            // 
            // selecionarMusica
            // 
            selecionarMusica.Location = new Point(12, 12);
            selecionarMusica.Name = "selecionarMusica";
            selecionarMusica.Size = new Size(274, 23);
            selecionarMusica.TabIndex = 0;
            selecionarMusica.Text = "Selecionar musica";
            selecionarMusica.UseVisualStyleBackColor = true;
            selecionarMusica.Click += selecionarMusica_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(156, 379);
            label3.Name = "label3";
            label3.Size = new Size(80, 80);
            label3.TabIndex = 6;
            // 
            // playButton
            // 
            playButton.BackColor = Color.Transparent;
            playButton.Image = (Image)resources.GetObject("playButton.Image");
            playButton.Location = new Point(242, 379);
            playButton.Name = "playButton";
            playButton.Size = new Size(80, 80);
            playButton.TabIndex = 4;
            playButton.Click += playButton_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(328, 379);
            label2.Name = "label2";
            label2.Size = new Size(80, 80);
            label2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(74, 50);
            label1.MaximumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 0);
            label1.TabIndex = 2;
            label1.Text = "\r\n123";
            // 
            // musicTitle
            // 
            musicTitle.Anchor = AnchorStyles.None;
            musicTitle.AutoSize = true;
            musicTitle.BackColor = Color.Transparent;
            musicTitle.FlatStyle = FlatStyle.Flat;
            musicTitle.Font = new Font("Times New Roman", 20F);
            musicTitle.Location = new Point(151, 339);
            musicTitle.Name = "musicTitle";
            musicTitle.Size = new Size(0, 31);
            musicTitle.TabIndex = 1;
            musicTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(481, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Fechar";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // imagemMusica
            // 
            imagemMusica.BackColor = Color.Silver;
            imagemMusica.BorderStyle = BorderStyle.FixedSingle;
            imagemMusica.FlatStyle = FlatStyle.Popup;
            imagemMusica.Location = new Point(3, 0);
            imagemMusica.Name = "imagemMusica";
            imagemMusica.Size = new Size(565, 522);
            imagemMusica.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(870, 522);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Tocador de musicas";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button closeButton;
        private Button selecionarMusica;
        private Label musicTitle;
        private Label label1;
        private Label imagemMusica;
        private Label playButton;
        private Label label3;
        private Label label2;
    }
}
