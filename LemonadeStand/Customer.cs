using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public Customer()
        {
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
