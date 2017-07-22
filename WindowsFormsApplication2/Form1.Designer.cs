namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackWave = new System.Windows.Forms.TrackBar();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.SongName = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.SearchSong = new System.Windows.Forms.Button();
            this.SearchFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NowPlaying = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.trackWave);
            this.panel1.Controls.Add(this.Pause);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Location = new System.Drawing.Point(88, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 80);
            this.panel1.TabIndex = 0;
            // 
            // trackWave
            // 
            this.trackWave.LargeChange = 1;
            this.trackWave.Location = new System.Drawing.Point(754, 13);
            this.trackWave.Name = "trackWave";
            this.trackWave.Size = new System.Drawing.Size(134, 56);
            this.trackWave.TabIndex = 4;
            this.trackWave.Value = 10;
            this.trackWave.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackWave.ValueChanged += new System.EventHandler(this.trackWave_ValueChanged);
            // 
            // Pause
            // 
            this.Pause.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Pause.Image = global::WindowsFormsApplication2.Properties.Resources.pause;
            this.Pause.Location = new System.Drawing.Point(950, 13);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(50, 50);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pause.TabIndex = 6;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click_1);
            // 
            // Play
            // 
            this.Play.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Play.Image = global::WindowsFormsApplication2.Properties.Resources.playbutton;
            this.Play.Location = new System.Drawing.Point(894, 13);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(50, 50);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Play.TabIndex = 3;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Stop.Image = global::WindowsFormsApplication2.Properties.Resources.Stop;
            this.Stop.Location = new System.Drawing.Point(1006, 13);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(50, 50);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stop.TabIndex = 0;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // SongName
            // 
            this.SongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SongName.AutoSize = true;
            this.SongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SongName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SongName.Location = new System.Drawing.Point(12, 446);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(178, 29);
            this.SongName.TabIndex = 5;
            this.SongName.Text = "Selected Song:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(712, 304);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSearch.Location = new System.Drawing.Point(818, 5);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(235, 32);
            this.LabelSearch.TabIndex = 0;
            this.LabelSearch.Text = "Search For Music";
            this.LabelSearch.Click += new System.EventHandler(this.LabelSearch_Click);
            // 
            // SearchSong
            // 
            this.SearchSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchSong.Location = new System.Drawing.Point(1066, 8);
            this.SearchSong.Name = "SearchSong";
            this.SearchSong.Size = new System.Drawing.Size(92, 32);
            this.SearchSong.TabIndex = 1;
            this.SearchSong.UseVisualStyleBackColor = false;
            this.SearchSong.Click += new System.EventHandler(this.SearchSong_Click);
            // 
            // SearchFolder
            // 
            this.SearchFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchFolder.Location = new System.Drawing.Point(1066, 46);
            this.SearchFolder.Name = "SearchFolder";
            this.SearchFolder.Size = new System.Drawing.Size(92, 32);
            this.SearchFolder.TabIndex = 3;
            this.SearchFolder.UseVisualStyleBackColor = false;
            this.SearchFolder.Click += new System.EventHandler(this.SearchFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(818, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search For Folder";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-1, -15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // NowPlaying
            // 
            this.NowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NowPlaying.AutoSize = true;
            this.NowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlaying.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.NowPlaying.Location = new System.Drawing.Point(12, 495);
            this.NowPlaying.Name = "NowPlaying";
            this.NowPlaying.Size = new System.Drawing.Size(154, 29);
            this.NowPlaying.TabIndex = 6;
            this.NowPlaying.Text = "Now Playing:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.FEZ_04_512;
            this.pictureBox1.Location = new System.Drawing.Point(12, 617);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Location = new System.Drawing.Point(12, 8);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1146, 586);
            this.Settings.TabIndex = 5;
            this.Settings.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1170, 679);
            this.Controls.Add(this.SearchFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NowPlaying);
            this.Controls.Add(this.SearchSong);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Player";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Button SearchSong;
        private System.Windows.Forms.Button SearchFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackWave;
        private System.Windows.Forms.Label NowPlaying;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Settings;
    }
}

