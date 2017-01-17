using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUM6
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            var firstKM = speed * (firstTime / 60.00);

            var secondSpeed = speed + (speed * 0.1);

            var secondKM = secondSpeed * (secondTime / 60.00);

            var thirdSpeed = secondSpeed - (secondSpeed * 0.05);

            var thirdKM = thirdSpeed * (thirdTime / 60.00);

            var total = firstKM + secondKM + thirdKM;
            Console.WriteLine("{0:f2}", total);
        }
    }
}
