using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class WeatherClass
    {
        private int _ID;
        private string _Country;
        private string _CityName;
        private string _Weather;
        private string _Description;
        private double _WindSpeed;
        private double _WindDegree;
        private double _Temperature;


        public int ID
        {
            set { _ID = value; }
            get { return _ID; }
        }

        public string Country
        {
            set { _Country = value; }
            get { return _Country; }
        }

        public string CityName
        {
            set { _CityName = value; }
            get { return _CityName; }
        }

        public string Weather
        {
            set { _Weather = value; }
            get { return _Weather; }
        }

        public string Description
        {
            set { _Description = value; }
            get { return _Description; }
        }

        public double WindSpeed
        {
            set { _WindSpeed = value; }
            get { return _WindSpeed; }
        }

        public double WindDegree
        {
            set { _WindDegree = value; }
            get { return _WindDegree; }
        }

        public double Temperature
        {
            set { _Temperature = value; }
            get { return _Temperature; }
        }
    }
}
