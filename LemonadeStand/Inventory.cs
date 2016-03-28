using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        Weather newTemp = new Weather();

        Weather newCondition = new Weather();

        Store purchase = new Store();

        
        public Inventory()
        {
            //(2.)insert display current inventory and money balance
            //Dispaly Weather for Day 1 - 7
            //Option to go purchase more items
            //Option to continue to Day 1-7
        }



        public void PurchasedGoods()
        {
            
            purchase.PurchaseCups();
            purchase.PurchaseIceCubes();
            purchase.PurchaseCupsofSugar();
            purchase.PurchaseLemons();

            Console.WriteLine();
            newCondition.WeatherConditionGenerator();
            newTemp.TemperatureGenerator();

            Console.WriteLine("----------------------------------------------------");


            StoreOperations();

            

        }

        public void StoreOperations()
        {

            Console.WriteLine("Please choose what you would like to do: ");

            Console.WriteLine();

            Console.WriteLine("1. Purchase more items");
            Console.WriteLine("2. Continue to Day");
            Console.WriteLine("3. Exit");

            Console.WriteLine("----------------------------------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                PurchasedGoods();
            }
            else if (choice == 2)
            {
                //isert continue to Day function
            }
            else if (choice == 3)
            {
                Console.WriteLine("THANK YOU FOR PLAYING LEMONADE STAND!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("I'm sorry. I don't recognize that command! Please enter the numerical value associated with your choice!");
                Console.WriteLine("----------------------------------------------------");

                StoreOperations();
            }
        }

    }
}
