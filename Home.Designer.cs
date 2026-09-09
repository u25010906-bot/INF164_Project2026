namespace INF164_Project2026
{
    partial class Home
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
            System.Windows.Forms.Label lblFavouriteGenreTitle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpPlaylist = new System.Windows.Forms.GroupBox();
            this.lblNewPlaylist = new System.Windows.Forms.Label();
            this.txtNewPlaylist = new System.Windows.Forms.TextBox();
            this.btnOpenPlaylist = new System.Windows.Forms.Button();
            this.btnNewPlayList = new System.Windows.Forms.Button();
            this.btnBrowsePlaylist = new System.Windows.Forms.Button();
            this.lstPlaylists = new System.Windows.Forms.ListBox();
            this.grpUploadSong = new System.Windows.Forms.GroupBox();
            this.lblSelectPlaylist = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.btnChooseSong = new System.Windows.Forms.Button();
            this.btnUploadSong = new System.Windows.Forms.Button();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.clbPlaylists = new System.Windows.Forms.CheckedListBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlStats1 = new System.Windows.Forms.Panel();
            this.lblTotalPlaylistsTitle = new System.Windows.Forms.Label();
            this.lblTotalPlaylists = new System.Windows.Forms.Label();
            this.lblTotalSongs = new System.Windows.Forms.Label();
            this.lblTotalSongsTitle = new System.Windows.Forms.Label();
            this.lblFavouriteGenre = new System.Windows.Forms.Label();
            this.pnlStats2 = new System.Windows.Forms.Panel();
            this.pnlStats3 = new System.Windows.Forms.Panel();
            this.ofdSong = new System.Windows.Forms.OpenFileDialog();
            this.ofdPlaylist = new System.Windows.Forms.OpenFileDialog();
            this.sfdPlaylist = new System.Windows.Forms.SaveFileDialog();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            lblFavouriteGenreTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.grpPlaylist.SuspendLayout();
            this.grpUploadSong.SuspendLayout();
            this.pnlStats1.SuspendLayout();
            this.pnlStats2.SuspendLayout();
            this.pnlStats3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFavouriteGenreTitle
            // 
            lblFavouriteGenreTitle.AutoSize = true;
            lblFavouriteGenreTitle.Location = new System.Drawing.Point(20, 13);
            lblFavouriteGenreTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblFavouriteGenreTitle.Name = "lblFavouriteGenreTitle";
            lblFavouriteGenreTitle.Size = new System.Drawing.Size(106, 13);
            lblFavouriteGenreTitle.TabIndex = 15;
            lblFavouriteGenreTitle.Text = "Favourite Genre Title";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(34, 2);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(187, 32);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Back!";
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(707, 20);
            this.picUser.Margin = new System.Windows.Forms.Padding(2);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(40, 41);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlMenu.Controls.Add(this.ProfilePicture);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Controls.Add(this.btnPlaylist);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Location = new System.Drawing.Point(1, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(94, 461);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(15, 67);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 25);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Location = new System.Drawing.Point(15, 115);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(64, 25);
            this.btnPlaylist.TabIndex = 3;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(15, 167);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 25);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // grpPlaylist
            // 
            this.grpPlaylist.Controls.Add(this.lblNewPlaylist);
            this.grpPlaylist.Controls.Add(this.txtNewPlaylist);
            this.grpPlaylist.Controls.Add(this.btnOpenPlaylist);
            this.grpPlaylist.Controls.Add(this.btnNewPlayList);
            this.grpPlaylist.Controls.Add(this.btnBrowsePlaylist);
            this.grpPlaylist.Controls.Add(this.lstPlaylists);
            this.grpPlaylist.Location = new System.Drawing.Point(100, 91);
            this.grpPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.grpPlaylist.Name = "grpPlaylist";
            this.grpPlaylist.Padding = new System.Windows.Forms.Padding(2);
            this.grpPlaylist.Size = new System.Drawing.Size(386, 248);
            this.grpPlaylist.TabIndex = 5;
            this.grpPlaylist.TabStop = false;
            this.grpPlaylist.Text = "My Playlists";
            // 
            // lblNewPlaylist
            // 
            this.lblNewPlaylist.AutoSize = true;
            this.lblNewPlaylist.Location = new System.Drawing.Point(4, 173);
            this.lblNewPlaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPlaylist.Name = "lblNewPlaylist";
            this.lblNewPlaylist.Size = new System.Drawing.Size(73, 13);
            this.lblNewPlaylist.TabIndex = 10;
            this.lblNewPlaylist.Text = "Playlist Name:";
            // 
            // txtNewPlaylist
            // 
            this.txtNewPlaylist.Location = new System.Drawing.Point(87, 173);
            this.txtNewPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewPlaylist.Name = "txtNewPlaylist";
            this.txtNewPlaylist.Size = new System.Drawing.Size(199, 20);
            this.txtNewPlaylist.TabIndex = 9;
            // 
            // btnOpenPlaylist
            // 
            this.btnOpenPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnOpenPlaylist.Location = new System.Drawing.Point(260, 204);
            this.btnOpenPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenPlaylist.Name = "btnOpenPlaylist";
            this.btnOpenPlaylist.Size = new System.Drawing.Size(122, 25);
            this.btnOpenPlaylist.TabIndex = 7;
            this.btnOpenPlaylist.Text = "Open Playlist";
            this.btnOpenPlaylist.UseVisualStyleBackColor = false;
            this.btnOpenPlaylist.Click += new System.EventHandler(this.btnOpenPlaylist_Click);
            // 
            // btnNewPlayList
            // 
            this.btnNewPlayList.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlayList.ForeColor = System.Drawing.Color.White;
            this.btnNewPlayList.Location = new System.Drawing.Point(123, 204);
            this.btnNewPlayList.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewPlayList.Name = "btnNewPlayList";
            this.btnNewPlayList.Size = new System.Drawing.Size(122, 25);
            this.btnNewPlayList.TabIndex = 6;
            this.btnNewPlayList.Text = "+ New Playlist";
            this.btnNewPlayList.UseVisualStyleBackColor = false;
            this.btnNewPlayList.Click += new System.EventHandler(this.btnNewPlayList_Click);
            // 
            // btnBrowsePlaylist
            // 
            this.btnBrowsePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowsePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowsePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePlaylist.Location = new System.Drawing.Point(4, 204);
            this.btnBrowsePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowsePlaylist.Name = "btnBrowsePlaylist";
            this.btnBrowsePlaylist.Size = new System.Drawing.Size(114, 25);
            this.btnBrowsePlaylist.TabIndex = 8;
            this.btnBrowsePlaylist.Text = "Browse Playlist";
            this.btnBrowsePlaylist.UseVisualStyleBackColor = false;
            this.btnBrowsePlaylist.Click += new System.EventHandler(this.btnBrowsePlaylist_Click);
            // 
            // lstPlaylists
            // 
            this.lstPlaylists.FormattingEnabled = true;
            this.lstPlaylists.Location = new System.Drawing.Point(58, 17);
            this.lstPlaylists.Margin = new System.Windows.Forms.Padding(2);
            this.lstPlaylists.Name = "lstPlaylists";
            this.lstPlaylists.Size = new System.Drawing.Size(278, 147);
            this.lstPlaylists.TabIndex = 0;
            // 
            // grpUploadSong
            // 
            this.grpUploadSong.Controls.Add(this.lblSelectPlaylist);
            this.grpUploadSong.Controls.Add(this.txtGenre);
            this.grpUploadSong.Controls.Add(this.txtAlbum);
            this.grpUploadSong.Controls.Add(this.btnChooseSong);
            this.grpUploadSong.Controls.Add(this.btnUploadSong);
            this.grpUploadSong.Controls.Add(this.txtArtist);
            this.grpUploadSong.Controls.Add(this.txtSongName);
            this.grpUploadSong.Controls.Add(this.lblGenre);
            this.grpUploadSong.Controls.Add(this.clbPlaylists);
            this.grpUploadSong.Controls.Add(this.lblAlbum);
            this.grpUploadSong.Controls.Add(this.lblArtist);
            this.grpUploadSong.Controls.Add(this.lblName);
            this.grpUploadSong.Location = new System.Drawing.Point(510, 91);
            this.grpUploadSong.Margin = new System.Windows.Forms.Padding(2);
            this.grpUploadSong.Name = "grpUploadSong";
            this.grpUploadSong.Padding = new System.Windows.Forms.Padding(2);
            this.grpUploadSong.Size = new System.Drawing.Size(355, 229);
            this.grpUploadSong.TabIndex = 9;
            this.grpUploadSong.TabStop = false;
            this.grpUploadSong.Text = "Upload Playlist";
            // 
            // lblSelectPlaylist
            // 
            this.lblSelectPlaylist.AutoSize = true;
            this.lblSelectPlaylist.Location = new System.Drawing.Point(206, 24);
            this.lblSelectPlaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectPlaylist.Name = "lblSelectPlaylist";
            this.lblSelectPlaylist.Size = new System.Drawing.Size(78, 13);
            this.lblSelectPlaylist.TabIndex = 9;
            this.lblSelectPlaylist.Text = "Select Playlist :";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(18, 154);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(76, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(18, 118);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(76, 20);
            this.txtAlbum.TabIndex = 6;
            // 
            // btnChooseSong
            // 
            this.btnChooseSong.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseSong.ForeColor = System.Drawing.Color.White;
            this.btnChooseSong.Location = new System.Drawing.Point(40, 191);
            this.btnChooseSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseSong.Name = "btnChooseSong";
            this.btnChooseSong.Size = new System.Drawing.Size(116, 25);
            this.btnChooseSong.TabIndex = 10;
            this.btnChooseSong.Text = "Browse Music File";
            this.btnChooseSong.UseVisualStyleBackColor = false;
            this.btnChooseSong.Click += new System.EventHandler(this.btnChooseSong_Click);
            // 
            // btnUploadSong
            // 
            this.btnUploadSong.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadSong.ForeColor = System.Drawing.Color.White;
            this.btnUploadSong.Location = new System.Drawing.Point(208, 191);
            this.btnUploadSong.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadSong.Name = "btnUploadSong";
            this.btnUploadSong.Size = new System.Drawing.Size(116, 25);
            this.btnUploadSong.TabIndex = 11;
            this.btnUploadSong.Text = "Upload Song";
            this.btnUploadSong.UseVisualStyleBackColor = false;
            this.btnUploadSong.Click += new System.EventHandler(this.btnUploadSong_Click);
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(18, 80);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(76, 20);
            this.txtArtist.TabIndex = 5;
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(18, 43);
            this.txtSongName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(76, 20);
            this.txtSongName.TabIndex = 4;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(16, 138);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 13);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre :";
            // 
            // clbPlaylists
            // 
            this.clbPlaylists.FormattingEnabled = true;
            this.clbPlaylists.Location = new System.Drawing.Point(190, 43);
            this.clbPlaylists.Margin = new System.Windows.Forms.Padding(2);
            this.clbPlaylists.Name = "clbPlaylists";
            this.clbPlaylists.Size = new System.Drawing.Size(149, 124);
            this.clbPlaylists.TabIndex = 8;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(16, 101);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(42, 13);
            this.lblAlbum.TabIndex = 2;
            this.lblAlbum.Text = "Album :";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(16, 63);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(36, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 24);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Song Name :";
            // 
            // pnlStats1
            // 
            this.pnlStats1.Controls.Add(this.lblTotalPlaylistsTitle);
            this.pnlStats1.Controls.Add(this.lblTotalPlaylists);
            this.pnlStats1.Location = new System.Drawing.Point(510, 379);
            this.pnlStats1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStats1.Name = "pnlStats1";
            this.pnlStats1.Size = new System.Drawing.Size(150, 81);
            this.pnlStats1.TabIndex = 12;
            // 
            // lblTotalPlaylistsTitle
            // 
            this.lblTotalPlaylistsTitle.AutoSize = true;
            this.lblTotalPlaylistsTitle.Location = new System.Drawing.Point(14, 13);
            this.lblTotalPlaylistsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPlaylistsTitle.Name = "lblTotalPlaylistsTitle";
            this.lblTotalPlaylistsTitle.Size = new System.Drawing.Size(94, 13);
            this.lblTotalPlaylistsTitle.TabIndex = 1;
            this.lblTotalPlaylistsTitle.Text = "Total Playlists Title";
            // 
            // lblTotalPlaylists
            // 
            this.lblTotalPlaylists.AutoSize = true;
            this.lblTotalPlaylists.Location = new System.Drawing.Point(23, 42);
            this.lblTotalPlaylists.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPlaylists.Name = "lblTotalPlaylists";
            this.lblTotalPlaylists.Size = new System.Drawing.Size(71, 13);
            this.lblTotalPlaylists.TabIndex = 0;
            this.lblTotalPlaylists.Text = "Total Playlists";
            // 
            // lblTotalSongs
            // 
            this.lblTotalSongs.AutoSize = true;
            this.lblTotalSongs.Location = new System.Drawing.Point(28, 44);
            this.lblTotalSongs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSongs.Name = "lblTotalSongs";
            this.lblTotalSongs.Size = new System.Drawing.Size(64, 13);
            this.lblTotalSongs.TabIndex = 13;
            this.lblTotalSongs.Text = "Total Songs";
            // 
            // lblTotalSongsTitle
            // 
            this.lblTotalSongsTitle.AutoSize = true;
            this.lblTotalSongsTitle.Location = new System.Drawing.Point(28, 13);
            this.lblTotalSongsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSongsTitle.Name = "lblTotalSongsTitle";
            this.lblTotalSongsTitle.Size = new System.Drawing.Size(87, 13);
            this.lblTotalSongsTitle.TabIndex = 14;
            this.lblTotalSongsTitle.Text = "Total Songs Title";
            // 
            // lblFavouriteGenre
            // 
            this.lblFavouriteGenre.AutoSize = true;
            this.lblFavouriteGenre.Location = new System.Drawing.Point(20, 42);
            this.lblFavouriteGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFavouriteGenre.Name = "lblFavouriteGenre";
            this.lblFavouriteGenre.Size = new System.Drawing.Size(83, 13);
            this.lblFavouriteGenre.TabIndex = 16;
            this.lblFavouriteGenre.Text = "Favourite Genre";
            // 
            // pnlStats2
            // 
            this.pnlStats2.Controls.Add(this.lblTotalSongs);
            this.pnlStats2.Controls.Add(this.lblTotalSongsTitle);
            this.pnlStats2.Location = new System.Drawing.Point(128, 378);
            this.pnlStats2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStats2.Name = "pnlStats2";
            this.pnlStats2.Size = new System.Drawing.Size(150, 81);
            this.pnlStats2.TabIndex = 17;
            // 
            // pnlStats3
            // 
            this.pnlStats3.Controls.Add(lblFavouriteGenreTitle);
            this.pnlStats3.Controls.Add(this.lblFavouriteGenre);
            this.pnlStats3.Location = new System.Drawing.Point(316, 378);
            this.pnlStats3.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStats3.Name = "pnlStats3";
            this.pnlStats3.Size = new System.Drawing.Size(150, 81);
            this.pnlStats3.TabIndex = 18;
            // 
            // ofdSong
            // 
            this.ofdSong.FileName = "openFileDialogSong";
            // 
            // ofdPlaylist
            // 
            this.ofdPlaylist.FileName = "openFileDialogPlaylist";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 63);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(110, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Friday, 7 August 2026";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage your music, playlists and favourite tracks in one place.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.picUser);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Location = new System.Drawing.Point(100, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 81);
            this.panel1.TabIndex = 19;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.Location = new System.Drawing.Point(11, 7);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(68, 55);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProfilePicture.TabIndex = 5;
            this.ProfilePicture.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlStats3);
            this.Controls.Add(this.pnlStats2);
            this.Controls.Add(this.pnlStats1);
            this.Controls.Add(this.grpUploadSong);
            this.Controls.Add(this.grpPlaylist);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.grpPlaylist.ResumeLayout(false);
            this.grpPlaylist.PerformLayout();
            this.grpUploadSong.ResumeLayout(false);
            this.grpUploadSong.PerformLayout();
            this.pnlStats1.ResumeLayout(false);
            this.pnlStats1.PerformLayout();
            this.pnlStats2.ResumeLayout(false);
            this.pnlStats2.PerformLayout();
            this.pnlStats3.ResumeLayout(false);
            this.pnlStats3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpPlaylist;
        private System.Windows.Forms.ListBox lstPlaylists;
        private System.Windows.Forms.Button btnNewPlayList;
        private System.Windows.Forms.Button btnOpenPlaylist;
        private System.Windows.Forms.Button btnBrowsePlaylist;
        private System.Windows.Forms.GroupBox grpUploadSong;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckedListBox clbPlaylists;
        private System.Windows.Forms.Button btnChooseSong;
        private System.Windows.Forms.Button btnUploadSong;
        private System.Windows.Forms.Panel pnlStats1;
        private System.Windows.Forms.Label lblTotalPlaylistsTitle;
        private System.Windows.Forms.Label lblTotalPlaylists;
        private System.Windows.Forms.Label lblTotalSongs;
        private System.Windows.Forms.Label lblTotalSongsTitle;
        private System.Windows.Forms.Label lblFavouriteGenre;
        private System.Windows.Forms.Panel pnlStats2;
        private System.Windows.Forms.Panel pnlStats3;
        private System.Windows.Forms.OpenFileDialog ofdSong;
        private System.Windows.Forms.OpenFileDialog ofdPlaylist;
        private System.Windows.Forms.SaveFileDialog sfdPlaylist;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSelectPlaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewPlaylist;
        private System.Windows.Forms.Label lblNewPlaylist;
        private System.Windows.Forms.PictureBox ProfilePicture;
    }
}