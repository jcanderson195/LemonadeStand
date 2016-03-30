using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        
        public double walletBalance;
        public double newWalletBalance;

        public int cupsInput;
        public int cupsBought;
        public double cupsPriceTotal;
        public double cupsPrice;

        public int iceCubeInput;
        public int iceCubeBought;
        public double iceCubePriceTotal;
        public double iceCubePrice;

        public int cupsOfSugarInput;
        public int cupsOfSugarBought;
        public double cupsOfSugarPriceTotal;
        public double cupsOfSugarPrice;

        public int lemonsInput;
        public int lemonsBought;
        public double lemonsPriceTotal;
        public double lemonsPrice;

        public double lemonadePriceUserInput;
        public double lemonadePrice;
        public double profit;


        Weather newWeatherDisplay = new Weather();


        public Store()
        {
            walletBalance = 30.00;
        }

        public double GetWalletBalance()
        {
            
            return newWalletBalance;
        }

        public double PurchaseCups()
        {
            Console.WriteLine("Note: 1 cup needs 2 cups of sugar, 2 lemons, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many cups you would like to buy: 5 cents each! ");
            cupsInput = Convert.ToInt32(Console.ReadLine());
            cupsBought += cupsInput;
            cupsPrice = 0.05;
            cupsPriceTotal = cupsInput * cupsPrice;
            newWalletBalance = walletBalance - cupsPriceTotal;

            Console.WriteLine("You bought " + cupsBought + " cups for " + cupsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollar(s).");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            return newWalletBalance;

        }

        

        public double PurchaseIceCubes()
        {

            Console.WriteLine("Note: 1 cup needs 2 cups of sugar, 2 lemons, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many ice cubes you would like to buy: 5 cents each!  ");
            iceCubeInput = Convert.ToInt32(Console.ReadLine());
            iceCubeBought += iceCubeInput;
            iceCubePrice = .05;
            iceCubePriceTotal = iceCubeInput * iceCubePrice;
            newWalletBalance = newWalletBalance - iceCubePriceTotal;

            Console.WriteLine("You bought " + iceCubeBought + " ice cubes for " + iceCubePriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;

        }

        public double PurchaseCupsofSugar()
        {

            Console.WriteLine("Note: 1 cup needs 2 cups of sugar, 2 lemons, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many cups of sugar you would like to buy: 10 cents each! ");
            cupsOfSugarInput = Convert.ToInt32(Console.ReadLine());
            cupsOfSugarBought += cupsOfSugarInput;
            cupsOfSugarPrice = .10;
            cupsOfSugarPriceTotal = cupsOfSugarInput * cupsOfSugarPrice;
            newWalletBalance = newWalletBalance - cupsOfSugarPriceTotal;

            Console.WriteLine("You bought " + cupsOfSugarBought + " cups of sugar for " + cupsOfSugarPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;
        }

        public double PurchaseLemons()
        {

            Console.WriteLine("Note: 1 cup needs 2 cups of sugar, 2 lemons, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many lemons you would like to buy: 6 cents each! ");
            lemonsInput = Convert.ToInt32(Console.ReadLine());
            lemonsBought += lemonsInput;
            lemonsPrice = .06;
            lemonsPriceTotal = lemonsInput * lemonsPrice;
            newWalletBalance = newWalletBalance - lemonsPriceTotal;

            Console.WriteLine("You bought " + lemonsBought + " lemons for " + lemonsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            PlayerCurrentInventory();

            return newWalletBalance;
        }

        public void PlayerCurrentInventory()
        {
            Console.WriteLine("Cups Total: " + cupsBought);
            Console.WriteLine("Ice Cube Total: " + iceCubeBought);
            Console.WriteLine("Cups of Sugar Total: " + cupsOfSugarBought);
            Console.WriteLine("Lemons Total: " + lemonsBought);

        }

        public void PurchasedGoods()
        {
            GetWalletBalance();
            PurchaseCups();
            PurchaseIceCubes();
            PurchaseCupsofSugar();
            PurchaseLemons();

            Console.WriteLine();
            newWeatherDisplay.WeatherDisplay();

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

        
        public double LemonadePrice()
        {
            lemonadePriceUserInput = Convert.ToDouble(Console.ReadLine());
            lemonadePrice = lemonadePriceUserInput;
            return lemonadePrice;
        }
        

        public void BuyOneCupLemonade()
        {
            profit = newWalletBalance + lemonadePrice;
           int oneCup = (cupsBought - 1) - (cupsOfSugarBought - 2) - (lemonsBought - 2) - (iceCubeBought - 1);

        }

        public void NoLemonadeBought()
        {
            profit = newWalletBalance + 0;
        }

        public double ResultsFromDay()
        {
            newWalletBalance = newWalletBalance - profit; 
            return newWalletBalance;
        }









    }
}
