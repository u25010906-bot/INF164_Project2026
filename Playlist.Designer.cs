namespace INF164_Project2026
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.pbxCover = new System.Windows.Forms.PictureBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnChangeCoverArt = new System.Windows.Forms.Button();
            this.ofdCoverArt = new System.Windows.Forms.OpenFileDialog();
            this.btnHome = new System.Windows.Forms.Button();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.lblTrackCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCover
            // 
            this.pbxCover.Image = ((System.Drawing.Image)(resources.GetObject("pbxCover.Image")));
            this.pbxCover.Location = new System.Drawing.Point(20, 11);
            this.pbxCover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxCover.Name = "pbxCover";
            this.pbxCover.Size = new System.Drawing.Size(224, 241);
            this.pbxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCover.TabIndex = 3;
            this.pbxCover.TabStop = false;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPlaylist.Location = new System.Drawing.Point(248, 11);
            this.lblPlaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(272, 43);
            this.lblPlaylist.TabIndex = 4;
            this.lblPlaylist.Text = "Code Blooded Jams";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDate.Location = new System.Drawing.Point(325, 58);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Created: 8 August 2026";
            // 
            // btnChangeCoverArt
            // 
            this.btnChangeCoverArt.Location = new System.Drawing.Point(50, 257);
            this.btnChangeCoverArt.Name = "btnChangeCoverArt";
            this.btnChangeCoverArt.Size = new System.Drawing.Size(159, 23);
            this.btnChangeCoverArt.TabIndex = 6;
            this.btnChangeCoverArt.Text = "Change Playlist Cover Art";
            this.btnChangeCoverArt.UseVisualStyleBackColor = true;
            this.btnChangeCoverArt.Click += new System.EventHandler(this.btnChangeCoverArt_Click);
            // 
            // ofdCoverArt
            // 
            this.ofdCoverArt.FileName = "openFileDialog1";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(347, 256);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 25);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(276, 74);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(232, 134);
            this.lstSongs.TabIndex = 8;
            // 
            // lblTrackCount
            // 
            this.lblTrackCount.AutoSize = true;
            this.lblTrackCount.Location = new System.Drawing.Point(361, 225);
            this.lblTrackCount.Name = "lblTrackCount";
            this.lblTrackCount.Size = new System.Drawing.Size(35, 13);
            this.lblTrackCount.TabIndex = 9;
            this.lblTrackCount.Text = "label1";
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblTrackCount);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnChangeCoverArt);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.pbxCover);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.Playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCover;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnChangeCoverArt;
        private System.Windows.Forms.OpenFileDialog ofdCoverArt;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.Label lblTrackCount;
    }
}