using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace INF164_Project2026
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        //Here we are personalising the welcome message by accessing the username that has been entered on the log in 
        // we are making use of a constructor here to fetch this variable userName

        private string userName; // declaring the local variable for the username we are fetching from form 1 
        public Home(string userName) // Declaring our constructor which has the same name as the class name, Home
        {
            InitializeComponent();    // this line s necessary as it is the first line required by C# when declaring a constructor
            this.userName = userName; /* this line of code helps us save the values passed into the constructor, in this case 
                                      we passed in a string value called userName so now we need to save it in the Home form
                                      in a way, we are localising it*/
        }

        //Here we have linked the log in button with the home page so now we are just customizing the welcome message, linking 
        // it to each user that has successfully logged into their account
        private void Home_Load(object sender, EventArgs e)
        {
           
            lblWelcome.Text = "Welcome to your playlist," + userName; /*Now I make use of the variable userName that we 
                                                                              localised earlier from the constructor
                                                                             //Also take note that we are doing this on the Home form, 
                                                                              that's where the label to customise the name is*/

            // Now we are calling the methods to load the date, playlist, statistics and playlist checklist when the form loads
            LoadDate();
            LoadPlaylist();
            LoadStatistics();
            LoadPlaylistCheckList();
        }


        // This method is responsible for loading the current date and time into the lblDate label on the form.
        private void LoadDate()
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        // This method is responsible for loading the playlists from the "Playlists.txt" file into the lstPlaylists ListBox.
        private void LoadPlaylist()
        {
            lstPlaylists.Items.Clear();
            try
            {
                // Check if the "Playlists.txt" file exists before attempting to read from it
                if (System.IO.File.Exists("Playlists.txt"))
                {
                    // Use a StreamReader to read the contents of the file line by line
                    System.IO.StreamReader reader = new System.IO.StreamReader("Playlists.txt");

                    // Read each line from the file and add it to the lstPlaylists ListBox
                    while (!reader.EndOfStream)
                    {
                        // Add each playlist name to the ListBox
                        lstPlaylists.Items.Add(reader.ReadLine());
                    }
                    // Close the StreamReader after reading the file
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // If an error occurs while loading the playlists, display an error message to the user
                MessageBox.Show("Error loading playlists: " + ex.Message);
            }
        }

        // This method is responsible for loading the playlists into the clbPlaylists CheckedListBox.
        //This allows users to select multiple playlists from the list.
        private void LoadPlaylistCheckList()
        {
            // Clear the existing items in the clbPlaylists CheckedListBox before loading new items
            clbPlaylists.Items.Clear();

            //use a for loop to iterate through the items in the lstPlaylists ListBox and add them to the clbPlaylists CheckedListBox
            for (int i = 0; i < lstPlaylists.Items.Count; i++)
            {
                // Add each playlist from the lstPlaylists ListBox to the clbPlaylists CheckedListBox
                clbPlaylists.Items.Add(lstPlaylists.Items[i]);
            }
        }

        // This method is responsible for loading statistics related to playlists and songs.
        private void LoadStatistics()
        {
            try
            {
                // Count the total number of playlists
                lblTotalPlaylists.Text = lstPlaylists.Items.Count.ToString();

                // Start the song count at zero
                int totalSongs = 0;

                // Go through every playlist in the ListBox
                for (int i = 0; i < lstPlaylists.Items.Count; i++)
                {
                    // Get the playlist name
                    string playlistName = lstPlaylists.Items[i].ToString();

                    // Create the playlist file name
                    string playlistFileName = playlistName + ".txt";

                    // Check if the playlist file exists
                    if (File.Exists(playlistFileName))
                    {
                        // Read all the lines in the playlist file
                        string[] lines = File.ReadAllLines(playlistFileName);

                        // Go through each line
                        for (int j = 0; j < lines.Length; j++)
                        {
                            // Every Song Name line represents one song
                            if (lines[j].StartsWith("Song Name:"))
                            {
                                totalSongs++;
                            }
                        }
                    }
                }

                // Display the total number of songs
                lblTotalSongs.Text = totalSongs.ToString();

                // Display the favourite genre
                lblFavouriteGenre.Text = "N/A";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        private void btnNewPlayList_Click(object sender, EventArgs e)
        {
            //Get the new playlist name from the text box
            string newPlaylistName = txtNewPlaylist.Text;

            //Check if the user entered a name
            if (string.IsNullOrEmpty(newPlaylistName))
            {
                MessageBox.Show("Playlist name cannot be empty.");
                return;
            }

            // call the method to add the new playlist
            CreatePlaylist(newPlaylistName);
        }
        private void CreatePlaylist(string playlistName)
        {
            try
            {
                // Check if the playlist file already exists
                if (System.IO.File.Exists("Playlists.txt"))
                {
                    // Read all existing playlists from the file
                    string[] playlists = System.IO.File.ReadAllLines("Playlists.txt");

                    for (int i = 0; i < playlists.Length; i++)
                    {
                        if (playlists[i].ToLower() == playlistName.ToLower())
                        {
                            MessageBox.Show("This playlist already exists.");
                            return;
                        }
                    }
                }

                // Save the new playlist
                System.IO.StreamWriter writer = new System.IO.StreamWriter("Playlists.txt", true);

                writer.WriteLine(playlistName);

                writer.Close();

                MessageBox.Show("Playlist created successfully!");

                // Refresh everything
                LoadPlaylist();
                LoadPlaylistCheckList();
                LoadStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating playlist:\n" + ex.Message);
            }
        }

        private void btnOpenPlaylist_Click(object sender, EventArgs e)
        {
            // Check if a playlist is selected
            if (lstPlaylists.SelectedItem == null)
            {
                MessageBox.Show("Please select a playlist to open.");
                return;
            }

            // Get the selected playlist name
            string playlistName = lstPlaylists.SelectedItem.ToString();

            // Open the playlist
            OpenPlaylist(playlistName);
        }

        private void OpenPlaylist(string playlistName)
        {
          
            try
            {
                string fileName = playlistName + ".txt";

                // Check if the playlist file exists
                if (File.Exists(fileName))
                {
                    // Get the playlist creation date
                    string playlistDate = File.GetCreationTime(fileName).ToString("dd MMMM yyyy");

                    // Open the playlist with its name and date
                    Playlist playlistForm = new Playlist(playlistName, playlistDate);
                    playlistForm.Show();
                    this.Hide(); // Hide Home
                }
                else
                {
                    MessageBox.Show("The playlist file could not be found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening playlist:\n" + ex.Message);
            }
        }
        

        private void btnUploadSong_Click(object sender, EventArgs e)
        {
            try

            {

                // Create the file selection window

                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Give the file selection window a title

                openFileDialog.Title = "Choose a Song";

                // Open the file selection window

                if (openFileDialog.ShowDialog() == DialogResult.OK)

                {

                    // Get the file selected by the user

                    string fileName = openFileDialog.FileName;

                    // Check if the file is an audio file

                    if (fileName.EndsWith(".mp3") ||

                        fileName.EndsWith(".wav") ||

                        fileName.EndsWith(".wma") ||

                        fileName.EndsWith(".aac") ||

                        fileName.EndsWith(".flac") ||

                        fileName.EndsWith(".m4a"))

                    {

                        // Put the selected file name into the Song Name textbox

                        txtSongName.Text = openFileDialog.SafeFileName;

                    }

                    else

                    {

                        MessageBox.Show("Please select an audio file.");

                        return;

                    }

                    // Check that the other song information has been entered

                    if (string.IsNullOrEmpty(txtArtist.Text) ||

                        string.IsNullOrEmpty(txtAlbum.Text) ||

                        string.IsNullOrEmpty(txtGenre.Text))

                    {

                        MessageBox.Show("Please enter the artist, album and genre.");

                        return;

                    }

                    // Check that at least one playlist has been selected

                    if (clbPlaylists.CheckedItems.Count == 0)

                    {

                        MessageBox.Show("Please select at least one playlist.");

                        return;

                    }

                    // Upload the song

                    UploadSong();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Error uploading song: " + ex.Message);

            }
        }
        private void UploadSong()
        {
            try
            {
                // Get the song information from the text boxes
                string songName = txtSongName.Text;
                string artist = txtArtist.Text;
                string album = txtAlbum.Text;
                string genre = txtGenre.Text;

                // Go through all selected playlists
                for (int i = 0; i < clbPlaylists.CheckedItems.Count; i++)
                {
                    // Get the selected playlist name
                    string playlistName =
                        clbPlaylists.CheckedItems[i].ToString();

                    // Create the playlist file name
                    string playlistFileName = playlistName + ".txt";

                    // Open the playlist file in append mode
                    StreamWriter writer =
                        new StreamWriter(playlistFileName, true);

                    // Save the song information
                    writer.WriteLine("Song Name: " + songName);
                    writer.WriteLine("Artist: " + artist);
                    writer.WriteLine("Album: " + album);
                    writer.WriteLine("Genre: " + genre);

                    // Add an empty line between songs
                    writer.WriteLine();

                    // Close the file
                    writer.Close();
                }

                MessageBox.Show("Song uploaded successfully.");

                // Clear the fields after uploading
                ClearSongFields();

                // Update the statistics
                LoadStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading song:\n" + ex.Message);
            }
        }
        private void ClearSongFields()
        {
            // Clear the song information
            txtSongName.Clear();
            txtArtist.Clear();
            txtAlbum.Clear();
            txtGenre.Clear();

            // Uncheck all playlists
            for (int i = 0; i < clbPlaylists.Items.Count; i++)
            {
                clbPlaylists.SetItemChecked(i, false);
            }

        }

        private void btnBrowsePlaylist_Click(object sender, EventArgs e)

        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set the title and filter for the file dialog to only show audio files
            openFileDialog.Title = "Select a Music File";
            openFileDialog.Filter =
                "Audio Files|*.mp3;*.wav;*.wma;*.m4a|All Files|*.*";
            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected file path to the txtNewPlaylist TextBox
                txtNewPlaylist.Text = openFileDialog.FileName;
            }
        }



        private void btnChooseSong_Click(object sender, EventArgs e)

        {
            //Create a string 
            string songPath;

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Choose a Song";
            openFileDialog.Filter =
                "Audio Files|*.mp3;*.wav;*.wma;*.m4a|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                songPath = openFileDialog.FileName;

                MessageBox.Show(
                    "Song selected:\n" + Path.GetFileName(songPath),
                    "Song Selected"
                );
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    // Perform logout actions here
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
            }
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Playlist playlistForm = new Playlist();
            playlistForm.Show();
            this.Hide();
        }
    }
}

    

    

