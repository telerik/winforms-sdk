using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection; 
using System.Windows.Forms; 

namespace HostBlazorInWinFormsSample
{
    public partial class RadTabbedForm1 : Telerik.WinControls.UI.RadTabbedForm
    {
        public RadTabbedForm1()
        {
            InitializeComponent();

            this.AllowAero = false;

            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<WeatherForecastService>();
            serviceCollection.AddBlazorWebView();
            BlazorWebView blazorWeather = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = serviceCollection.BuildServiceProvider(),
            };
            
            blazorWeather.RootComponents.Add<WeatherDay>("#app");
            this.radTabbedFormControlTab1.Text = "Weather";
            this.radTabbedFormControlTab1.Controls.Add(blazorWeather);

            BlazorWebView blazorCounter = new BlazorWebView()
            {
                Dock = DockStyle.Fill,
                HostPage = "wwwroot/index.html",
                Services = serviceCollection.BuildServiceProvider(),
            };
            blazorCounter.RootComponents.Add<Counter>("#app");
            this.radTabbedFormControlTab2.Text = "Counter";
            this.radTabbedFormControlTab2.Controls.Add(blazorCounter);
        }
    }
}
