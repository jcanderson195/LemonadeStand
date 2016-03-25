using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {

            Weather tempGenerator = new Weather();
            tempGenerator.TemperatureGenerator();

            Console.WriteLine();

            Weather newCondition = new Weather();
            newCondition.WeatherConditionGenerator(); 

        }
    }
}
