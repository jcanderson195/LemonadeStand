using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int temperature;

        public Random rnd = new Random();
        Weather retrievePotentialCustomerNum = new Weather();

        public double lemonadePrice;

        public string weatherCondition;
        public string Hazy = "Hazy";
        public string Cloudy = "Cloudy";
        public string Sunny = "Sunny";
        public string Rainy = "Rainy";
        public double newWalletBalance;


        public Customer()
        {
            
   
            temperature = rnd.Next(50, 101);
            lemonadePrice = Convert.ToDouble(Console.ReadLine());

        }

        public void GetPotentialCustomerNumber()
        {

            retrievePotentialCustomerNum.TemperatureGenerator();

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

        public void ThirstyCustomer()
        {
            if (temperature >= 50 && lemonadePrice <= .70)
            {
                //insert buy cup function w/ randomizer for 1-3 cups
            }
            else if (temperature >= 50 && lemonadePrice >= .71)
            {
                //insert function for not buying cup
            }
        }

        public void WeatherDependantCustomer()
        {
            if (temperature >= 75 && weatherCondition == Sunny)
            {
                //insert buy cup function w/ randomizer for 1-3 cups
            }
            else if (temperature >= 75 && weatherCondition == Cloudy)
            {
                //insert function to buy 1 cup
            }
            else if (temperature >= 75 && weatherCondition == Hazy)
            {
                //insert function to not buy cup
            }
            else if (temperature >= 75 && weatherCondition == Rainy)
            {
                //insert function to not buy cup
            }
            else if (temperature <= 74)
            {
                //insert function to not buy cup
            }
        }

        public void CheapCustomer()
        {

            if (temperature >= 60 && weatherCondition == Sunny && lemonadePrice <= .25)
            {
                //insert buy cup function w/ randomizer for 1-3 cups
            }
            else if (temperature >= 60 && lemonadePrice >= .26)
            {
                //insert function to not buy cups
            }
        }

    }
}
