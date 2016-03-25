using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public int temperature;
        public Random rnd = new Random();
        public string weatherCondition;
        public string Hazy = "Hazy";
        public string Cloudy = "Cloudy";
        public string Sunny = "Sunny";
        public string Rainy = "Rainy";

        public Weather()
        {
            //Weather
            //each day randomly generate temperature between 50-100 degrees 
            //each day randomly choose between hazy, cloudy, sunny, rainy to go along with temperature
            //50 degress = 100 potential customers  (if temperature is <= 69, result is 100 potential customers)
            //70 degress = 150 potential customers  (if temperature is >= 70, result is 150 potential customers)
            //90 degrees = 175 potential customers  (if temperature is >= 90, result is 175 potential customers)
            //95 degrees or higher = 200 potential customers (if temperature is >=95, result is 200 potential customers)
        }

        public int TemperatureGenerator()
        {
            temperature = rnd.Next(50, 101);
            Console.WriteLine(temperature+ " degrees");
            return temperature;
        }

        public void WeatherConditionGenerator()
        {
            int weatherCondition = rnd.Next(1,5);
            
            switch (weatherCondition)
            {
                case 1:
                    Console.WriteLine(Hazy);
                    break;
                case 2:
                    Console.WriteLine(Cloudy);
                    break;
                case 3:
                    Console.WriteLine(Sunny);
                    break;
                case 4:
                    Console.WriteLine(Rainy);
                    break;
            }  

        }
        

    }
}
