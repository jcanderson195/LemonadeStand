using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int temperature;
        public int weatherCondition;

        public int potentialCustomerNumber;
        public int resultPotentialCustomerNumber;

        
        
        public Weather()
        {
            
            Random rnd = new Random();
            temperature = rnd.Next(50, 101);
            weatherCondition = rnd.Next(1, 5);
        }



        public void TemperatureGenerator()
        {
            
            Console.WriteLine(temperature + " degrees");
        }

        public void WeatherConditionGenerator()
        {
            string Hazy = "Hazy";
            string Cloudy = "Cloudy";
            string Sunny = "Sunny";
            string Rainy = "Rainy";

            if (weatherCondition == 1)
            {
                Console.WriteLine(Hazy);
            }
            else if (weatherCondition == 2)
            {
                Console.WriteLine(Cloudy);
            }
            else if (weatherCondition == 3)
            {
                Console.WriteLine(Sunny);
            }
            else if (weatherCondition == 4)
            {
                Console.WriteLine(Rainy);
            }

        }

        public void WeatherDisplay()
        {

            WeatherConditionGenerator();

            TemperatureGenerator();

        }

        
    }
}






