using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace INF164_Project2026
{
    public partial class Playlist : Form
    {
        public string PlaylistName { get; set; }
        public string PlaylistDate { get; set; }
        private List<string> songs = new List<string>();

        public Playlist()
        {
            InitializeComponent();
        }

        public Playlist(string playlistName, string playlistDate)
        {
            InitializeComponent();
            PlaylistName = playlistName;
            PlaylistDate = playlistDate;
            LoadSongs();
        }
        
         // Create bindinglist for the songs 
         BindingList <Song> SongList = new BindingList <Song>();

         // to show a form, a new instance of that form must be created
         frmAddSong myForm = new frmAddSong();

        private void Playlist_Load(object sender, EventArgs e)
        {
            lblPlaylist.BackColor = Color.Transparent;
            lblDate.BackColor = Color.Transparent;

            lblPlaylist.Text = PlaylistName ?? "Code Blooded Jams";
            lblDate.Text = PlaylistDate ?? DateTime.Now.ToString("dd MMMM yyyy");

           // SetRandomCoverColor();
            SetRandomCoverArt();
            UpdateTrackCount();
        }

        private void LoadSongs()
        {
            try
            {
                string fileName = PlaylistName + ".txt";
                songs.Clear();

                if (File.Exists(fileName))
                {
                    string[] lines = File.ReadAllLines(fileName);

                    // Clear the list box
                    lstSongs.Items.Clear();

                    // Read each line and find song names
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("Song Name:"))
                        {
                            string songName = line.Replace("Song Name:", "").Trim();
                            songs.Add(songName);
                            lstSongs.Items.Add(songName);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Playlist file not found: " + fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading songs: " + ex.Message);
            }
        }

        private void UpdateTrackCount()
        {
            // Make sure you have a Label called lblTrackCount on your form
            if (lblTrackCount != null)
            {
                lblTrackCount.Text = "Tracks: " + songs.Count;
            }
        }

        private void btnChangeCoverArt_Click(object sender, EventArgs e)
        {
            try
            {
                ofdCoverArt.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofdCoverArt.ShowDialog() == DialogResult.OK)
                {
                    pbxCover.Image = Image.FromFile(ofdCoverArt.FileName);
                    pbxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                Home homeForm = new Home();
                homeForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Home: " + ex.Message);
            }
        }
        private void SetRandomCoverColor()
        {
            Random random = new Random();

            // Generate random RGB values
            int r = random.Next(100, 255);
            int g = random.Next(100, 255);
            int b = random.Next(100, 255);

            // Create a solid color image
            Bitmap bitmap = new Bitmap(pbxCover.Width, pbxCover.Height);
            using (Graphics gfx = Graphics.FromImage(bitmap))
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(r, g, b)))
                {
                    gfx.FillRectangle(brush, 0, 0, bitmap.Width, bitmap.Height);
                }
            }
            pbxCover.Image = bitmap;
            pbxCover.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SetRandomCoverArt()
        {
            try
            {
                // Get the correct path - go up from bin\Debug to the project folder
                string coverFolder = Path.Combine(Application.StartupPath, "..", "..", "CoverArt");
                coverFolder = Path.GetFullPath(coverFolder); // This cleans up the path

                // If the above doesn't work, try this alternative path
                if (!Directory.Exists(coverFolder))
                {
                    // Try the current directory
                    coverFolder = Path.Combine(Directory.GetCurrentDirectory(), "CoverArt");
                }

                if (!Directory.Exists(coverFolder))
                {
                    // Try the executable location
                    coverFolder = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "CoverArt");
                }

                // If none of those work, show a message and use random color
                if (!Directory.Exists(coverFolder))
                {
                    MessageBox.Show("CoverArt folder not found at: " + coverFolder + "\nUsing random color instead.");
                    SetRandomCoverColor();
                    return;
                }

                // Get all image files
                string[] imageFiles = Directory.GetFiles(coverFolder, "*.jpg");
                string[] pngFiles = Directory.GetFiles(coverFolder, "*.png");
                string[] bmpFiles = Directory.GetFiles(coverFolder, "*.bmp");
                string[] jpegFiles = Directory.GetFiles(coverFolder, "*.jpeg");

                // Combine all image files
                List<string> allImages = new List<string>();
                allImages.AddRange(imageFiles);
                allImages.AddRange(pngFiles);
                allImages.AddRange(bmpFiles);
                allImages.AddRange(jpegFiles);

                if (allImages.Count > 0)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(0, allImages.Count);
                    string randomImage = allImages[randomIndex];

                    pbxCover.Image = Image.FromFile(randomImage);
                    pbxCover.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("No images found in CoverArt folder.\nUsing random color instead.");
                    SetRandomCoverColor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cover art: " + ex.Message);
                SetRandomCoverColor();
            }
        }
           private void btnAdd_Click(object sender, EventArgs e)
           {       
                myForm.ShowDialog();

               //transfer data from addsong form to main form.
                SongList.Add(myForm.NewSong);
             }

            private void btnDelete_Click(object sender, EventArgs e)
           {
              int iSelectedIndex = dgvSongs.CurrentCell.RowIndex;
              SongList.RemoveAt(iSelectedIndex);
           }
    }
}
