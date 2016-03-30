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

        Store boughtLemonade = new Store();
        Store noLemonade = new Store();

        public double lemonadePrice;

        public string weatherCondition;
        public string Hazy = "Hazy";
        public string Cloudy = "Cloudy";
        public string Sunny = "Sunny";
        public string Rainy = "Rainy";
        public double newWalletBalance;

        public Customer()
        {
            

        }

        
        public void ThirstyCustomer()
        {
            
            if (temperature >= 50 && lemonadePrice <= .70)
            {
                boughtLemonade.BuyOneCupLemonade();
                boughtLemonade.BuyOneCupLemonade();
                boughtLemonade.BuyOneCupLemonade();
            }
            else if (temperature >= 50 && lemonadePrice >= .71)
            {
                noLemonade.NoLemonadeBought();
            }
        }

        public void WeatherDependantCustomer()
        {
            if (temperature >= 75 && weatherCondition == Sunny)
            {
                boughtLemonade.BuyOneCupLemonade();
                boughtLemonade.BuyOneCupLemonade();
                boughtLemonade.BuyOneCupLemonade();
            }
            else if (temperature >= 75 && weatherCondition == Cloudy)
            {
                boughtLemonade.BuyOneCupLemonade();
            }
            else if (temperature >= 75 && weatherCondition == Hazy)
            {
                noLemonade.NoLemonadeBought();
            }
            else if (temperature >= 75 && weatherCondition == Rainy)
            {
                noLemonade.NoLemonadeBought();
            }
            else if (temperature <= 74)
            {
                noLemonade.NoLemonadeBought();
            }
        }

        public void CheapCustomer()
        {
            if (temperature >= 60 && weatherCondition == Sunny && lemonadePrice <= .25)
            {
                boughtLemonade.BuyOneCupLemonade();
                boughtLemonade.BuyOneCupLemonade();
                boughtLemonade.BuyOneCupLemonade();
            }
            else if (temperature >= 60 && lemonadePrice >= .26)
            {
                noLemonade.NoLemonadeBought();
            }
        }


    }
} 
