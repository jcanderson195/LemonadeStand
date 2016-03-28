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
        public double totalAmountForGoods;

        public Store()
        {
            //(1.)insert store purchasing function(s) including current balance for money to purchase goods (money balance decreases as you purchase goods)
            //purchase cups function (insert: user enters amount of cups, that is multiplied by pre-determined amount($) for cups, thats subtracted from money balance)
            //purchase ice cubes function (insert: user enters amount of ice cubes, that is multiplied by pre-determined amount($) for ice cubes, thats subtracted from money balance)
            //purchase cups of sugar function (insert: user enters amount of cups of sugar, that is multiplied by pre-determined amount($) for cups of sugar, thats subtracted from money balance)
            //purchase lemons function (insert: user enters amount of lemons, that is multiplied by pre-determined amount($) for lemons, thats subtracted from money balance)
        }

        public void StoreOperations()
        {

        }

        public double GetWalletBalance()
        {
            walletBalance = 30.00;
            return newWalletBalance;
        }

        public double PurchaseCups()
        {
            //work out function for package of cups instead of individual
            GetWalletBalance();
            Console.WriteLine("Please enter how many cups you would like to buy: 5 cents each ");
            cupsInput = Convert.ToInt32(Console.ReadLine());
            cupsBought = cupsInput;
            cupsPrice = 0.05;
            cupsPriceTotal = cupsInput * cupsPrice;
            newWalletBalance = walletBalance - cupsPriceTotal;

            Console.WriteLine("You bought "+cupsBought+ " cups for "+cupsPriceTotal+ " dollar(s)." );

            Console.WriteLine("Your wallet balance is now "+ newWalletBalance+ " dollar(s).");
            Console.WriteLine("----------------------------------------------------");
            return newWalletBalance;

        }

        public double PurchaseIceCubes()
        {
            GetWalletBalance();

            Console.WriteLine("Please enter how many ice cubes you would like to buy: 5 cents each  ");
            iceCubeInput = Convert.ToInt32(Console.ReadLine());
            iceCubeBought = iceCubeInput;
            iceCubePrice = .05;
            iceCubePriceTotal = iceCubeInput * iceCubePrice;
            newWalletBalance = newWalletBalance - iceCubePriceTotal;

            Console.WriteLine("You bought " + iceCubeBought + " ice cubes for " + iceCubePriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;

        }

        public double PurchaseCupsofSugar()
        {
            GetWalletBalance();
            Console.WriteLine("Please enter how many cups of sugar you would like to buy: 10 cents each ");
            cupsOfSugarInput = Convert.ToInt32(Console.ReadLine());
            cupsOfSugarBought = cupsOfSugarInput;
            cupsOfSugarPrice = .10;
            cupsOfSugarPriceTotal = cupsOfSugarInput * cupsOfSugarPrice;
            newWalletBalance = newWalletBalance - cupsOfSugarPriceTotal;

            Console.WriteLine("You bought " + cupsOfSugarBought + " cups of sugar for " + cupsOfSugarPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;
        }

        public double PurchaseLemons()
        {

            GetWalletBalance();
            Console.WriteLine("Please enter how many lemons you would like to buy: 6 cents each ");
            lemonsInput = Convert.ToInt32(Console.ReadLine());
            lemonsBought = lemonsInput;
            lemonsPrice = .06;
            lemonsPriceTotal = lemonsInput * lemonsPrice;
            newWalletBalance = newWalletBalance - lemonsPriceTotal;

            Console.WriteLine("You bought " + lemonsBought + " lemons for " + lemonsPriceTotal + " dollar(s).");

            Console.WriteLine("Your wallet balance is now " + newWalletBalance + " dollars.");
            Console.WriteLine("----------------------------------------------------");

            return newWalletBalance;
        }



        public double PurchaseGoods()
        {
            

            return totalAmountForGoods;
        }

    }
}
