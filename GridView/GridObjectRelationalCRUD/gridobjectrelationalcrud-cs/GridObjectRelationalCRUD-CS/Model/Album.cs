using System;
using System.Collections.Generic;

namespace GridObjectRelationalCRUD.Models
{
    [Serializable]
    public class Album 
    {
        private int id;
        private int artistId;
        private string title;
        private List<Track> tracks = new List<Track>();

        public Album()
        {

        }

        public Album(int id, int artistId, string title)
        {
            this.id = id;
            this.artistId = artistId;
            this.title = title;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int ArtistId
        {
            get { return artistId; }
            set { artistId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public List<Track> Tracks
        {
            get { return this.tracks; }
        }
    }
}
