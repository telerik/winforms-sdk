using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using GridObjectRelationalCRUD.Properties;

namespace GridObjectRelationalCRUD.Models
{
    public class DataContext
    {
        private static List<Artist> artistsField = null;
        private static List<Artist> topArtistsField = null;

        protected DataContext()
        {
        }

        public static List<Artist> Artists
        {
            get 
            {
                if (artistsField == null)
                {
                    XmlSerializer mySerializer = new XmlSerializer(typeof(List<Artist>));
                    FileStream myFileStream = new FileStream(@"..\..\artists.xml", FileMode.Open);
                    artistsField = (List<Artist>)mySerializer.Deserialize(myFileStream);
                }

                return artistsField; 
            }
        }

        public static List<Artist> TopArtists
        {
            get
            {
                if (topArtistsField == null)
                {
                    using (MemoryStream stream = new MemoryStream(Resources.ChinookModel))
                    {
                        XmlSerializer mySerializer = new XmlSerializer(typeof(List<Artist>));
                        FileStream myFileStream = new FileStream(@"..\..\artists.xml", FileMode.Open);
                        topArtistsField = (List<Artist>)mySerializer.Deserialize(myFileStream);

                        while (topArtistsField.Count > 50)
                        {
                            topArtistsField.RemoveAt(topArtistsField.Count - 1);
                        }
                    }
                }

                return topArtistsField;
            }
        }
    }
}
