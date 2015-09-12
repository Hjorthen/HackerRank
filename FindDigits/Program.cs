using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                foreach(int n in GetIntengersInNumber(number))
                {
                    if(n!=0 && (number%n==0))
                    {
                        ++count;
                    }
                }
                Console.WriteLine(count);
            }
        }
        static int[] GetIntengersInNumber(int n)
        {
            //Creates an array with a lenght equal to the number of digits
            int[] retArr = new int[(int)Math.Floor(Math.Log10(n)+1)];
            int i = 0;
            while (n>0)
            {
                retArr[i] = n % 10;
                n /= 10;
                ++i;
            }
            return retArr;
        }
    }
}