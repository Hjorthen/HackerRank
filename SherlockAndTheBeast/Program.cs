using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < T; i++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int retVal = N;
                int threes = 0;
                int fives = 0;
                while(retVal > 0)
                {
                    if(retVal % 3==0)
                    {
                        fives = retVal;
                        break;
                    }
                    retVal -= 5;
                }
                threes = N - retVal;
                if(retVal < 0 || threes%5 != 0)
                {
                    Console.WriteLine("-1");
                    continue;
                }
                StringBuilder retString = new StringBuilder();
                retString.Append('5', fives);
                retString.Append('3', threes);

                Console.WriteLine(retString);

            }
            Console.ReadLine();


        }
    }
}
