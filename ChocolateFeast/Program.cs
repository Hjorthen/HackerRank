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

                int chocolateBought = cash / price; //Amount of chocolate he can buy initially 
                int total = chocolateBought; 
                int wrappers = chocolateBought; //He gets a wrapper for each chocolate he buys 

              
                int bonusChocoloate = wrappers / wrapperCost; //How much chocolate can he get with his current wrappers?
                do
                {             
                    total += bonusChocoloate; 
                    wrappers = wrappers - (bonusChocoloate * wrapperCost); //Gets the leftover wrappers, which he couldn't turn in for chocolate
                    wrappers += bonusChocoloate; //Each bonus chocolate turn into a wrapper
                    bonusChocoloate = wrappers / wrapperCost;
                } while (bonusChocoloate > 0) ;

                    Console.WriteLine(total);
            }

            Console.ReadLine();
        }
    }
}
