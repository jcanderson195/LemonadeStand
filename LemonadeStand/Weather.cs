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
            PotentialCustomerGenerator();
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


        public void CustomersForPC100()
        {
            Customer newThirstyCustomer = new Customer();
            Customer newWeatherCustomer = new Customer();
            Customer newCheapCustomer = new Customer();

            if (potentialCustomerNumber == 100)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 30; thirstyCustomers++)
                {
                    newThirstyCustomer.ThirstyCustomer();
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 30; weatherDepeandantCustomers++)
                {
                    newWeatherCustomer.WeatherDependantCustomer();
                }
                for (int cheapCustomers = 0; cheapCustomers < 40; cheapCustomers++)
                {
                    newCheapCustomer.CheapCustomer();
                }
            }
        }

        public void CustomersForPC150()
        {
            Customer newThirstyCustomer = new Customer();
            Customer newWeatherCustomer = new Customer();
            Customer newCheapCustomer = new Customer();

            if (potentialCustomerNumber == 150)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 50; thirstyCustomers++)
                {
                    newThirstyCustomer.ThirstyCustomer();
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 50; weatherDepeandantCustomers++)
                {
                    newWeatherCustomer.WeatherDependantCustomer();
                }
                for (int cheapCustomers = 0; cheapCustomers < 50; cheapCustomers++)
                {
                    newCheapCustomer.CheapCustomer();
                }
            }
        }

        public void CustomersForPC175()
        {
            Customer newThirstyCustomer = new Customer();
            Customer newWeatherCustomer = new Customer();
            Customer newCheapCustomer = new Customer();

            if (potentialCustomerNumber == 175)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 75; thirstyCustomers++)
                {
                    newThirstyCustomer.ThirstyCustomer();
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 50; weatherDepeandantCustomers++)
                {
                    newWeatherCustomer.WeatherDependantCustomer();
                }
                for (int cheapCustomers = 0; cheapCustomers < 50; cheapCustomers++)
                {
                    newCheapCustomer.CheapCustomer();
                }
            }
        }
        public void CustomersForPC200()
        {
            Customer newThirstyCustomer = new Customer();
            Customer newWeatherCustomer = new Customer();
            Customer newCheapCustomer = new Customer();

            if (potentialCustomerNumber == 200)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 80; thirstyCustomers++)
                {
                    newThirstyCustomer.ThirstyCustomer();
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 60; weatherDepeandantCustomers++)
                {
                    newWeatherCustomer.WeatherDependantCustomer();
                }
                for (int cheapCustomers = 0; cheapCustomers < 60; cheapCustomers++)
                {
                    newCheapCustomer.CheapCustomer();
                }
            }
        }
    }
}






