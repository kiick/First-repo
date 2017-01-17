using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUM1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var excluding = char.Parse(Console.ReadLine());
            int cnt = 0;

            for (var o = firstLetter; o <= secondLetter; o++)
            {
                for (var j = firstLetter; j <= secondLetter; j++)
                {
                    for (var k = firstLetter; k <= secondLetter; k++)
                    {
                        if (excluding == o 
                            || excluding == j
                            || excluding == k)
                        {
                            continue;
                        }
                        Console.Write($"{o}{j}{k} ");
                        cnt++;
                    }
                }
            }
            Console.Write(cnt);
        }
    }
}
