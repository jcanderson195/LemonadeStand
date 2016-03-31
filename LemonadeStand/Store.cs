using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        
        public double walletBalance;
        

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
        public double totalProfit;
        public double endResult;

        Weather newWeatherDisplay = new Weather();

        Day runDay = new Day();

        public Store()
        {
            walletBalance = 200.00;
        }

        public double GetWalletBalance()
        {
            
            return walletBalance;
        }

        public double PurchaseCups()
        {
            Console.WriteLine("Note: 1 cup of lemonade needs 1 cup of sugar, 1 lemon, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many cups you would like to buy: 5 cents each! ");
            cupsInput = Convert.ToInt32(Console.ReadLine());
            cupsBought += cupsInput;
            cupsPrice = 0.05;
            cupsPriceTotal = cupsInput * cupsPrice;
            walletBalance = walletBalance - cupsPriceTotal;

            Console.WriteLine("You bought " + cupsBought + " cups for " + cupsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + walletBalance + " dollar(s).");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            return walletBalance;

        }

        

        public double PurchaseIceCubes()
        {

            Console.WriteLine("Note: 1 cup of lemonade needs 1 cup of sugar, 1 lemon, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many ice cubes you would like to buy: 5 cents each!  ");
            iceCubeInput = Convert.ToInt32(Console.ReadLine());
            iceCubeBought += iceCubeInput;
            iceCubePrice = .05;
            iceCubePriceTotal = iceCubeInput * iceCubePrice;
            walletBalance = walletBalance - iceCubePriceTotal;

            Console.WriteLine("You bought " + iceCubeBought + " ice cubes for " + iceCubePriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + walletBalance + " dollars.");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");

            return walletBalance;

        }

        public double PurchaseCupsofSugar()
        {

            Console.WriteLine("Note: 1 cup of lemonade needs 1 cup of sugar, 1 lemon, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many cups of sugar you would like to buy: 10 cents each! ");
            cupsOfSugarInput = Convert.ToInt32(Console.ReadLine());
            cupsOfSugarBought += cupsOfSugarInput;
            cupsOfSugarPrice = .10;
            cupsOfSugarPriceTotal = cupsOfSugarInput * cupsOfSugarPrice;
            walletBalance = walletBalance - cupsOfSugarPriceTotal;

            Console.WriteLine("You bought " + cupsOfSugarBought + " cups of sugar for " + cupsOfSugarPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + walletBalance + " dollars.");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");

            return walletBalance;
        }

        public double PurchaseLemons()
        {

            Console.WriteLine("Note: 1 cup of lemonade needs 1 cup of sugar, 1 lemon, and 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many lemons you would like to buy: 6 cents each! ");
            lemonsInput = Convert.ToInt32(Console.ReadLine());
            lemonsBought += lemonsInput;
            lemonsPrice = .06;
            lemonsPriceTotal = lemonsInput * lemonsPrice;
            walletBalance = walletBalance - lemonsPriceTotal;

            Console.WriteLine("You bought " + lemonsBought + " lemons for " + lemonsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + walletBalance + " dollars.");
            Console.WriteLine();

            PlayerCurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            
            Console.WriteLine("Item Inventory");
            Console.WriteLine();
            PlayerCurrentInventory();

            return walletBalance;
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
            //newWeatherDisplay.WeatherDisplay();

            Console.WriteLine("----------------------------------------------------");

            StoreOperations();

        }
        public void StoreOperations()
        {

            Console.WriteLine("Please choose what you would like to do: ");

            Console.WriteLine();

            Console.WriteLine("1. Purchase more items");
            Console.WriteLine("2. Continue to Week");
            Console.WriteLine("3. Exit");

            Console.WriteLine("----------------------------------------------------");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("----------------------------------------------------");
                PurchasedGoods();
            }
            else if (choice == 2)
            {
                Console.WriteLine("----------------------------------------------------");
                runDay.WeekOperation();
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
        

        public double BuyOneCupLemonade()
        {
            profit += lemonadePrice;
           int one = (cupsBought - 1) - (cupsOfSugarBought - 1) - (lemonsBought - 1) - (iceCubeBought - 1);
            return profit;
        }

        public double NoLemonadeBought()
        {
            profit +=  0;
            return profit;
        }

        public double ResultsFromDay()
        {
            walletBalance = walletBalance + profit;
            Console.WriteLine("Profit made today: "+ profit);

             totalProfit += profit;
            
            Console.WriteLine("Total profit earned: "+totalProfit);

            return totalProfit;
        }
        
        public void GameEnding()
        {
            
            Console.WriteLine("Thank you for playing Lemonade Stand!");
            Console.WriteLine();
            Console.WriteLine("At the end of the week, you made $"+totalProfit);
             
            Console.ReadKey();
        }








    }
}
