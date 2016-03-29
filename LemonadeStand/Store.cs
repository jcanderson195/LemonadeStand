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


        public Store()
        {

        }


        public double GetWalletBalance()
        {
            walletBalance = 30.00;
            return newWalletBalance;
        }

        public double PurchaseCups()
        {

            GetWalletBalance();
            Console.WriteLine("Note: 1 pitcher = 6 cups. 1 pitcher needs 2 cups of sugar and 4 lemons. Every cup needs 1 ice cube.");
            Console.WriteLine();

            Console.WriteLine("Please enter how many cups you would like to buy: 5 cents each! ");
            cupsInput = Convert.ToInt32(Console.ReadLine());
            cupsBought = cupsInput;
            cupsPrice = 0.05;
            cupsPriceTotal = cupsInput * cupsPrice;
            newWalletBalance = walletBalance - cupsPriceTotal;

            Console.WriteLine("You bought " + cupsBought + " cups for " + cupsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollar(s).");
            Console.WriteLine();

            CurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            return newWalletBalance;

        }

        public double PurchaseCupsSecondRound()
        {

            GetWalletBalance();
            Console.WriteLine("Note: 1 pitcher = 6 cups. 1 pitcher needs 2 cups of sugar and 4 lemons. Every cup needs 1 ice cube.");
            Console.WriteLine();

            Console.WriteLine("Please enter how many cups you would like to buy: 5 cents each! ");
            cupsInput = Convert.ToInt32(Console.ReadLine());
            cupsBought = cupsInput;
            cupsPrice = 0.05;
            cupsPriceTotal = cupsInput * cupsPrice;
            newWalletBalance = newWalletBalance - cupsPriceTotal;

            Console.WriteLine("You bought " + cupsBought + " cups for " + cupsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollar(s).");
            Console.WriteLine();

            CurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            return newWalletBalance;

        }

        public double PurchaseIceCubes()
        {
            GetWalletBalance();
            Console.WriteLine("Note: 1 pitcher = 6 cups. 1 pitcher needs 2 cups of sugar and 4 lemons. Every cup needs 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many ice cubes you would like to buy: 5 cents each!  ");
            iceCubeInput = Convert.ToInt32(Console.ReadLine());
            iceCubeBought = iceCubeInput;
            iceCubePrice = .05;
            iceCubePriceTotal = iceCubeInput * iceCubePrice;
            newWalletBalance = newWalletBalance - iceCubePriceTotal;

            Console.WriteLine("You bought " + iceCubeBought + " ice cubes for " + iceCubePriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine();

            CurrentInventory();
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;

        }

        public double PurchaseCupsofSugar()
        {
            GetWalletBalance();
            Console.WriteLine("Note: 1 pitcher = 6 cups. 1 pitcher needs 2 cups of sugar and 4 lemons. Every cup needs 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many cups of sugar you would like to buy: 10 cents each! ");
            cupsOfSugarInput = Convert.ToInt32(Console.ReadLine());
            cupsOfSugarBought = cupsOfSugarInput;
            cupsOfSugarPrice = .10;
            cupsOfSugarPriceTotal = cupsOfSugarInput * cupsOfSugarPrice;
            newWalletBalance = newWalletBalance - cupsOfSugarPriceTotal;

            Console.WriteLine("You bought " + cupsOfSugarBought + " cups of sugar for " + cupsOfSugarPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine();

            CurrentInventory();
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;
        }

        public double PurchaseLemons()
        {

            GetWalletBalance();
            Console.WriteLine("Note: 1 pitcher = 6 cups. 1 pitcher needs 2 cups of sugar and 4 lemons. Every cup needs 1 ice cube.");

            Console.WriteLine();

            Console.WriteLine("Please enter how many lemons you would like to buy: 6 cents each! ");
            lemonsInput = Convert.ToInt32(Console.ReadLine());
            lemonsBought = lemonsInput;
            lemonsPrice = .06;
            lemonsPriceTotal = lemonsInput * lemonsPrice;
            newWalletBalance = newWalletBalance - lemonsPriceTotal;

            Console.WriteLine("You bought " + lemonsBought + " lemons for " + lemonsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine();

            CurrentInventory();
            Console.WriteLine("----------------------------------------------------");
            CurrentInventory();

            return newWalletBalance;
        }

        public void CurrentInventory()
        {
            Console.WriteLine("Cups Total: " + cupsBought);
            Console.WriteLine("Ice Cube Total: " + iceCubeBought);
            Console.WriteLine("Cups of Sugar Total: " + cupsOfSugarBought);
            Console.WriteLine("Lemons Total: " + lemonsBought);


        }

        public void Pitcher()
        {
            int pitcher = (cupsBought - 6) - (cupsOfSugarBought - 2) - (lemonsBought - 4) - (iceCubeBought - 6);

        }










    }
}
