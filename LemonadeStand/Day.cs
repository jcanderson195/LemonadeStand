﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        
        Store priceOfLemonade = new Store();

        Weather potentialCustomerNum = new Weather();
        Weather PC100 = new Weather();
        Weather PC150 = new Weather();
        Weather PC175 = new Weather();
        Weather PC200 = new Weather();

        Store dayResults = new Store();
        public Day()
        {
            //contains functions regarding what day option you choose, what day number you are currently on, etc.
            //(3.)Waits 10 seconds to simulate day operations for day 1-7 of lemonade stand
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
                Inventory newStore = new Inventory();
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
            

            public void Day1()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }

        public void Day2()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }

        public void Day3()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }

        public void Day4()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }

        public void Day5()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }

        public void Day6()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }

        public void Day7()
        {
            Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
            priceOfLemonade.LemonadePrice();

            dayResults.ResultsFromDay();
        }


    }

        
    }

