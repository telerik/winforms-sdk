using System;

namespace GridObjectRelationalCRUD.Models
{
    [Serializable]
    public class Track
    {
        private int id;
        private string name;
        private string mediaType;
        private string genre;
        private string size;

        public Track()
        {

        }

        public Track(int id, string name, string mediaType, string genre, string size)
        {
            this.id = id;
            this.name = name;
            this.mediaType = mediaType;
            this.genre = genre;
            this.size = size;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }
        
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
