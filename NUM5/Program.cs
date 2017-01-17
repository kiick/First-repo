using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUM5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var pricePerPlate = double.Parse(Console.ReadLine());
            var workerPrice = double.Parse(Console.ReadLine());


            var areaWholePlace = width * height;
            var plateSize = (a * h) / 2;
            var platesNeeded =
                Math.Ceiling(areaWholePlace / plateSize) + 5;
            var price = platesNeeded * pricePerPlate + workerPrice;

            if (price > cash)
            {
                Console.WriteLine("You'll need {0:f2} lv more."
                    , price - cash);
            }
            else
            {
                Console.WriteLine("{0:f2} lv left.", cash - price);
            }
        }
    }
}
