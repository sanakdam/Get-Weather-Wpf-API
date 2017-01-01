using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RestSharp;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<WeatherClass> weather = new List<WeatherClass>();

            Result result = new Result();
            string city = txtCity.Text;

            var client = new RestClient("http://api.openweathermap.org/data/2.5/weather");
            var req = new RestRequest(Method.GET);
            req.AddParameter("q", city);
            req.AddParameter("appid", "e2d296a6fc0846926cf7825f5e3b6867");

            IRestResponse<RootObject> response = client.Execute<RootObject>(req);

            weather.Add(new WeatherClass
            {
                ID = response.Data.id,
                Country = response.Data.sys.country,
                CityName = response.Data.name,
                Weather = response.Data.weather[0].main,
                WindSpeed = response.Data.wind.speed,
                WindDegree = response.Data.wind.deg,
                Temperature = response.Data.main.temp,
                Description = response.Data.weather[0].description,
            });

            result.dataGridWeather.ItemsSource = weather;
            result.ShowDialog();
        }
    }


    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public double message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class RootObject
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

}
