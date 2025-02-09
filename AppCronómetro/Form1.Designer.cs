namespace AppCronómetro
{
    partial class AppCron
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppCron));
            Tcronometro = new System.Windows.Forms.Timer(components);
            btnPlay = new Button();
            btnReiniciar = new Button();
            btnDetener = new Button();
            label4 = new Label();
            Lapso = new ListBox();
            label6 = new Label();
            lbCronometro = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Tcronometro
            // 
            Tcronometro.Tick += Tcronometro_Tick;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Black;
            btnPlay.BackgroundImage = Properties.Resources.play_blue_button_icon_227848;
            btnPlay.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.ForeColor = Color.Transparent;
            btnPlay.Location = new Point(347, 334);
            btnPlay.Margin = new Padding(5);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(65, 59);
            btnPlay.TabIndex = 3;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Black;
            btnReiniciar.BackgroundImage = (Image)resources.GetObject("btnReiniciar.BackgroundImage");
            btnReiniciar.BackgroundImageLayout = ImageLayout.Zoom;
            btnReiniciar.FlatAppearance.BorderColor = Color.Black;
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.ForeColor = Color.Black;
            btnReiniciar.Location = new Point(182, 343);
            btnReiniciar.Margin = new Padding(5);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(53, 50);
            btnReiniciar.TabIndex = 4;
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.Black;
            btnDetener.BackgroundImage = (Image)resources.GetObject("btnDetener.BackgroundImage");
            btnDetener.BackgroundImageLayout = ImageLayout.Zoom;
            btnDetener.FlatAppearance.BorderSize = 0;
            btnDetener.FlatStyle = FlatStyle.Flat;
            btnDetener.ForeColor = Color.Black;
            btnDetener.Location = new Point(518, 342);
            btnDetener.Margin = new Padding(5);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(56, 51);
            btnDetener.TabIndex = 5;
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(535, 147);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 10;
            // 
            // Lapso
            // 
            Lapso.Anchor = AnchorStyles.Top;
            Lapso.BackColor = SystemColors.Desktop;
            Lapso.BorderStyle = BorderStyle.None;
            Lapso.ForeColor = SystemColors.HighlightText;
            Lapso.FormattingEnabled = true;
            Lapso.ItemHeight = 23;
            Lapso.Location = new Point(344, 202);
            Lapso.Name = "Lapso";
            Lapso.Size = new Size(117, 115);
            Lapso.TabIndex = 13;
            Lapso.SelectedIndexChanged += Lapso_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Bauhaus 93", 72F);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(429, 91);
            label6.Name = "label6";
            label6.Size = new Size(0, 108);
            label6.TabIndex = 12;
            label6.Click += label6_Click;
            // 
            // lbCronometro
            // 
            lbCronometro.AutoSize = true;
            lbCronometro.BackColor = Color.Transparent;
            lbCronometro.Font = new Font("Bauhaus 93", 72F);
            lbCronometro.ForeColor = SystemColors.HighlightText;
            lbCronometro.Location = new Point(111, 80);
            lbCronometro.Name = "lbCronometro";
            lbCronometro.Size = new Size(538, 108);
            lbCronometro.TabIndex = 7;
            lbCronometro.Text = "00:00:00.0";
            lbCronometro.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.merobuenos_com_56756;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(351, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 46);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AppCron
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(727, 432);
            Controls.Add(pictureBox1);
            Controls.Add(Lapso);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(lbCronometro);
            Controls.Add(btnDetener);
            Controls.Add(btnReiniciar);
            Controls.Add(btnPlay);
            Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.HighlightText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "AppCron";
            Text = "Cronómetro";
            Load += AppCron_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Tcronometro;
        private Button btnPlay;
        private Button btnReiniciar;
        private Button btnDetener;
        private Label label4;
        private ListBox Lapso;
        private Label label6;
        private Label lbCronometro;
        private PictureBox pictureBox1;
    }
}
