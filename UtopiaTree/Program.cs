using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtopiaTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int cycles = Convert.ToInt32(Console.ReadLine());
                int height = 1;
                for (int m = 1; m <= cycles; m++)
                {
                    if(m%2==0)
                    {
                        ++height;
                    }
                    else
                    {
                        height *= 2;
                    }
                }
                Console.WriteLine(height);
            }
        }
    }
}
