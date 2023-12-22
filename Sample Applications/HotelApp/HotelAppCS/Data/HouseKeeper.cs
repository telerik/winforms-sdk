using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Data
{
    public class HouseKeeper
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public System.Drawing.Bitmap Photo { get; set; }
        
        public HouseKeeper(int id, string name, System.Drawing.Bitmap img)
        {
            this.Id = id;
            this.Name = name;
            this.Photo = img;
        }
    }
}