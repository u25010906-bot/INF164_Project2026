using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF164_Project2026
{
    public class Song
    {
        //Data Members 
        private string mName;
        private string mArtist;
        private string mAlbum;
        private string mGenre;

        //Constructors

        public Song()
        {
            mName = "";
            mArtist = "";
            mAlbum = "";
            mGenre = "";
        }
        public Song (string name, string art, string alb, string gen)
        {
            mName = name;
            mArtist = art;
            mAlbum = alb;
            mGenre = gen;
        }

        // Properties
        public string Name
        {
            get {  return mName; }
            set { mName = value; }
        }

        public string Artist
        {
            get { return mArtist; }
            set { mArtist = value; }
        }

        public string Album
        {
            get { return mAlbum; }
            set { mAlbum = value; }
        }

        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }


    }
}
