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

        }

        public void GameFlow()
        {
            
            UserInterface Intro = new UserInterface();
            Intro.Introduction();

            Day daySelection = new Day();
            daySelection.DayOption();

 
        }
    }
}
