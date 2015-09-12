using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());
            //int[] numbers = new int[arraySize];
            string[] elements = Console.ReadLine().Split(' ');
            double positive = 0;
            double zeroes = 0;
            double negatives = 0;
            double count = 0;
            foreach(string s in elements)
            {
                int val = Convert.ToInt32(s);
                ++count;
                if(val>0)
                {
                    ++positive;
                }
                else if(val<0)
                {
                    ++negatives;
                }
                else
                {
                    ++zeroes;
                }

            }
            Console.WriteLine(positive / count);
            Console.WriteLine(negatives / count);
            Console.WriteLine(zeroes / count);
        }
    }
}
