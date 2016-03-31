using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        

        

        
        
        
        
        public Day()
        {
            
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


        public void WeekOperation()
        {
            
            Store priceOfLemonade = new Store();
            for (int day = 1; day < 8; day++)
            {
                Weather weatherDisplay = new Weather();
                Console.WriteLine("Day "+ day);
                Console.WriteLine();
                weatherDisplay.WeatherDisplay();
                Console.WriteLine();
                Console.WriteLine("Please enter how much you would like to charge for lemonade today in decimal form: ");
                
                priceOfLemonade.LemonadePrice();

                Console.WriteLine("---------------------Press Enter For Day Results-------------------------------");
                
                Console.ReadKey();
                Customer potentialCustomers = new Customer(priceOfLemonade);
                potentialCustomers.PotentialCustomerGenerator(weatherDisplay.temperature);
                
                    potentialCustomers.CustomersForPC100(weatherDisplay.temperature);
                
                    potentialCustomers.CustomersForPC150(weatherDisplay.temperature);
                
                    potentialCustomers.CustomersForPC175(weatherDisplay.temperature);
                
                    potentialCustomers.CustomersForPC200(weatherDisplay.temperature);

                Console.WriteLine("------------------------------------------------");
                
                Console.WriteLine("Day "+day);
                priceOfLemonade.ResultsFromDay();

                Console.ReadKey();
                Console.WriteLine("----------------------------------------------------");

            }

            priceOfLemonade.GameEnding();
        }

        
    }

        
    }

