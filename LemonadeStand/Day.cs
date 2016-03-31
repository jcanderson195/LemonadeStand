﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {

        
        

        Weather weatherDisplay = new Weather();
        
        
        public Day()
        {
            //contains functions regarding what day option you choose, what day number you are currently on, etc.
            //(3.)simulate day operations for day 1-7 of lemonade stand
        }

        public void DayOption()
        {
            //class for choosing how many days you want to operate your lemonade stand
            Console.WriteLine("Since this is a beta form Lemonade Stand, you only have the option to play for 7 days. Is that okay with you?");
            Console.WriteLine();
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("----------------------------------------------------");
                Store newStore = new Store();
                newStore.PurchasedGoods();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Thank you for playing Lemonade Stand!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I'm sorry I don't recognize that command. Please type 1 or 2 for your answer!");
                DayOption();
            }
        }
            

            public void DayOperation()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            Console.WriteLine("----------------------------------------------------");
            weatherDisplay.WeatherDisplay();
            Console.ReadKey();
            Customer potentialCustomers = new Customer();
            potentialCustomers.CustomersForPC100(50);
            potentialCustomers.CustomersForPC150(50);
            potentialCustomers.CustomersForPC175(50);
            potentialCustomers.CustomersForPC200(50);
            
            Console.WriteLine("----------------------------------------------------");
            Store dayResults = new Store();
            dayResults.ResultsFromDay();

            Console.ReadKey();
            Console.WriteLine("----------------------------------------------------");
            Store storeMenu = new Store();
            storeMenu.PurchasedGoods();
            
        }

        public void Day2()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            
        }

        public void Day3()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            
        }

        public void Day4()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            
        }

        public void Day5()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            
        }

        public void Day6()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            
        }

        public void Day7()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            Store priceOfLemonade = new Store();
            priceOfLemonade.LemonadePrice();

            
        }


    }

        
    }

