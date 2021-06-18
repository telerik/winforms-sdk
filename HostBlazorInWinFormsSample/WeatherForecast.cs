using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostBlazorInWinFormsSample
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string ImagePath
        {
            get
            {
                if (this.Summary=="Sunny")
                {
                    return @"https://www.telerik.com/sfimages/default-source/winforms/blogs/sunny.png?sfvrsn=c1283f29_2";
                }
                else if (this.Summary=="Rainy")
                {
                    return @"https://www.telerik.com/sfimages/default-source/winforms/blogs/rainy.png?sfvrsn=fec23fe8_2";
                }
                return @"https://www.telerik.com/sfimages/default-source/winforms/blogs/cloudy.png?sfvrsn=b954049b_2";
            }
        }
    }
}
