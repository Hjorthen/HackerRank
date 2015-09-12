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
                if (N < 3)
                {
                    Console.WriteLine("-1");
                    continue;
                }
                int amount555 = 0;
                int amount33333 = 0;
                while(N >amount33333*3+amount555*5)
                {
                    if((N-(amount33333 * 3 + amount555 * 5))%3!=0)
                    {
                        if((N - (amount33333 * 3 + amount555 * 5)) % 5==0)
                        {
                            ++amount555;
                        }
                    }
                }
                

            }
            Console.ReadLine();


        }
    }
}
