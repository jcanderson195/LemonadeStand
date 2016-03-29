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
        public string weatherCondition;
        public string Hazy = "Hazy";
        public string Cloudy = "Cloudy";
        public string Sunny = "Sunny";
        public string Rainy = "Rainy";
        public int potentialCustomerNumber;
        public int resultPotentialCustomerNumber;
        public Random rnd = new Random();

        public Weather()
        {
            temperature = rnd.Next(50, 101);
        }

        

        public void TemperatureGenerator()
        {
            
            Console.WriteLine(temperature + " degrees");
            PotentialCustomerGenerator();
        }
            
        public void WeatherConditionGenerator()
        {
            int weatherCondition = rnd.Next(1, 5);

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

            public int PotentialCustomerGenerator()
        {
            if (temperature <= 69)
            {
                potentialCustomerNumber = 100;
                Console.WriteLine(potentialCustomerNumber + " potential customers");
            }
            else if (temperature <= 89)
            {
                potentialCustomerNumber = 150;
                Console.WriteLine(potentialCustomerNumber + " potential customers");
            }
            else if (temperature <= 94)
            {
                potentialCustomerNumber = 175;
                Console.WriteLine(potentialCustomerNumber + " potential customers");
            }
            else if (temperature >= 95)
            {
                potentialCustomerNumber = 200;
                Console.WriteLine(potentialCustomerNumber + " potential customers");
            }
            int resultPotentialCustomerNumber = potentialCustomerNumber;
            return resultPotentialCustomerNumber;
        }
    }
            
        }
        

    

