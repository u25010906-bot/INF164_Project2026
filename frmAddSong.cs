using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164_Project2026
{
    public partial class frmAddSong : Form
    {
        public frmAddSong()
        {
            InitializeComponent();
        }


        // Data Member
        private Song mNewSong;

        //property 
        public Song NewSong
        {
            get { return mNewSong; }          
        }
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            mNewSong = new Song ();

            // for every new student, get value from the textboxes
            mNewSong.Name = txtName.Text;
            mNewSong.Artist = txtArtist.Text;
            mNewSong.Album = txtGenre.Text;
            mNewSong.Genre = txtGenre.Text;

            this.Close();
        }
    }
}
