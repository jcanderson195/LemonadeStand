using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {

        public Game()
        {

            //This class is for the game flow of Lemonade Stand

            //Lemonade Stand Project
                //(X)Basic Lemonade Stand gameplay must be present (play a lemonade stand online for a bit to get familiar with the gameplay).
                //(X)A weather system that includes a forecast and actual weather.For example, this could mean a predicted forecast for a day or week and then what the actual weather is on the given day.
                //(X)Game must be a minimum of seven days
            
            //Price of product should affect demand.For example, if the price is too high, sales will decrease.
            //Weather should affect demand.For example, if it is sunny and 90 degrees, sales would likely skyrocket. 
            //Each customer should be a separate object with its own chance of buying a glass of lemonade.This means how much lemonade is purchased and how much they are willing to pay will vary from customer to customer.

        }

        

        public void GameFlow()
        {
            //contains flow of game


            //insert introduction function


            //insert day option choice function


            //(1.)insert store purchasing function(s) including current balance for money to purchase goods (money balance decreases as you purchase goods)
            //purchase cups function (insert: user enters amount of cups, that is multiplied by pre-determined amount($) for cups, thats subtracted from money balance)
            //purchase ice cubes function (insert: user enters amount of ice cubes, that is multiplied by pre-determined amount($) for ice cubes, thats subtracted from money balance)
            //purchase cups of sugar function (insert: user enters amount of cups of sugar, that is multiplied by pre-determined amount($) for cups of sugar, thats subtracted from money balance)
            //purchase lemons function (insert: user enters amount of lemons, that is multiplied by pre-determined amount($) for lemons, thats subtracted from money balance)

            //(2.)insert display current inventory and money balance
            //Dispaly Weather for Day 1 - 7
            //Option to go purchase more items
            //Option to continue to Day 1-7

            //(3.)Waits 10 seconds to simulate day operations for day 1-7 of lemonade stand

            //Steps 1-3 happen 7 times (each time before day of operation)





            //Weather
                //each day randomly generate temperature between 50-100 degrees 
                //each day randomly choose between hazy, cloudy, sunny, rainy to go along with temperature
                    //50 degress = 100 potential customers  (if temperature is <= 69, result is 100 potential customers)
                    //70 degress = 150 potential customers  (if temperature is >= 70, result is 150 potential customers)
                    //90 degrees = 175 potential customers  (if temperature is >= 90, result is 175 potential customers)
                    //95 degrees or higher = 200 potential customers (if temperature is >=95, result is 200 potential customers)

            //Customer
                //generate number between 100-200 customers to walk through based off temperature
                //create personality child classes from customer parent class
                    //Thirsty customer
                        //if temperature is >= 50 AND price is <= .70 (buys a random number of cups of lemonade between 1-3)
                        // else if temperature is >= 50 AND >=.71 (won't buy cup of lemonade)
                    //Weather dependent customer
                        //if temperature is >= 75 AND weather = sunny (buys a random number of cups of lemonade between 1-3)
                        //else if temperature is >= 75 AND weather = cloudy (buys 1 cup)
                        //else if temperature is >= 75 AND weather = Hazy (won't buy cup)
                        //else if temperature is >= 75 AND weather = rainy (won't buy cup)
                        //else if temperature is <= 75 (won't buy cup)
                    //Cheap customer 
                        //if temperature is >= 60 AND weather = sunny AND price <=.25 (buys a random number of cups of lemonade between 1-3)
                        //else if temperature is >= 60 AND price >= .26 (won't buy cup)      
                //generate random number of each customer type from number of customers to actually buy lemonade






        }
    }
}
