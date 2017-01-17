using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUM4
{
    class Program
    {
        static void Main(string[] args)
        {
            var glosbes = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var tulips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holidayOrNot = Console.ReadLine();
            var price = 0.0;
            var discount = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                price = glosbes * 2.00 + roses * 4.10 + tulips * 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                price = glosbes * 3.75 + roses * 4.50 + tulips * 4.15;
            }
            if (holidayOrNot == "Y")
            {
                price = price + (price * 0.15);
            }
            //else if(holidayOrNot=="N")
            //{
            //    price = price;
            //}
            if (tulips > 7 && season == "Spring")
            {
                price = price - (price * 0.05);
            }
            if (roses > 9 && season == "Winter")
            {
                price = price - (price * 0.1);
            }
            if (glosbes + roses + tulips > 20)
            {
                price = price - (price * 0.2);
            }

            Console.WriteLine("{0:f2}", price + 2);


        }
    }
}
