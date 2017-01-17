using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUM3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var topStudents = 0.0;
            var betweenFourAndFive = 0.0;
            var betweenThreeAndFour = 0.0;
            var belowThree = 0.0;
            var average = 0.0;
            for (int i = 0; i < n; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade < 3.00)
                {
                    belowThree++;
                }
                else if (grade < 4.00)
                {
                    betweenThreeAndFour++;
                }
                else if (grade < 5.00)
                {
                    betweenFourAndFive++;
                }
                else
                {
                    topStudents++;
                }
                average += grade;
            }
            Console.WriteLine("Top students: {0:f2}%",
                (100*topStudents/n));

            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%",
                (100*betweenFourAndFive/n));

            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%",
                (100*betweenThreeAndFour/n));

            Console.WriteLine("Fail: {0:f2}%",
                (100*belowThree/n));

            Console.WriteLine("Average: {0:f2}",
                average / n);
        }
    }
}
