﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
       public Store newStore;

        public int potentialCustomerNumber;

        public Random rnd = new Random();

      
        public double lemonadePrice;

        public string weatherCondition;
        public string Hazy = "Hazy";
        public string Cloudy = "Cloudy";
        public string Sunny = "Sunny";
        public string Rainy = "Rainy";
        public double newWalletBalance;

        public Customer(Store NewStore)
        {

            newStore = NewStore;
        }
  
        public void ThirstyCustomer(int temperature)
        {
            
            if (temperature >= 50 && lemonadePrice <= .70)
            {
                
                newStore.BuyOneCupLemonade();
                newStore.BuyOneCupLemonade();

            }
            else if (temperature >= 50 && lemonadePrice >= .71)
            {
                newStore.NoLemonadeBought();
            }
        }

        public void WeatherDependantCustomer(int temperature)
        {
            if (temperature >= 75 && weatherCondition == Sunny)
            {

                newStore.BuyOneCupLemonade();
                newStore.BuyOneCupLemonade();

            }
            else if (temperature >= 75 && weatherCondition == Cloudy)
            {
                newStore.BuyOneCupLemonade();
            }
            else if (temperature >= 75 && weatherCondition == Hazy)
            {
                newStore.NoLemonadeBought();
            }
            else if (temperature >= 75 && weatherCondition == Rainy)
            {
                newStore.NoLemonadeBought();
            }
            else if (temperature <= 74)
            {
                newStore.NoLemonadeBought();
            }
        }

        public void CheapCustomer(int temperature)
        {
            if (temperature >= 60 && weatherCondition == Sunny && lemonadePrice <= .25)
            {

                newStore.BuyOneCupLemonade();
                newStore.BuyOneCupLemonade();

            }
            else if (temperature >= 60 && lemonadePrice >= .26)
            {
                newStore.NoLemonadeBought();
            }
        }


        public int PotentialCustomerGenerator(int temperature)
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


        public void CustomersForPC100(int temperarture)
        {  
            if (potentialCustomerNumber == 100)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 30; thirstyCustomers++)
                {
                    ThirstyCustomer(temperarture);
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 30; weatherDepeandantCustomers++)
                {
                    WeatherDependantCustomer(temperarture);
                }
                for (int cheapCustomers = 0; cheapCustomers < 40; cheapCustomers++)
                {
                    CheapCustomer(temperarture);
                }
            }
        }

        public void CustomersForPC150(int temperature)
        {
            
            if (potentialCustomerNumber == 150)
            {
                
                for (int thirstyCustomers = 0; thirstyCustomers < 50; thirstyCustomers++)
                {

                    ThirstyCustomer(temperature);
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 50; weatherDepeandantCustomers++)
                {
                    WeatherDependantCustomer(temperature);
                }
                for (int cheapCustomers = 0; cheapCustomers < 50; cheapCustomers++)
                {
                    CheapCustomer(temperature);
                }
            }
        }

        public void CustomersForPC175(int temperature)
        {
           
            if (potentialCustomerNumber == 175)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 75; thirstyCustomers++)
                {
                    ThirstyCustomer(temperature);
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 50; weatherDepeandantCustomers++)
                {
                    WeatherDependantCustomer(temperature);
                }
                for (int cheapCustomers = 0; cheapCustomers < 50; cheapCustomers++)
                {
                    CheapCustomer(temperature);
                }
            }
        }
        public void CustomersForPC200(int temperature)
        {
            

            if (potentialCustomerNumber == 200)
            {
                for (int thirstyCustomers = 0; thirstyCustomers < 80; thirstyCustomers++)
                {
                    ThirstyCustomer(temperature);
                }
                for (int weatherDepeandantCustomers = 0; weatherDepeandantCustomers < 60; weatherDepeandantCustomers++)
                {
                    WeatherDependantCustomer(temperature);
                }
                for (int cheapCustomers = 0; cheapCustomers < 60; cheapCustomers++)
                {
                    CheapCustomer(temperature);
                }
            }
        }


    }
} 
