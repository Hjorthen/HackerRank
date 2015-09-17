using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            
            while(testCases-- > 0)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int cash = Convert.ToInt32(tokens[0]);
                int price = Convert.ToInt32(tokens[1]);
                int wrapperCost = Convert.ToInt32(tokens[2]);

                int chocolateBought = cash / price;
                int bonusChocoloate = chocolateBought / wrapperCost;
                Console.WriteLine((bonusChocoloate + chocolateBought));
            }

            Console.ReadLine();
        }
    }
}
